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
    public partial class FeedbackForm : Form
    {
        //
        // Constructor
        //
        // Initializes a new instance of the FeedbackForm class.
        // Takes a Form1 object as a parameter to establish a relationship with the main form.
        //
        public FeedbackForm(Form1 form1)
        {
            InitializeComponent();
        }

        //
        // Method to handle the feedback submission
        //
        // This method is triggered when the user clicks the "Submit Feedback" button.
        // It validates the feedback input, adds it to the feedback list, and displays a confirmation message.
        //
        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // Check if the feedback text is empty or whitespace
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                // Show an error message if the feedback is not provided
                MessageBox.Show("Please provide your feedback.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Feedback object
            Feedback feedback = new Feedback();
            // Set the feedback message
            feedback.Message = txtFeedback.Text;
            // Add the feedback message to the feedback list
            feedback.FeedbackList.Add(feedback.Message);

            // Show a confirmation message
            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the FeedbackForm
            this.Close();
        }
    }
    //
    //............................................<<< End Of Class >>>............................................................//
    //
}
