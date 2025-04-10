using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace MunicipalityApp
{
    // Define the Event class to represent an event in the municipality application
    public class Event
    {
        // Properties of the Event class
        public int Id { get; } // Unique identifier for the event
        public string Name { get; } // Name of the event
        public string Description { get; } // Description of the event
        public string Category { get; } // Category of the event
        public DateTime Date { get; } // Date of the event
        public TimeSpan Time { get; } // Time of the event

        // Constructor to initialize an Event object with specified values
        public Event(int id, string name, string description, string category, DateTime date, TimeSpan time)
        {
            Id = id; // Set the event ID
            Name = name; // Set the event name
            Description = description; // Set the event description
            Category = category; // Set the event category
            Date = date; // Set the event date
            Time = time; // Set the event time
        }
    }

}
