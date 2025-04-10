using System;
using System.Collections.Generic;

namespace MunicipalityApp
{
    // Define the ServiceRequest class which implements IComparable interface
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        // Properties of the ServiceRequest class
        public int RequestID { get; set; } // Unique identifier for the service request
        public DateTime Timestamp { get; set; } // Time the request was submitted
        public string Status { get; set; } // Status of the request (e.g., Pending, Completed)
        public string Title { get; set; } // Title or summary of the request
        public int Priority { get; set; } // Priority level (e.g., 1 for High, 2 for Medium, etc.)
        public List<int> Dependencies { get; set; } // List of other request IDs this request depends on

        public ReportedIssue IssueDetails { get; set; } // Detailed issue information (optional)

        // Constructor for initializing a new ServiceRequest instance
        public ServiceRequest(int requestId, DateTime timestamp, string status, string title, int priority, List<int> dependencies = null)
        {
            RequestID = requestId;
            Timestamp = timestamp;
            Status = status;
            Title = title;
            Priority = priority;
            Dependencies = dependencies ?? new List<int>(); // Initialize dependencies if null
        }

        // Override the ToString method to provide a string representation of the ServiceRequest
        public override string ToString()
        {
            return $"RequestID: {RequestID}, Title: {Title}, Status: {Status}, Priority: {Priority}, Timestamp: {Timestamp}";
        }

        // Implement the CompareTo method for comparing ServiceRequest instances based on Priority
        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1; // If the other object is null, this instance is greater
            return this.Priority.CompareTo(other.Priority); // Compare based on Priority
        }
    }
}
