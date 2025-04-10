using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class Feedback
    {
        // Property to store a list of feedback messages
        public List<string> FeedbackList { get; set; }

        // Property to store a single feedback message
        public string Message { get; set; }

        // Constructor to initialize the FeedbackList property
        public Feedback()
        {
            FeedbackList = new List<string>();
        }
    }
}
