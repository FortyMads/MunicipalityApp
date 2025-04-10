using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace MunicipalityApp
{
    // Represents an announcement in the municipality application
    public class Announcement
    {
        // Properties of the Announcement class
        public int Id { get; } // Unique identifier for the announcement
        public string Name { get; } // Name of the announcement
        public string Description { get; } // Description of the announcement
        public DateTime Date { get; } // Date of the announcement
        public TimeSpan Time { get; } // Time of the announcement

        // Constructor to initialize an Announcement object
        public Announcement(int id, string name, string description, DateTime date, TimeSpan time)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Time = time;
        }

        // Override the ToString method to provide a string representation of the announcement
        public override string ToString()
        {
            return $"{Name} - {Description}";
        }
    }


}
