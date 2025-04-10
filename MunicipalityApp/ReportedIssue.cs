using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    //
    //............................................<<< Start Of Class >>>............................................................//
    // Represents a reported issue in the municipality
    //
    public class ReportedIssue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<MediaFile> AttachedMedia { get; }

        // Constructor for creating a new reported issue
        public ReportedIssue(string location, string category, string description, List<MediaFile> attachedMedia)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedMedia = attachedMedia;
        }

        // Returns a string representation of the reported issue
        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, AttachedFiles: {AttachedMedia}";
        }
    }

    //
    //............................................<<< End Of Class >>>............................................................//
    //
}


