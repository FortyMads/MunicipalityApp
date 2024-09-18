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
        public string AttachedFilePath { get; set; }

        // Constructor for creating a new reported issue
        public ReportedIssue(string location, string category, string description, string attachedFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedFilePath = attachedFilePath;
        }

        // Returns a string representation of the reported issue
        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, AttachedFilePath: {AttachedFilePath}";
        }
    }

    //
    //............................................<<< End Of Class >>>............................................................//
    //
}

