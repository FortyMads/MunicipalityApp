using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using AxWMPLib;


namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        // List to store reported issues
        private List<ReportedIssue> reportedIssues = new List<ReportedIssue>();

        // List to store attached media (file name + content)
        private List<MediaFile> attachedMedia = new List<MediaFile>();

        private Timer _typingTimer;

        private const string LocationPlaceholder = "Enter the location of the issue";
        private const string DescriptionPlaceholder = "Enter a description of the issue";
        private Form1 mainForm;

        public ReportIssuesForm(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;

            SetPlaceholderText(txtLocation, LocationPlaceholder);
            SetPlaceholderText(rtbDescription, DescriptionPlaceholder);

            cmbCategory.Items.Insert(0, "Please Select One");
            cmbCategory.SelectedIndex = 0;

            txtLocation.Enter += (s, e) => ClearPlaceholderText(txtLocation, LocationPlaceholder);
            txtLocation.Leave += (s, e) => SetPlaceholderText(txtLocation, LocationPlaceholder);
            rtbDescription.Enter += (s, e) => ClearPlaceholderText(rtbDescription, DescriptionPlaceholder);
            rtbDescription.Leave += (s, e) => SetPlaceholderText(rtbDescription, DescriptionPlaceholder);

            txtLocation.TextChanged += TxtLocation_TextChanged;
            cmbCategory.SelectedIndexChanged += CmbCategory_SelectedIndexChanged;
            rtbDescription.TextChanged += RtbDescription_TextChanged;
            listBoxSuggestions.SelectedIndexChanged += listBoxSuggestions_SelectedIndexChanged;
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter =
                        "All Files|*.png;*.jpg;*.jpeg;*.pdf;*.doc;*.docx;*.mp4;*.avi;*.mov|" +
                        "Image Files|*.png;*.jpg;*.jpeg|" +
                        "Video Files|*.mp4;*.avi;*.mov|" +
                        "Document Files|*.pdf;*.doc;*.docx";
                    openFileDialog.Multiselect = true;  // Enable multiple selection

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var filePath in openFileDialog.FileNames)
                        {
                            // Read the content of each file into a byte array
                            byte[] fileContent = File.ReadAllBytes(filePath);
                            string fileName = Path.GetFileName(filePath);

                            // Store the media file in the attached media list
                            attachedMedia.Add(new MediaFile(fileName, fileContent));
                        }

                        MessageBox.Show($"Attached {openFileDialog.FileNames.Length} file(s).");
                        lblEngagementMessage.Text = "Great! Now click Submit to report the issue.";
                        UpdateProgressBar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attaching media: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                var newIssue = new ReportedIssue(
                    txtLocation.Text,
                    cmbCategory.SelectedItem.ToString(),
                    rtbDescription.Text,
                    new List<MediaFile>(attachedMedia)  // Copy the media list
                );

                reportedIssues.Add(newIssue);
                MessageBox.Show("Issue submitted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the issue: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = 0;
            rtbDescription.Clear();
            attachedMedia.Clear();  // Clear attached media
            progressBarReport.Value = 0;
            lblEngagementMessage.Text = "Start by filling in the location.";

            SetPlaceholderText(txtLocation, LocationPlaceholder);
            SetPlaceholderText(rtbDescription, DescriptionPlaceholder);
        }

        private void UpdateProgressBar()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text) &&
                txtLocation.Text != LocationPlaceholder) progress++;

            if (cmbCategory.SelectedIndex != 0) progress++;

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) &&
                rtbDescription.Text != DescriptionPlaceholder) progress++;

            if (attachedMedia.Count > 0) progress++;

            progressBarReport.Value = progress;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                txtLocation.Text == LocationPlaceholder)
            {
                DisplayErrorMessage("Please enter the location of the issue.");
                return false;
            }

            if (cmbCategory.SelectedIndex == 0)
            {
                DisplayErrorMessage("Please select a category.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text) ||
                rtbDescription.Text == DescriptionPlaceholder)
            {
                DisplayErrorMessage("Please provide a description.");
                return false;
            }

            return true;
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            // Dispose of the previous timer if it exists
            if (_typingTimer != null)
            {
                _typingTimer.Stop();
                _typingTimer.Dispose();
            }

            // Create a new timer with a delay of 500ms
            _typingTimer = new Timer();
            _typingTimer.Interval = 500;
            _typingTimer.Tick += (s, args) =>
            {
                // Call the API with the current text
                if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    GetLocationFromAPI(txtLocation.Text);
                    listBoxSuggestions.Visible = true; // Show the listBoxSuggestions
                }
                else
                {
                    listBoxSuggestions.Visible = false; // Hide the listBoxSuggestions
                }
                _typingTimer.Stop();
            };
            _typingTimer.Start();
            UpdateProgressBar();
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != 0)
            {
                lblEngagementMessage.Text = "Nice choice! Describe the issue.";
                UpdateProgressBar();
            }
        }

        private void RtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                lblEngagementMessage.Text = "Almost done! Attach any media if needed.";
                UpdateProgressBar();
            }
        }


        private async void GetLocationFromAPI(string location)
        {
            // Set up the API endpoint URL
            string apiKey = "AIzaSyCynzr3DvnVLdC58BWeJudGWDa-dMbslBo";
            string url = $"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={location}&key={apiKey}";

            // Send a GET request to the API endpoint
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                // Check if the response was successful
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response JSON
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic jsonData = JsonConvert.DeserializeObject(responseBody);

                    // Clear the ListBox before adding new predictions
                    listBoxSuggestions.Items.Clear();

                    // Process the API response
                    foreach (var prediction in jsonData.predictions)
                    {
                        // Add the prediction to the ListBox
                        listBoxSuggestions.Items.Add(prediction.description);
                    }
                }
                else
                {
                    // Handle API errors
                    MessageBox.Show("Error calling API: " + response.StatusCode);
                }
            }
        }



        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            // Implement the logic to go back to the home screen
        }

        private void SetPlaceholderText(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray; // Change color to indicate placeholder
                }
            }
            else if (control is RichTextBox richTextBox)
            {
                if (string.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    richTextBox.Text = placeholderText;
                    richTextBox.ForeColor = Color.Gray; // Change color to indicate placeholder
                }
            }
        }

        private void ClearPlaceholderText(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = string.Empty; // Clear the placeholder
                    textBox.ForeColor = Color.Black; // Reset color
                }
            }
            else if (control is RichTextBox richTextBox)
            {
                if (richTextBox.Text == placeholderText)
                {
                    richTextBox.Text = string.Empty; // Clear the placeholder
                    richTextBox.ForeColor = Color.Black; // Reset color
                }
            }
        }


        private void listBoxSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBoxSuggestions.SelectedItem != null)
            {
                // Set the text of txtLocation to the selected item's text
                txtLocation.Text = listBoxSuggestions.SelectedItem.ToString();

                // Optionally, clear the suggestions after selection
                listBoxSuggestions.Items.Clear();
            }
        }

        private void btnPreviewMedia_Click(object sender, EventArgs e)
        {
            // Check if there is attached media
            if (attachedMedia.Count > 0)
            {
                // Get the first attached media file
                MediaFile mediaFile = attachedMedia[0];

                // Check the file extension to determine how to preview the media
                string fileExtension = Path.GetExtension(mediaFile.FileName);

                // Preview image files
                if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".png")
                {
                    // Create a new PictureBox to display the image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromStream(new MemoryStream(mediaFile.Content));

                    // Create a new Form to display the PictureBox
                    Form previewForm = new Form();
                    previewForm.Text = "Media Preview";
                    previewForm.Controls.Add(pictureBox);
                    pictureBox.Dock = DockStyle.Fill;

                    // Show the preview form
                    previewForm.ShowDialog();
                }
                // Preview video files
                else if (fileExtension.ToLower() == ".mp4" || fileExtension.ToLower() == ".avi" || fileExtension.ToLower() == ".mov")
                {
                    // Create a new AxWindowsMediaPlayer to play the video
                    AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWindowsMediaPlayer();
                    axWindowsMediaPlayer.CreateControl();
                    axWindowsMediaPlayer.URL = Path.GetTempFileName() + fileExtension;
                    File.WriteAllBytes(axWindowsMediaPlayer.URL, mediaFile.Content);

                    // Create a new Form to display the AxWindowsMediaPlayer
                    Form previewForm = new Form();
                    previewForm.Text = "Media Preview";
                    previewForm.Controls.Add(axWindowsMediaPlayer);
                    axWindowsMediaPlayer.Dock = DockStyle.Fill;

                    // Show the preview form
                    previewForm.ShowDialog();
                }
                // Preview document files
                else if (fileExtension.ToLower() == ".pdf" || fileExtension.ToLower() == ".doc" || fileExtension.ToLower() == ".docx")
                {
                    // Create a new WebBrowser to display the document
                    WebBrowser webBrowser = new WebBrowser();
                    webBrowser.Navigate(Path.GetTempFileName() + fileExtension);
                    File.WriteAllBytes(webBrowser.Url.ToString(), mediaFile.Content);

                    // Create a new Form to display the WebBrowser
                    Form previewForm = new Form();
                    previewForm.Text = "Media Preview";
                    previewForm.Controls.Add(webBrowser);
                    webBrowser.Dock = DockStyle.Fill;

                    // Show the preview form
                    previewForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No media attached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            this.Close();
            LocalEvents localEvents = new LocalEvents();

            localEvents.Show();
        }
    }
}
