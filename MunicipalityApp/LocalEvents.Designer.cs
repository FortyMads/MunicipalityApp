using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    partial class LocalEvents
    {
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstbLocalEvents;
        private System.Windows.Forms.ListBox lstbRecommendations;

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

        private void InitializeComponent()
        {
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstbLocalEvents = new System.Windows.Forms.ListBox();
            this.lstbRecommendations = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstbAnnouncements = new System.Windows.Forms.ListBox();
            this.btnSearchFilters = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.Location = new System.Drawing.Point(12, 20);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(626, 22);
            this.txtCategory.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(164, 60);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(179, 22);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(538, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lstbLocalEvents
            // 
            this.lstbLocalEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbLocalEvents.BackColor = System.Drawing.Color.White;
            this.lstbLocalEvents.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbLocalEvents.FormattingEnabled = true;
            this.lstbLocalEvents.ItemHeight = 16;
            this.lstbLocalEvents.Location = new System.Drawing.Point(221, 108);
            this.lstbLocalEvents.Name = "lstbLocalEvents";
            this.lstbLocalEvents.Size = new System.Drawing.Size(567, 132);
            this.lstbLocalEvents.TabIndex = 3;
            this.lstbLocalEvents.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEvents_DrawItem);
            // 
            // lstbRecommendations
            // 
            this.lstbRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbRecommendations.BackColor = System.Drawing.Color.White;
            this.lstbRecommendations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbRecommendations.FormattingEnabled = true;
            this.lstbRecommendations.ItemHeight = 16;
            this.lstbRecommendations.Location = new System.Drawing.Point(221, 268);
            this.lstbRecommendations.Name = "lstbRecommendations";
            this.lstbRecommendations.Size = new System.Drawing.Size(567, 100);
            this.lstbRecommendations.TabIndex = 4;
            this.lstbRecommendations.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstRecommendations_DrawItem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MunicipalityApp.Properties.Resources.cape_town1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lstbAnnouncements
            // 
            this.lstbAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbAnnouncements.BackColor = System.Drawing.Color.White;
            this.lstbAnnouncements.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbAnnouncements.FormattingEnabled = true;
            this.lstbAnnouncements.ItemHeight = 16;
            this.lstbAnnouncements.Location = new System.Drawing.Point(12, 108);
            this.lstbAnnouncements.Name = "lstbAnnouncements";
            this.lstbAnnouncements.Size = new System.Drawing.Size(150, 260);
            this.lstbAnnouncements.TabIndex = 6;
            this.lstbAnnouncements.Visible = false;
            // 
            // btnSearchFilters
            // 
            this.btnSearchFilters.Location = new System.Drawing.Point(12, 59);
            this.btnSearchFilters.Name = "btnSearchFilters";
            this.btnSearchFilters.Size = new System.Drawing.Size(127, 23);
            this.btnSearchFilters.TabIndex = 7;
            this.btnSearchFilters.Text = "Advanced Search";
            this.btnSearchFilters.UseVisualStyleBackColor = true;
            this.btnSearchFilters.Click += new System.EventHandler(this.btnSearchFilters_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "Music Concert",
            "Sports Event",
            "Food Market",
            "Art Exhibition",
            "Community Outreach Programmes",
            "OTHER"});
            this.cmbCategories.Location = new System.Drawing.Point(364, 60);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 24);
            this.cmbCategories.TabIndex = 8;
            this.cmbCategories.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(699, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocalEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnSearchFilters);
            this.Controls.Add(this.lstbAnnouncements);
            this.Controls.Add(this.lstbRecommendations);
            this.Controls.Add(this.lstbLocalEvents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LocalEvents";
            this.Text = "Local Events and Announcements";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;


        private void lstEvents_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;  // Check for invalid index
            e.DrawBackground();
            e.Graphics.DrawString(lstbLocalEvents.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void lstRecommendations_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;  // Avoid errors if list is empty
            e.DrawBackground();
            e.Graphics.DrawString(lstbRecommendations.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }


        private System.Windows.Forms.ListBox lstbAnnouncements;


        private void txtCategory_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Text == "Search")
            {
                txtCategory.Text = "";
                txtCategory.ForeColor = Color.Black;
            }
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                txtCategory.Text = "Search";
                txtCategory.ForeColor = Color.Gray;
            }
        }

        private System.Windows.Forms.Button btnSearchFilters;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button button1;
    }
}