using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp.Forms
{
    public partial class MainMenuForm : Form
    {
        private Label lblTitle;
        private Label lblSubtitle;

        private Button btnReportIssues;
        private Button btnEvents;
        private Button btnServiceStatus;

        private Label lblFooter;

        public MainMenuForm()
        {
            InitializeForm();
            CreateControls();
        }

        private void InitializeForm()
        {
            Text = "Municipal Services Application";

            StartPosition = FormStartPosition.CenterScreen;

            Size = new Size(700, 500);

            MinimumSize = new Size(600, 450);

            BackColor = Color.White;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;
        }

        private void CreateControls()
        {
            // TITLE
            lblTitle = new Label();

            lblTitle.Text = "Municipal Services";

            lblTitle.Font = new Font(
                "Arial",
                24,
                FontStyle.Bold
            );

            lblTitle.AutoSize = true;

            lblTitle.Location = new Point(220, 50);

            Controls.Add(lblTitle);


            // SUBTITLE
            lblSubtitle = new Label();

            lblSubtitle.Text =
                "South African Municipal Services Portal";

            lblSubtitle.Font = new Font(
                "Arial",
                11,
                FontStyle.Regular
            );

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location = new Point(215, 100);

            Controls.Add(lblSubtitle);


            // REPORT ISSUES BUTTON
            btnReportIssues = new Button();

            btnReportIssues.Text = "Report Issues";

            btnReportIssues.Font = new Font(
                "Arial",
                12,
                FontStyle.Bold
            );

            btnReportIssues.Size = new Size(300, 55);

            btnReportIssues.Location = new Point(200, 160);

            btnReportIssues.BackColor =
                Color.FromArgb(46, 125, 50);

            btnReportIssues.ForeColor = Color.White;

            btnReportIssues.FlatStyle =
                FlatStyle.Flat;

            btnReportIssues.Cursor =
                Cursors.Hand;

            btnReportIssues.Click +=
                BtnReportIssues_Click;

            Controls.Add(btnReportIssues);


            // EVENTS BUTTON
            btnEvents = new Button();

            btnEvents.Text =
                "Local Events and Announcements";

            btnEvents.Font = new Font(
                "Arial",
                11,
                FontStyle.Regular
            );

            btnEvents.Size = new Size(300, 55);

            btnEvents.Location = new Point(200, 230);

            btnEvents.Enabled = false;

            Controls.Add(btnEvents);


            // SERVICE STATUS BUTTON
            btnServiceStatus = new Button();

            btnServiceStatus.Text =
                "Service Request Status";

            btnServiceStatus.Font = new Font(
                "Arial",
                11,
                FontStyle.Regular
            );

            btnServiceStatus.Size = new Size(300, 55);

            btnServiceStatus.Location =
                new Point(200, 300);

            btnServiceStatus.Enabled = false;

            Controls.Add(btnServiceStatus);


            // FOOTER
            lblFooter = new Label();

            lblFooter.Text =
                "Please select an available service to continue.";

            lblFooter.Font = new Font(
                "Arial",
                9,
                FontStyle.Italic
            );

            lblFooter.AutoSize = true;

            lblFooter.Location =
                new Point(200, 390);

            Controls.Add(lblFooter);
        }

        private void BtnReportIssues_Click(
            object sender,
            EventArgs e)
        {
            using (ReportIssueForm reportForm =
                   new ReportIssueForm())
            {
                reportForm.ShowDialog();
            }
        }
    }
}