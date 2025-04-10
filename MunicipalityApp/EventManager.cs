using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{

    // Class representing the Event Manager
    public class EventManager
    {
        // Sorted dictionary to store events by date
        public SortedDictionary<DateTime, List<Event>> EventsByDate { get; private set; } = new SortedDictionary<DateTime, List<Event>>();

        // Queue to store announcements
        private Queue<Announcement> Announcements = new Queue<Announcement>();

        // HashSet to store unique categories
        public HashSet<string> Categories { get; private set; } = new HashSet<string>();

        // Stack to store recent searches
        public Stack<string> RecentSearches { get; private set; } = new Stack<string>();

        // Dictionary to store search history
        private Dictionary<string, int> _searchHistory = new Dictionary<string, int>();

        // Method to add an event
        public void AddEvent(Event ev)
        {
            // Check if the event date already exists in the dictionary
            if (!EventsByDate.ContainsKey(ev.Date))
                EventsByDate[ev.Date] = new List<Event>();

            // Add the event to the list of events on that date
            EventsByDate[ev.Date].Add(ev);

            // Add the event category to the set of categories
            Categories.Add(ev.Category); // Ensure unique categories
        }

        // Method to add a search history
        public void AddSearchHistory(string category)
        {
            // Check if the category already exists in the search history
            if (_searchHistory.ContainsKey(category))
            {
                // Increment the count for the category
                _searchHistory[category]++;
            }
            else
            {
                // Add the category to the search history with count 1
                _searchHistory.Add(category, 1);
            }
        }

        // Method to add an announcement
        public void AddAnnouncement(Announcement announcement)
        {
            // Add the announcement to the queue
            Announcements.Enqueue(announcement);
        }

        // Method to get the announcements as a list
        public List<Announcement> GetAnnouncements()
        {
            // Convert the queue to a list and return
            return Announcements.ToList();
        }

        // Method to search events based on category and date
        public List<Event> SearchEvents(string category, DateTime? date)
        {
            var results = new List<Event>();

            // Case 1: Search by both category and date
            if (!string.IsNullOrEmpty(category) && date.HasValue)
            {
                // Check if the date exists in the dictionary
                if (EventsByDate.TryGetValue(date.Value, out var eventsOnDate))
                {
                    // Add events with matching category to the results list
                    results.AddRange(eventsOnDate
                        .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase)));
                }
            }
            // Case 2: Search by category only
            else if (!string.IsNullOrEmpty(category))
            {
                // Add events with matching category from all dates to the results list
                results.AddRange(EventsByDate.Values
                    .SelectMany(events => events
                        .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))));
            }
            // Case 3: Search by date only
            else if (date.HasValue && EventsByDate.TryGetValue(date.Value, out var eventsOnDate))
            {
                // Add all events on the specified date to the results list
                results.AddRange(eventsOnDate);
            }
            // Case 4: No filters provided, return all events
            else
            {
                // Add all events from all dates to the results list
                results.AddRange(EventsByDate.Values.SelectMany(e => e));
            }

            // Remove duplicates from the results list and return
            return results.Distinct().ToList();
        }

        // Method to recommend events based on search history
        public List<Event> RecommendEvents()
        {
            var recommendedEvents = new List<Event>();

            // Get the top 3 most frequently searched categories
            var topCategories = _searchHistory.OrderByDescending(x => x.Value).Take(3);

            foreach (var category in topCategories)
            {
                // Get events with matching category from all dates
                var events = EventsByDate.Values.SelectMany(e => e)
                    .Where(e => e.Category.Equals(category.Key, StringComparison.OrdinalIgnoreCase));

                // Add the first 5 events to the recommended events list
                recommendedEvents.AddRange(events.Take(5));
            }

            // Remove duplicates from the recommended events list and return
            return recommendedEvents.Distinct().ToList();
        }
    }

}
