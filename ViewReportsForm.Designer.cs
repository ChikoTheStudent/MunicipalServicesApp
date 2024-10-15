namespace MunicipalServicesApp
{
    partial class ViewReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewReports;

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
            this.listViewReports = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewReports
            // 
            this.listViewReports.FullRowSelect = true;
            this.listViewReports.GridLines = true;
            this.listViewReports.HideSelection = false;
            this.listViewReports.Location = new System.Drawing.Point(12, 12);
            this.listViewReports.Name = "listViewReports";
            this.listViewReports.Size = new System.Drawing.Size(776, 426);
            this.listViewReports.TabIndex = 0;
            this.listViewReports.UseCompatibleStateImageBehavior = false;
            this.listViewReports.View = System.Windows.Forms.View.Details;
            // 
            // ViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewReports);
            this.Name = "ViewReportsForm";
            this.Text = "View All Reports";
            this.Load += new System.EventHandler(this.ViewReportsForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
