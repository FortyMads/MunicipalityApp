namespace MunicipalityApp
{
    partial class ServiceRequestStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewRequests = new System.Windows.Forms.ListView();
            this.Request_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chartServiceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTrackRequest = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rbDefaultSort = new System.Windows.Forms.RadioButton();
            this.rbSortByPriority = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MunicipalityApp.Properties.Resources.cape_town1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listViewRequests
            // 
            this.listViewRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Request_ID,
            this.Title,
            this.Status,
            this.Priority,
            this.Timestamp});
            this.listViewRequests.HideSelection = false;
            this.listViewRequests.Location = new System.Drawing.Point(12, 132);
            this.listViewRequests.Name = "listViewRequests";
            this.listViewRequests.Size = new System.Drawing.Size(430, 306);
            this.listViewRequests.TabIndex = 1;
            this.listViewRequests.UseCompatibleStateImageBehavior = false;
            this.listViewRequests.View = System.Windows.Forms.View.Details;
            // 
            // Request_ID
            // 
            this.Request_ID.Text = "Request ID";
            this.Request_ID.Width = 82;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 92;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 74;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 77;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 96;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(12, 23);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(223, 38);
            this.txtSearchBox.TabIndex = 3;
            this.txtSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chartServiceGraph
            // 
            this.chartServiceGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lineAnnotation1.Name = "datasets";
            this.chartServiceGraph.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.chartServiceGraph.ChartAreas.Add(chartArea1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chartServiceGraph.Legends.Add(legend1);
            this.chartServiceGraph.Location = new System.Drawing.Point(448, 132);
            this.chartServiceGraph.Name = "chartServiceGraph";
            this.chartServiceGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartServiceGraph.Series.Add(series1);
            this.chartServiceGraph.Size = new System.Drawing.Size(340, 189);
            this.chartServiceGraph.TabIndex = 5;
            this.chartServiceGraph.Text = "chartServiceGraph";
            this.chartServiceGraph.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnTrackRequest
            // 
            this.btnTrackRequest.Location = new System.Drawing.Point(543, 38);
            this.btnTrackRequest.Name = "btnTrackRequest";
            this.btnTrackRequest.Size = new System.Drawing.Size(75, 23);
            this.btnTrackRequest.TabIndex = 6;
            this.btnTrackRequest.Text = "Track Request ";
            this.btnTrackRequest.UseVisualStyleBackColor = true;
            this.btnTrackRequest.Click += new System.EventHandler(this.btnTrackRequest_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(713, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Generate Reports";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rbDefaultSort
            // 
            this.rbDefaultSort.AutoSize = true;
            this.rbDefaultSort.BackColor = System.Drawing.Color.Transparent;
            this.rbDefaultSort.Location = new System.Drawing.Point(282, 80);
            this.rbDefaultSort.Name = "rbDefaultSort";
            this.rbDefaultSort.Size = new System.Drawing.Size(95, 20);
            this.rbDefaultSort.TabIndex = 9;
            this.rbDefaultSort.TabStop = true;
            this.rbDefaultSort.Text = "Default sort";
            this.rbDefaultSort.UseVisualStyleBackColor = false;
            this.rbDefaultSort.CheckedChanged += new System.EventHandler(this.rbDefaultSort_CheckedChanged);
            // 
            // rbSortByPriority
            // 
            this.rbSortByPriority.AutoSize = true;
            this.rbSortByPriority.BackColor = System.Drawing.Color.Transparent;
            this.rbSortByPriority.Location = new System.Drawing.Point(282, 106);
            this.rbSortByPriority.Name = "rbSortByPriority";
            this.rbSortByPriority.Size = new System.Drawing.Size(114, 20);
            this.rbSortByPriority.TabIndex = 10;
            this.rbSortByPriority.TabStop = true;
            this.rbSortByPriority.Text = "Sort by Priority";
            this.rbSortByPriority.UseVisualStyleBackColor = false;
            this.rbSortByPriority.CheckedChanged += new System.EventHandler(this.rbSortByPriority_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(713, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbSortByPriority);
            this.Controls.Add(this.rbDefaultSort);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTrackRequest);
            this.Controls.Add(this.chartServiceGraph);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.listViewRequests);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartServiceGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.ColumnHeader Request_ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTrackRequest;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rbDefaultSort;
        private System.Windows.Forms.RadioButton rbSortByPriority;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartServiceGraph;
    }
}