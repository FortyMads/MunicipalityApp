namespace MunicipalityApp
{
    partial class AddServiceRequest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.lblPriority = new System.Windows.Forms.Label();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MunicipalityApp.Properties.Resources.cape_town1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(214, 104);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 33);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(108, 107);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tilte";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(214, 183);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(199, 24);
            this.cmbStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(108, 191);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // nudPriority
            // 
            this.nudPriority.Location = new System.Drawing.Point(214, 248);
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(199, 22);
            this.nudPriority.TabIndex = 5;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(111, 248);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(48, 16);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priority";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(308, 327);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(104, 23);
            this.btnAddRequest.TabIndex = 7;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(653, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 34);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.nudPriority);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddServiceRequest";
            this.Text = "AddServiceRequest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown nudPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnBack;
    }
}