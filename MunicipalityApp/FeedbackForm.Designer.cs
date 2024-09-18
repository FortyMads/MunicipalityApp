namespace MunicipalityApp
{
    partial class FeedbackForm
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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.RichTextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedback.Location = new System.Drawing.Point(136, 37);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(195, 23);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "PLEASE ENTER FEEBACK BELOW ";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeedback.Location = new System.Drawing.Point(84, 83);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(300, 134);
            this.txtFeedback.TabIndex = 1;
            this.txtFeedback.Text = "";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitFeedback.Location = new System.Drawing.Point(332, 255);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(85, 37);
            this.btnSubmitFeedback.TabIndex = 2;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmitFeedback;
    }
}