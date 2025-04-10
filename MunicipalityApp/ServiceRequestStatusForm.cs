using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MunicipalityApp
{
    public partial class ServiceRequestStatusForm : Form
    {

        private BinarySearchTree requestTree;
        private AVLTree<ServiceRequest> addedRequestTree = new AVLTree<ServiceRequest>();

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            requestTree= new BinarySearchTree();
            PopulateData();
            LoadPersistedRequests();

            rbDefaultSort.Checked = true; // Default to BST sorting
            rbDefaultSort.CheckedChanged += rbDefaultSort_CheckedChanged;
            rbSortByPriority.CheckedChanged += rbSortByPriority_CheckedChanged;



            DisplayRequests();



        }

        private void PopulateData()
        {
            // Example data with municipality-related issues and randomized IDs
            requestTree.Insert(new ServiceRequest(201, DateTime.Now, "Pending", "Fix Streetlight Outage", 1));
            requestTree.Insert(new ServiceRequest(125, DateTime.Now.AddMinutes(-15), "Completed", "Repair Water Pipeline", 2, new List<int> { 201 }));
            requestTree.Insert(new ServiceRequest(312, DateTime.Now.AddHours(-1), "In Progress", "Replace Damaged Stop Sign", 1));
            requestTree.Insert(new ServiceRequest(184, DateTime.Now.AddDays(-1), "Pending", "Pothole Repair on Main Road", 3));
            requestTree.Insert(new ServiceRequest(291, DateTime.Now.AddMinutes(-30), "Pending", "Clear Flooded Drainage", 2));
            requestTree.Insert(new ServiceRequest(405, DateTime.Now.AddHours(-3), "Completed", "Restore Power in Neighborhood", 4));
            requestTree.Insert(new ServiceRequest(158, DateTime.Now.AddHours(-12), "In Progress", "Inspect Bridge for Damage", 1));
            requestTree.Insert(new ServiceRequest(321, DateTime.Now.AddMinutes(-5), "Pending", "Remove Fallen Tree from Road", 5, new List<int> { 405 }));
            requestTree.Insert(new ServiceRequest(239, DateTime.Now.AddHours(-2), "Pending", "Fix Broken Traffic Light", 3));
            requestTree.Insert(new ServiceRequest(467, DateTime.Now.AddDays(-2), "Completed", "Replace Park Benches", 2));
            requestTree.Insert(new ServiceRequest(503, DateTime.Now.AddHours(-6), "In Progress", "Repair Public Fountain", 1, new List<int> { 239 }));
            requestTree.Insert(new ServiceRequest(142, DateTime.Now.AddDays(-3), "Pending", "Paint Crosswalks", 4));
            requestTree.Insert(new ServiceRequest(378, DateTime.Now.AddMinutes(-45), "Completed", "Install New Street Signs", 1, new List<int> { 184, 142 }));
            requestTree.Insert(new ServiceRequest(294, DateTime.Now.AddHours(-10), "Pending", "Repair Damaged Playground Equipment", 3));
            requestTree.Insert(new ServiceRequest(410, DateTime.Now.AddMinutes(-20), "In Progress", "Inspect Sewer System", 5));
            requestTree.Insert(new ServiceRequest(522, DateTime.Now.AddDays(-1).AddHours(-2), "Pending", "Fix Leaking Hydrant", 2));
            requestTree.Insert(new ServiceRequest(369, DateTime.Now.AddHours(-4), "Completed", "Clean Public Park", 4));
            requestTree.Insert(new ServiceRequest(478, DateTime.Now.AddDays(-4), "Pending", "Install New Garbage Bins", 1));
            requestTree.Insert(new ServiceRequest(196, DateTime.Now.AddMinutes(-10), "In Progress", "Inspect Roadside Guardrails", 3, new List<int> { 321 }));
            requestTree.Insert(new ServiceRequest(315, DateTime.Now.AddDays(-5), "Completed", "Repair Municipal Office Roof", 2));
        }


        private void DisplayRequests()
        {
            listViewRequests.Items.Clear();

            if (rbSortByPriority.Checked)
            {
                DisplayByPriority();
            }
            else if (rbDefaultSort.Checked)
            {
                PopulateListView(requestTree.Root); // Default sorting (BST-based)
            }
        }

        public void AddNewRequest(ServiceRequest newRequest)
        {
            // Insert the new request into the secondary tree
            addedRequestTree.Insert(newRequest);

            // Optionally persist the data to a file or database
            PersistRequest(newRequest);

            Console.WriteLine($"New request added: {newRequest}");
        }

        private void PersistRequest(ServiceRequest request)
        {
            string filePath = "added_requests.txt";
            string serializedRequest = $"{request.RequestID},{request.Timestamp},{request.Status},{request.Title},{request.Priority}";

            // Append the request data to the file
            File.AppendAllText(filePath, serializedRequest + Environment.NewLine);
        }

        private void LoadPersistedRequests()
        {
            string filePath = "added_requests.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    var request = new ServiceRequest(
                        int.Parse(parts[0]),
                        DateTime.Parse(parts[1]),
                        parts[2],
                        parts[3],
                        int.Parse(parts[4])
                    );

                    // Reinsert into the secondary tree
                    addedRequestTree.Insert(request);
                }
            }
        }

        private void PopulateListView(TreeNode node)
        {
            if (node == null) return;

            PopulateListView(node.Left);

            var item = new ListViewItem(node.Data.RequestID.ToString());
            item.SubItems.Add(node.Data.Title); // Title exists in ServiceRequest now
            item.SubItems.Add(node.Data.Status);
            item.SubItems.Add(node.Data.Priority.ToString());
            item.SubItems.Add(node.Data.Timestamp.ToString());

            listViewRequests.Items.Add(item);

            PopulateListView(node.Right);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrackRequest_Click(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count > 0)
            {
                int selectedId = int.Parse(listViewRequests.SelectedItems[0].Text);
                var request = requestTree.Search(selectedId);

                if (request != null)
                {
                    MessageBox.Show($"Details for Request {request.RequestID}:\n" +
                                    $"- Title: {request.Title}\n" +
                                    $"- Status: {request.Status}\n" +
                                    $"- Priority: {request.Priority}\n" +
                                    $"- Timestamp: {request.Timestamp}\n" +
                                    $"- Dependencies: {string.Join(", ", request.Dependencies)}",
                                    "Request Details");
                }
            }
        }

        private void txtSearchBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e); // Reuse the search logic
                e.Handled = true; // Prevent default behavior
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchBox.Text, out int requestId))
            {
                var request = requestTree.Search(requestId); // Using the BST search method

                if (request != null)
                {
                    MessageBox.Show($"Request Found!\n" +
                                    $"- Request ID: {request.RequestID}\n" +
                                    $"- Title: {request.Title}\n" +
                                    $"- Status: {request.Status}\n" +
                                    $"- Priority: {request.Priority}\n" +
                                    $"- Timestamp: {request.Timestamp}",
                                    "Search Result");
                }
                else
                {
                    MessageBox.Show("No request found with the given ID.", "Search Result");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Request ID.", "Invalid Input");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear the ListView
            listViewRequests.Items.Clear();

            // Repopulate the ListView with updated data from the tree
            PopulateListView(requestTree.Root); // Reuse the existing method

        }

        private void DisplayByPriority()
        {
            PriorityQueue<ServiceRequest> priorityQueue = new PriorityQueue<ServiceRequest>();

            // Populate the priority queue with all requests from the tree
            PopulatePriorityQueue(requestTree.Root, priorityQueue);

            // Display sorted requests in the ListView
            while (priorityQueue.Count > 0)
            {
                var request = priorityQueue.ExtractMin();
                var item = new ListViewItem(request.RequestID.ToString());
                item.SubItems.Add(request.Title);
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Priority.ToString());
                item.SubItems.Add(request.Timestamp.ToString());
                listViewRequests.Items.Add(item);
            }
        }

        private void PopulatePriorityQueue(TreeNode node, PriorityQueue<ServiceRequest> priorityQueue)
        {
            if (node == null) return;

            priorityQueue.Insert(node.Data.Priority, node.Data); // Add request to the heap
            PopulatePriorityQueue(node.Left, priorityQueue);
            PopulatePriorityQueue(node.Right, priorityQueue);
        }

        private void rbDefaultSort_CheckedChanged(object sender, EventArgs e)
        {
            DisplayRequests(); // Refresh the list when default sort is selected
        }

        private void rbSortByPriority_CheckedChanged(object sender, EventArgs e)
        {
            DisplayRequests(); // Refresh the list when sort by priority is selected
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Populate graph with test data
            Graph serviceGraph = new Graph();
            serviceGraph.AddNode(101);
            serviceGraph.AddNode(102);
            serviceGraph.AddEdge(101, 102);

            PopulateChartWithGraph(serviceGraph);
        }


        private void PopulateChartWithGraph(Graph serviceGraph)
        {
            ConfigureChart();

            // Add a series for nodes
            Series nodeSeries = new Series("Nodes")
            {
                ChartType = SeriesChartType.Point,
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle,
                IsVisibleInLegend = false
            };
            chartServiceGraph.Series.Add(nodeSeries);

            // Add a series for edges
            Series edgeSeries = new Series("Edges")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Gray,
                BorderWidth = 2,
                IsVisibleInLegend = false
            };
            chartServiceGraph.Series.Add(edgeSeries);

            // Add nodes and edges from the graph
            int x = 1; // X-coordinate for nodes (increment for spacing)
            foreach (var node in serviceGraph.AdjacencyList.Keys)
            {
                // Add the node
                nodeSeries.Points.AddXY(x, 0); // Use Y=0 for a horizontal layout
                nodeSeries.Points.Last().Label = node.ToString(); // Add label for the node

                // Add edges
                foreach (var neighbor in serviceGraph.AdjacencyList[node])
                {
                    edgeSeries.Points.AddXY(x, 0); // Start of edge
                    edgeSeries.Points.AddXY(x + 1, 0); // End of edge
                    edgeSeries.Points.Add(new DataPoint(double.NaN, double.NaN)); // Disconnect edges
                }

                x++; // Move to the next X position
            }
        }

        private void ConfigureChart()
        {
            // Clear existing series and chart areas
            chartServiceGraph.Series.Clear();
            chartServiceGraph.ChartAreas.Clear();

            // Add a new ChartArea
            ChartArea area = new ChartArea("GraphArea");
            chartServiceGraph.ChartAreas.Add(area);

            // Set up the chart area for better graph display
            area.AxisX.Interval = 1; // Ensures evenly spaced nodes
            area.AxisY.Interval = 1;
            area.AxisX.Enabled = AxisEnabled.False; // Hide X-axis
            area.AxisY.Enabled = AxisEnabled.False; // Hide Y-axis
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Pass the requestTree to the AddServiceRequest form
            var addRequestForm = new AddServiceRequest(requestTree);
            addRequestForm.ShowDialog(); // Open the form as a dialog
            DisplayRequests(); // Refresh the ListView after adding a request
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
