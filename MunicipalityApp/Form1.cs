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

    //
    //............................................<<< Start Of Class >>>............................................................//
    //
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    //
    // Event handler for the "Report Issues" button
    //
    private void btnReportIssues_Click(object sender, EventArgs e)
        {

            this.Hide();

            // Create a new instance of the ReportIssuesForm and pass the current form as a parameter
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm(this);

            
            // Show the ReportIssuesForm as a dialog
            reportIssuesForm.ShowDialog();

            this.Show();
        }

        // Event handler for the "Feedback" button
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create a new instance of the FeedbackForm and pass the current form as a parameter
            FeedbackForm feedbackForm = new FeedbackForm(this);

            // Show the FeedbackForm as a dialog
            feedbackForm.ShowDialog();

            
            this.Show();
        }

        // Event handler for the "Local Events" button
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            // TODO: Implement the functionality for the "Local Events" button
        }

        // Event handler for the "Service Request Status" button
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            // TODO: Implement the functionality for the "Service Request Status" button
        }


    }

    //
    //............................................<<< End Of Class >>>............................................................//
    //
}
