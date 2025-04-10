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

    /// <summary>
    /// Main form class for the MunicipalityApp.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Report Issues" button click event.
        /// Hides the current form and shows the ReportIssuesForm as a dialog.
        /// </summary>
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of the ReportIssuesForm and pass the current form as a parameter
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm(this);

            // Show the ReportIssuesForm as a dialog
            reportIssuesForm.ShowDialog();

            this.Show();
        }

        /// <summary>
        /// Event handler for the "Feedback" button click event.
        /// Hides the current form and shows the FeedbackForm as a dialog.
        /// </summary>
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of the FeedbackForm and pass the current form as a parameter
            FeedbackForm feedbackForm = new FeedbackForm(this);

            // Show the FeedbackForm as a dialog
            feedbackForm.ShowDialog();

            this.Show();
        }

        /// <summary>
        /// Event handler for the "Local Events" button click event.
        /// Hides the current form and shows the LocalEvents form as a dialog.
        /// </summary>
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of the LocalEvents form
            LocalEvents localevents = new LocalEvents();

            // Show the LocalEvents form as a dialog
            localevents.ShowDialog();
        }

        /// <summary>
        /// Event handler for the "Service Request Status" button click event.
        /// Hides the current form and shows the ServiceRequestStatusForm as a dialog.
        /// </summary>
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of the ServiceRequestStatusForm
            ServiceRequestStatusForm serviceRequestStatusForm = new ServiceRequestStatusForm();

            // Show the ServiceRequestStatusForm as a dialog
            serviceRequestStatusForm.ShowDialog();

            this.Show();
        }
    }

    //
    //............................................<<< End Of Class >>>............................................................//
    //
}
