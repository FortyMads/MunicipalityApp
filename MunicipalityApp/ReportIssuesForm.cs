using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp

{
    //
    //............................................<<< Start Of Class >>>............................................................//
    // Class to represent the form for reporting issues
    //
    public partial class ReportIssuesForm : Form
    {
        // List to store reported issues
        private List<ReportedIssue> reportedIssues = new List<ReportedIssue>();

        // File path of the attached media
        private string attachedFilePath = string.Empty;

        // Placeholder text constants
        private const string LocationPlaceholder = "Enter the location of the issue";
        private const string DescriptionPlaceholder = "Enter a description of the issue";

        // Reference to the main form for easy navigation
        private Form1 mainForm;

        // Constructor
        public ReportIssuesForm(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;

            // Set placeholders for input controls
            SetPlaceholderText(txtLocation, LocationPlaceholder);
            SetPlaceholderText(rtbDescription, DescriptionPlaceholder);

            // Add placeholder to ComboBox (Category)
            cmbCategory.Items.Insert(0, "Please Select One");
            cmbCategory.SelectedIndex = 0;  // Set the placeholder as the default

            // Attach events for handling placeholder text
            txtLocation.Enter += (s, e) => ClearPlaceholderText(txtLocation, LocationPlaceholder);
            txtLocation.Leave += (s, e) => SetPlaceholderText(txtLocation, LocationPlaceholder);
            rtbDescription.Enter += (s, e) => ClearPlaceholderText(rtbDescription, DescriptionPlaceholder);
            rtbDescription.Leave += (s, e) => SetPlaceholderText(rtbDescription, DescriptionPlaceholder);

            // Attach event handlers for updating progress
            txtLocation.TextChanged += TxtLocation_TextChanged;
            cmbCategory.SelectedIndexChanged += CmbCategory_SelectedIndexChanged;
            rtbDescription.TextChanged += RtbDescription_TextChanged;
        }

        //
        // Set placeholder text for a TextBox or RichTextBox
        //
        private void SetPlaceholderText(Control control, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.Text = placeholderText;
                control.ForeColor = Color.Gray; // Set a different color for the placeholder text
            }
        }

        //
        // Clear placeholder text when the user focuses on the control
        //
        private void ClearPlaceholderText(Control control, string placeholderText)
        {
            if (control.Text == placeholderText)
            {
                control.Text = string.Empty;
                control.ForeColor = SystemColors.WindowText; // Reset to default text color
            }
        }

        //
        // Update the ProgressBar and label when location is filled
        //
        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                lblEngagementMessage.Text = "Great! Now select the category.";
                UpdateProgressBar(); // Step 1 complete
            }
        }

        //
        // Update the ProgressBar and label when a category is selected
        //
        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                lblEngagementMessage.Text = "Nice choice! Describe the issue.";
                UpdateProgressBar(); // Step 2 complete
            }
        }


        //
        // Update the ProgressBar and label when description is filled
        //
        private void RtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                lblEngagementMessage.Text = "Almost done! Attach any media if needed.";
                UpdateProgressBar(); // Step 3 complete
            }
        }

        //
        // Update ProgressBar value
        //
        private void UpdateProgressBar()
        {
            int progress = 0;

            // Increment progress only if the real input is present (not placeholders)
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text != LocationPlaceholder)
            {
                progress += 1;
            }

            if (cmbCategory.SelectedItem != null && cmbCategory.SelectedIndex != 0)
            {
                progress += 1;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text != DescriptionPlaceholder)
            {
                progress += 1;
            }

            if (!string.IsNullOrEmpty(attachedFilePath))
            {
                progress += 1;
            }

            // Set the progress bar value based on the progress
            progressBarReport.Value = progress;
        }


        //
        // Method to attach media
        //
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        attachedFilePath = openFileDialog.FileName;
                        MessageBox.Show("Attached: " + openFileDialog.FileName);
                        lblEngagementMessage.Text = "Great! Now click Submit to report the issue.";
                        UpdateProgressBar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attaching media: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        // Method to submit the issue
        //
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Call the ValidateInputs method
                if (!ValidateInputs())
                {
                    return; // Exit if validation fails
                }

                // Create a new ReportedIssue object
                ReportedIssue newIssue = new ReportedIssue(
                    txtLocation.Text,
                    cmbCategory.SelectedItem.ToString(),
                    rtbDescription.Text,
                    attachedFilePath
                );

                // Save the reported issue to the list
                reportedIssues.Add(newIssue);

                MessageBox.Show("Issue submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after submission
                ClearForm();

                // Reset the progress bar
                progressBarReport.Value = 0;
                lblEngagementMessage.Text = "Start by filling in the location.";

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the issue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        // Method to clear the form
        //
        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = 0;
            rtbDescription.Clear();
            attachedFilePath = string.Empty;
            progressBarReport.Value = 0;
            lblEngagementMessage.Text = "Start by filling in the location.";

            // Reapply placeholder text after clearing
            SetPlaceholderText(txtLocation, LocationPlaceholder);
            SetPlaceholderText(rtbDescription, DescriptionPlaceholder);
        }

        //
        // Button handling for going back to home
        //
        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.Show(); // Show the main form
                this.Hide(); // Hide the report issues form
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while going back to home: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        // Method to validate the input fields
        //
        private bool ValidateInputs()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text== "Enter the location of the issue")
                {
                    DisplayErrorMessage("Please enter the location of the issue.");
                    return false;
                }

                if (cmbCategory.SelectedItem == null || cmbCategory.SelectedIndex == 0)
                {
                    DisplayErrorMessage("Please select a category for the issue.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(rtbDescription.Text) || rtbDescription.Text== "Enter a description of the issue")
                {
                    DisplayErrorMessage("Please provide a description of the issue.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating inputs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //
        // Display error message
        //
        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

 
    }
}
