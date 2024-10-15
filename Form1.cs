using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enabled the "Local Events" button
            btnLocalEvents.Enabled = true;
            btnServiceStatus.Enabled = false;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnServiceStatus, "This feature is coming soon!");
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.ShowDialog();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.ShowDialog();
        }
    }
}