namespace MunicipalServicesApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.ListBox lstUpcomingEvents;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.Label lblUpcomingEvents;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.lstUpcomingEvents = new System.Windows.Forms.ListBox(); 
            this.lblResults = new System.Windows.Forms.Label();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label(); 
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(255, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Events Page";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(25, 386);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 19);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(25, 426);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(125, 386);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(150, 22);
            this.txtCategory.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 426);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 22);
            this.txtDate.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(125, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(25, 97);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(334, 212);
            this.lstEvents.TabIndex = 8;
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 16;
            this.lstRecommendations.Location = new System.Drawing.Point(404, 373);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(427, 116);
            this.lstRecommendations.TabIndex = 10;
            this.lstRecommendations.SelectedIndexChanged += new System.EventHandler(this.lstRecommendations_SelectedIndexChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(25, 67);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(134, 19);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "Search Results:";
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecommendations.Location = new System.Drawing.Point(404, 343);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(160, 19);
            this.lblRecommendations.TabIndex = 11;
            this.lblRecommendations.Text = "Recommendations:";
            // 
            // lstUpcomingEvents // Update the list box name here
            // 
            this.lstUpcomingEvents.FormattingEnabled = true;
            this.lstUpcomingEvents.ItemHeight = 16;
            this.lstUpcomingEvents.Location = new System.Drawing.Point(404, 97);
            this.lstUpcomingEvents.Name = "lstUpcomingEvents";
            this.lstUpcomingEvents.Size = new System.Drawing.Size(427, 212);
            this.lstUpcomingEvents.TabIndex = 2;
            this.lstUpcomingEvents.SelectedIndexChanged += new System.EventHandler(this.lstUpcomingEvents_SelectedIndexChanged);

            // 
            // lblUpcomingEvents // Update the label name here
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(404, 67);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(156, 19);
            this.lblUpcomingEvents.TabIndex = 1;
            this.lblUpcomingEvents.Text = "Upcoming Events:";
            // 
            // LocalEventsForm
            // 
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 558);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.lstRecommendations);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lstUpcomingEvents);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Controls.Add(this.lblTitle);
            this.Name = "LocalEventsForm";
            this.Text = "Local Events";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
