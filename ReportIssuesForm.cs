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
    public partial class ReportIssuesForm : Form
    {
        public static List<Report> reportList = new List<Report>();

        public ReportIssuesForm()
        {
            InitializeComponent();
            InitializePlaceholderText();
        }

        private void InitializePlaceholderText()
        {
            txtLocation.Text = "Enter Location";
            txtLocation.ForeColor = System.Drawing.Color.Gray;
            txtLocation.Enter += RemovePlaceholderText;
            txtLocation.Leave += SetPlaceholderText;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Enter Location")
            {
                txtLocation.Text = "";
                txtLocation.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholderText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.Text = "Enter Location";
                txtLocation.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Event handler for "Attach File" button click
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblAttachmentPath.Text = openFileDialog.FileName;
            }
        }

        // Event handler for "Submit" button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate the fields
            if (string.IsNullOrEmpty(txtLocation.Text) || cmbCategory.SelectedIndex == -1 || string.IsNullOrEmpty(rtbDescription.Text) || txtLocation.Text == "Enter Location")
            {
                MessageBox.Show("Please fill all the fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new report object and add it to the list
            Report newReport = new Report(
                txtLocation.Text,
                cmbCategory.SelectedItem.ToString(),
                rtbDescription.Text,
                lblAttachmentPath.Text
            );
            reportList.Add(newReport);

            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update engagement label
            lblEngagement.Text = "Thank you for your report!";

            this.Close();
        }

        // Event handler for "View All Reports" button click
        private void btnViewAllReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(reportList);
            viewReportsForm.Show();
        }
    }
}
