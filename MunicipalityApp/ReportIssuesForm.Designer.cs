using System.Drawing;

namespace MunicipalityApp
{
    partial class ReportIssuesForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarReport = new System.Windows.Forms.ProgressBar();
            this.lblEngagementMessage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(451, 99);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(167, 27);
            this.txtLocation.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "sanitation",
            "roads",
            "utilities",
            "other"});
            this.cmbCategory.Location = new System.Drawing.Point(451, 148);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(167, 24);
            this.cmbCategory.TabIndex = 3;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescription.ForeColor = System.Drawing.Color.Black;
            this.rtbDescription.Location = new System.Drawing.Point(451, 188);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(167, 96);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachMedia.Location = new System.Drawing.Point(451, 325);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(167, 23);
            this.btnAttachMedia.TabIndex = 5;
            this.btnAttachMedia.Text = "Attach Media Files";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(628, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.Location = new System.Drawing.Point(3, 116);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(138, 47);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "Local Events & Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceRequestStatus.Enabled = false;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(3, 187);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(138, 47);
            this.btnServiceRequestStatus.TabIndex = 3;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnBackToHome);
            this.panel1.Controls.Add(this.btnServiceRequestStatus);
            this.panel1.Controls.Add(this.btnLocalEvents);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 451);
            this.panel1.TabIndex = 1;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToHome.Location = new System.Drawing.Point(3, 396);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(138, 31);
            this.btnBackToHome.TabIndex = 4;
            this.btnBackToHome.Text = "Back to Main";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MunicipalityApp.Properties.Resources.Screenshot_2024_09_12_090940;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(292, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "PLEASE FILL OUT THE FOLLOWING ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(292, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(292, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // progressBarReport
            // 
            this.progressBarReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarReport.Location = new System.Drawing.Point(154, 415);
            this.progressBarReport.Maximum = 4;
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(634, 23);
            this.progressBarReport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarReport.TabIndex = 11;
            // 
            // lblEngagementMessage
            // 
            this.lblEngagementMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEngagementMessage.AutoSize = true;
            this.lblEngagementMessage.Location = new System.Drawing.Point(154, 392);
            this.lblEngagementMessage.Name = "lblEngagementMessage";
            this.lblEngagementMessage.Size = new System.Drawing.Size(62, 16);
            this.lblEngagementMessage.TabIndex = 12;
            this.lblEngagementMessage.Text = "Progress";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MunicipalityApp.Properties.Resources.cape_town1;
            this.pictureBox2.Location = new System.Drawing.Point(151, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(654, 447);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEngagementMessage);
            this.Controls.Add(this.progressBarReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarReport;
        private System.Windows.Forms.Label lblEngagementMessage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}