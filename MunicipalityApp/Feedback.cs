using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class Feedback
    {


        public List<string> FeedbackList { get; set; }
        public string Message { get; set; }

        public Feedback()
        {
            FeedbackList = new List<string>();
            
        }
    }
}
