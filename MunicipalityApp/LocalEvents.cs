using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class LocalEvents : Form
    {
        // Instance of EventManager to manage events and announcements
        private EventManager eventManager = new EventManager();

        public LocalEvents()
        {
            InitializeComponent();
            // Attach event handler for form load event
            this.Load += LocalEvents_Load;
        }

        // Event handler for form load event
        private void LocalEvents_Load(object sender, EventArgs e)
        {
            // Initialize sample events and announcements
            InitializeSampleEvents();
            InitializeSampleAnnouncements();

            // Load data into UI components
            LoadAnnouncements();
            LoadRecommendations();
            LoadEvents();
        }

        // Method to initialize sample events
        private void InitializeSampleEvents()
        {
            // Populate the event manager with some sample events
            eventManager.AddEvent(new Event(1, "Rock Fest", "A great music concert", "Music Concert", DateTime.Today, new TimeSpan(18, 0, 0)));
            eventManager.AddEvent(new Event(2, "Art Gala", "Exquisite art pieces on display", "Art Exhibition", DateTime.Today.AddDays(2), new TimeSpan(16, 0, 0)));
            eventManager.AddEvent(new Event(3, "Community Meet", "Discuss community issues", "Community Outreach", DateTime.Today, new TimeSpan(10, 0, 0)));
            eventManager.AddEvent(new Event(4, "Food Festival", "Food stalls and live music", "Food Market", DateTime.Today.AddDays(1), new TimeSpan(12, 0, 0)));
            eventManager.AddEvent(new Event(5, "Sports Day", "Sports and games for all", "Sports Event", DateTime.Today.AddDays(3), new TimeSpan(9, 0, 0)));
        }

        // Method to initialize sample announcements
        private void InitializeSampleAnnouncements()
        {
            // Populate the event manager with some sample announcements
            eventManager.AddAnnouncement(new Announcement(1, "Rock Fest", "Venue changed to the city park", DateTime.Today, new TimeSpan(18, 0, 0)));
            eventManager.AddAnnouncement(new Announcement(2, "Art Gala", "New art pieces added", DateTime.Today.AddDays(2), new TimeSpan(16, 0, 0)));
        }

        // Method to load events into the list box
        private void LoadEvents()
        {
            lstbLocalEvents.Items.Clear();
            // Iterate through the events sorted by date
            foreach (var date in eventManager.EventsByDate.Keys)
            {
                foreach (var ev in eventManager.EventsByDate[date])
                {
                    // Add event name and date to the list box
                    lstbLocalEvents.Items.Add($"{ev.Name} - {ev.Date.ToShortDateString()}");
                }
            }
        }

        // Method to load announcements into the list box
        private void LoadAnnouncements()
        {
            lstbAnnouncements.Items.Clear();
            var announcements = eventManager.GetAnnouncements();
            if (announcements.Count == 0)
            {
                // If no announcements available, display a message
                lstbAnnouncements.Items.Add("No announcements available.");
            }
            else
            {
                // Iterate through the announcements and add them to the list box
                foreach (var announcement in announcements)
                {
                    lstbAnnouncements.Items.Add(announcement.ToString());
                }
            }
            lstbAnnouncements.Refresh();
        }

        // Method to load recommended events into the list box
        private void LoadRecommendations()
        {
            lstbRecommendations.Items.Clear();
            var recommendations = eventManager.RecommendEvents();
            if (recommendations.Count == 0)
            {
                // If no recommendations available, display a message
                lstbRecommendations.Items.Add("No recommendations available.");
            }
            else
            {
                // Iterate through the recommendations and add them to the list box
                foreach (var rec in recommendations)
                {
                    lstbRecommendations.Items.Add(rec.Name);
                }
            }
        }

        // Event handler for search button click
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string category = txtCategory.Text.Trim();  // Trim any spaces
            DateTime? date = dtpDate.Checked ? dtpDate.Value.Date : (DateTime?)null;

            // Search events based on category and date
            var searchResults = eventManager.SearchEvents(category, date);

            lstbLocalEvents.Items.Clear();
            // Add search results to the list box
            lstbLocalEvents.Items.AddRange(
                searchResults.Select(ev => $"{ev.Name} - {ev.Date.ToShortDateString()}").ToArray()
            );

            if (!string.IsNullOrEmpty(category))
            {
                // Save recent search category
                eventManager.RecentSearches.Push(category);
            }

            // Load recommendations based on recent searches
            LoadRecommendations();
        }

        // Event handler for search filters button click
        private void btnSearchFilters_Click(object sender, EventArgs e)
        {
            // Show search filters
            dtpDate.Visible = true;
            cmbCategories.Visible = true;
        }

        // Event handler for close button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }

    

    

   
}
