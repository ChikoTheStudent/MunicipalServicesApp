namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAttachmentPath;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.Button btnViewAllReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAttachmentPath = new System.Windows.Forms.Label();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.btnViewAllReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report an Issue Form";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLocation.Location = new System.Drawing.Point(50, 70);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(300, 30);
            this.txtLocation.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(50, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(300, 31);
            this.cmbCategory.TabIndex = 2;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbDescription.Location = new System.Drawing.Point(50, 170);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(300, 100);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "Describe the issue...";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.BackColor = System.Drawing.Color.White;
            this.btnAttachFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAttachFile.Location = new System.Drawing.Point(50, 290);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(150, 40);
            this.btnAttachFile.TabIndex = 4;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = false;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(50, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAttachmentPath
            // 
            this.lblAttachmentPath.AutoSize = true;
            this.lblAttachmentPath.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAttachmentPath.Location = new System.Drawing.Point(210, 300);
            this.lblAttachmentPath.Name = "lblAttachmentPath";
            this.lblAttachmentPath.Size = new System.Drawing.Size(127, 19);
            this.lblAttachmentPath.TabIndex = 6;
            this.lblAttachmentPath.Text = "No file attached.";
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngagement.ForeColor = System.Drawing.Color.White;
            this.lblEngagement.Location = new System.Drawing.Point(46, 423);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(176, 23);
            this.lblEngagement.TabIndex = 7;
            this.lblEngagement.Text = "You\'re doing great!";
            // 
            // btnViewAllReports
            // 
            this.btnViewAllReports.BackColor = System.Drawing.Color.Snow;
            this.btnViewAllReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAllReports.Location = new System.Drawing.Point(248, 350);
            this.btnViewAllReports.Name = "btnViewAllReports";
            this.btnViewAllReports.Size = new System.Drawing.Size(150, 40);
            this.btnViewAllReports.TabIndex = 8;
            this.btnViewAllReports.Text = "View All Reports";
            this.btnViewAllReports.UseVisualStyleBackColor = false;
            this.btnViewAllReports.Click += new System.EventHandler(this.btnViewAllReports_Click);
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(441, 494);
            this.Controls.Add(this.lblAttachmentPath);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.btnViewAllReports);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
