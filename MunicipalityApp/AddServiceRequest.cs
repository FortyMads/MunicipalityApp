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
    public partial class AddServiceRequest : Form
    {
        // Private field to hold the BinarySearchTree instance
        private BinarySearchTree requestTree;

        // Constructor to initialize the form and the BinarySearchTree instance
        public AddServiceRequest(BinarySearchTree tree)
        {
            InitializeComponent();
            requestTree = tree ?? throw new ArgumentNullException(nameof(tree), "BinarySearchTree cannot be null.");
        }

        // Event handler for the Add Request button click event
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                string title = txtTitle.Text;
                string status = cmbStatus.SelectedItem?.ToString() ?? "Pending";
                int priority = (int)nudPriority.Value;
                DateTime timestamp = DateTime.Now;

                // Generate a unique RequestID
                int newRequestId = GenerateUniqueRequestId();

                // Create the new service request
                ServiceRequest newRequest = new ServiceRequest(
                    requestId: newRequestId,
                    timestamp: timestamp,
                    status: status,
                    title: title,
                    priority: priority
                );

                // Insert the new request into the BinarySearchTree
                requestTree.Insert(newRequest);

                // Clear input fields after successful addition
                txtTitle.Clear();
                cmbStatus.SelectedIndex = -1;
                nudPriority.Value = 1;

                // Show success message
                MessageBox.Show($"Service Request {newRequestId} successfully added.", "Success");
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        // Method to generate a unique RequestID
        public int GenerateUniqueRequestId()
        {
            Random random = new Random();
            int newId;

            // Loop until a unique ID is generated
            do
            {
                newId = random.Next(100, 1000); // Generates a random number between 100 and 999
            } while (requestTree.Search(newId) != null); // Ensure the ID is unique

            return newId;
        }

        // Event handler for the Back button click event
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
    }

