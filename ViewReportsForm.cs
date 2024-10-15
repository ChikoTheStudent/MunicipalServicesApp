using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ViewReportsForm : Form
    {
        private List<Report> reports;

        public ViewReportsForm(List<Report> reports)
        {
            InitializeComponent();
            this.reports = reports;
        }

        private void ViewReportsForm_Load(object sender, EventArgs e)
        {
            // Set up the ListView columns
            listViewReports.Columns.Add("Location", 150);
            listViewReports.Columns.Add("Category", 100);
            listViewReports.Columns.Add("Description", 300);
            listViewReports.Columns.Add("Attachment", 200);

            // Populate the ListView with report data
            foreach (var report in reports)
            {
                var listItem = new ListViewItem(report.Location);
                listItem.SubItems.Add(report.Category);
                listItem.SubItems.Add(report.Description);
                listItem.SubItems.Add(report.AttachmentPath);

                listViewReports.Items.Add(listItem);
            }
        }
    }
}
