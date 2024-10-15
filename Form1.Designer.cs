using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MunicipalServicesApp
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 30, 30, 180, 90);
            path.AddArc(this.Width - 30, 0, 30, 30, 270, 90);
            path.AddArc(this.Width - 30, this.Height - 30, 30, 30, 0, 90);
            path.AddArc(0, this.Height - 30, 30, 30, 90, 90);
            this.Region = new Region(path);
            base.OnPaint(pevent);
        }
    }

    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedButton btnReportIssues;
        private RoundedButton btnLocalEvents;
        private RoundedButton btnServiceStatus;
        private System.Windows.Forms.Label lblTitle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnServiceStatus = new MunicipalServicesApp.RoundedButton();
            this.btnLocalEvents = new MunicipalServicesApp.RoundedButton();
            this.btnReportIssues = new MunicipalServicesApp.RoundedButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Honeydew;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(74, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(652, 40);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Welcome to the Municipal Services App";
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.BackColor = System.Drawing.Color.LightGray;
            this.btnServiceStatus.Enabled = false;
            this.btnServiceStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceStatus.Location = new System.Drawing.Point(274, 339);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(250, 60);
            this.btnServiceStatus.TabIndex = 2;
            this.btnServiceStatus.Text = "Service Status (Coming Soon)";
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLocalEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.Location = new System.Drawing.Point(274, 229);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(250, 60);
            this.btnLocalEvents.TabIndex = 1;
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            this.btnLocalEvents.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnLocalEvents.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.Firebrick;
            this.btnReportIssues.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.Snow;
            this.btnReportIssues.Location = new System.Drawing.Point(274, 117);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(250, 60);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            this.btnReportIssues.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnReportIssues.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Name = "Form1";
            this.Text = "Municipal Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button == btnReportIssues)
                {
                    button.BackColor = Color.DarkRed; // Darker shade for hover
                }
                else if (button == btnLocalEvents)
                {
                    button.BackColor = Color.Green; // Darker shade for hover
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button == btnReportIssues)
                {
                    button.BackColor = Color.Firebrick; // Original color
                }
                else if (button == btnLocalEvents)
                {
                    button.BackColor = Color.LimeGreen; // Original color
                }
            }
        }
    }
}
