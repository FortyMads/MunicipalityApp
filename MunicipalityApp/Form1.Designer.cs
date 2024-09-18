namespace MunicipalityApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnFeedback);
            this.panel1.Controls.Add(this.btnServiceRequestStatus);
            this.panel1.Controls.Add(this.btnLocalEvents);
            this.panel1.Controls.Add(this.btnReportIssues);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 451);
            this.panel1.TabIndex = 0;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeedback.Location = new System.Drawing.Point(0, 396);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(149, 42);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Give Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceRequestStatus.Enabled = false;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(0, 251);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(149, 47);
            this.btnServiceRequestStatus.TabIndex = 3;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = true;
            this.btnServiceRequestStatus.Click += new System.EventHandler(this.btnServiceRequestStatus_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.Location = new System.Drawing.Point(0, 174);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(149, 47);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "Local Events & Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportIssues.Location = new System.Drawing.Point(0, 98);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(149, 44);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MunicipalityApp.Properties.Resources.Screenshot_2024_09_12_090940;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(362, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO CAPE TOWN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MunicipalityApp.Properties.Resources.cape_town1;
            this.pictureBox2.Location = new System.Drawing.Point(151, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(648, 448);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(225, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 168);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

