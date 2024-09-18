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
        public FeedbackForm(Form1 form1)
        {
            InitializeComponent();
           
        }

        //
        // method i use to submit feedback
        //
        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please provide your feedback.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Feedback feedback = new Feedback();
            feedback.Message = txtFeedback.Text;
            feedback.FeedbackList.Add(feedback.Message);

            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hide the FeedbackForm
            this.Close();

      
        }
    }
    //
    //............................................<<< End Of Class >>>............................................................//
    //
}
