using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MunicipalServicesApp.Data;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Forms
{
    public partial  class ReportIssueForm : Form
    {
        private Label lblTitle;
        private Label lblInstructions;

        private Label lblLocation;
        private TextBox txtLocation;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblDescription;
        private RichTextBox txtDescription;

        private Label lblAttachment;
        private TextBox txtAttachment;
        private Button btnAttach;

        private Label lblProgress;
        private ProgressBar progressBar;

        private Label lblEngagement;

        private Button btnSubmit;
        private Button btnBack;

        public ReportIssueForm()
        {
            InitializeForm();
            CreateControls();
        }

        private void InitializeForm()
        {
            Text = "Report an Issue";

            StartPosition =
                FormStartPosition.CenterScreen;

            Size = new Size(750, 700);

            MinimumSize =
                new Size(700, 650);

            BackColor = Color.White;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;
        }

        private void CreateControls()
        {
            // =========================
            // TITLE
            // =========================

            lblTitle = new Label();

            lblTitle.Text =
                "Report a Municipal Issue";

            lblTitle.Font =
                new Font(
                    "Arial",
                    22,
                    FontStyle.Bold);

            lblTitle.AutoSize = true;

            lblTitle.Location =
                new Point(220, 25);

            Controls.Add(lblTitle);


            // =========================
            // INSTRUCTIONS
            // =========================

            lblInstructions = new Label();

            lblInstructions.Text =
                "Please provide the details below so that your municipality can assist you.";

            lblInstructions.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Regular);

            lblInstructions.AutoSize = true;

            lblInstructions.Location =
                new Point(130, 70);

            Controls.Add(lblInstructions);


            // =========================
            // LOCATION
            // =========================

            lblLocation = new Label();

            lblLocation.Text =
                "Location:";

            lblLocation.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            lblLocation.AutoSize = true;

            lblLocation.Location =
                new Point(60, 120);

            Controls.Add(lblLocation);


            txtLocation = new TextBox();

            txtLocation.Name =
                "txtLocation";

            txtLocation.Size =
                new Size(600, 30);

            txtLocation.Location =
                new Point(60, 145);

            txtLocation.Font =
                new Font(
                    "Arial",
                    10);

            txtLocation.TextChanged +=
                Input_TextChanged;

            Controls.Add(txtLocation);


            // =========================
            // CATEGORY
            // =========================

            lblCategory = new Label();

            lblCategory.Text =
                "Issue Category:";

            lblCategory.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            lblCategory.AutoSize = true;

            lblCategory.Location =
                new Point(60, 190);

            Controls.Add(lblCategory);


            cmbCategory = new ComboBox();

            cmbCategory.Name =
                "cmbCategory";

            cmbCategory.Size =
                new Size(600, 30);

            cmbCategory.Location =
                new Point(60, 215);

            cmbCategory.Font =
                new Font(
                    "Arial",
                    10);

            cmbCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbCategory.Items.Add(
                "Roads");

            cmbCategory.Items.Add(
                "Water and Utilities");

            cmbCategory.Items.Add(
                "Electricity");

            cmbCategory.Items.Add(
                "Sanitation");

            cmbCategory.Items.Add(
                "Waste Management");

            cmbCategory.Items.Add(
                "Street Lighting");

            cmbCategory.Items.Add(
                "Public Safety");

            cmbCategory.Items.Add(
                "Other");

            cmbCategory.SelectedIndexChanged +=
                Input_TextChanged;

            Controls.Add(cmbCategory);


            // =========================
            // DESCRIPTION
            // =========================

            lblDescription = new Label();

            lblDescription.Text =
                "Description:";

            lblDescription.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            lblDescription.AutoSize = true;

            lblDescription.Location =
                new Point(60, 260);

            Controls.Add(lblDescription);


            txtDescription = new RichTextBox();

            txtDescription.Name =
                "txtDescription";

            txtDescription.Size =
                new Size(600, 120);

            txtDescription.Location =
                new Point(60, 285);

            txtDescription.Font =
                new Font(
                    "Arial",
                    10);

            txtDescription.TextChanged +=
                Input_TextChanged;

            Controls.Add(txtDescription);


            // =========================
            // ATTACHMENT
            // =========================

            lblAttachment = new Label();

            lblAttachment.Text =
                "Image or Document:";

            lblAttachment.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            lblAttachment.AutoSize = true;

            lblAttachment.Location =
                new Point(60, 425);

            Controls.Add(lblAttachment);


            txtAttachment = new TextBox();

            txtAttachment.Name =
                "txtAttachment";

            txtAttachment.Size =
                new Size(450, 30);

            txtAttachment.Location =
                new Point(60, 450);

            txtAttachment.ReadOnly = true;

            txtAttachment.Font =
                new Font(
                    "Arial",
                    9);

            Controls.Add(txtAttachment);


            btnAttach = new Button();

            btnAttach.Text =
                "Choose File";

            btnAttach.Size =
                new Size(130, 30);

            btnAttach.Location =
                new Point(530, 450);

            btnAttach.Click +=
                BtnAttach_Click;

            Controls.Add(btnAttach);


            // =========================
            // PROGRESS
            // =========================

            lblProgress = new Label();

            lblProgress.Text =
                "Report Progress:";

            lblProgress.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            lblProgress.AutoSize = true;

            lblProgress.Location =
                new Point(60, 495);

            Controls.Add(lblProgress);


            progressBar = new ProgressBar();

            progressBar.Name =
                "progressBar";

            progressBar.Minimum = 0;

            progressBar.Maximum = 100;

            progressBar.Value = 0;

            progressBar.Size =
                new Size(600, 25);

            progressBar.Location =
                new Point(60, 520);

            Controls.Add(progressBar);


            // =========================
            // ENGAGEMENT MESSAGE
            // =========================

            lblEngagement = new Label();

            lblEngagement.Text =
                "Every report helps improve your community.";

            lblEngagement.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Italic);

            lblEngagement.AutoSize = true;

            lblEngagement.Location =
                new Point(60, 555);

            Controls.Add(lblEngagement);


            // =========================
            // SUBMIT
            // =========================

            btnSubmit = new Button();

            btnSubmit.Text =
                "Submit Report";

            btnSubmit.Font =
                new Font(
                    "Arial",
                    11,
                    FontStyle.Bold);

            btnSubmit.Size =
                new Size(200, 45);

            btnSubmit.Location =
                new Point(170, 590);

            btnSubmit.BackColor =
                Color.FromArgb(
                    46,
                    125,
                    50);

            btnSubmit.ForeColor =
                Color.White;

            btnSubmit.FlatStyle =
                FlatStyle.Flat;

            btnSubmit.Cursor =
                Cursors.Hand;

            btnSubmit.Click +=
                BtnSubmit_Click;

            Controls.Add(btnSubmit);


            // =========================
            // BACK BUTTON
            // =========================

            btnBack = new Button();

            btnBack.Text =
                "Back to Main Menu";

            btnBack.Font =
                new Font(
                    "Arial",
                    10,
                    FontStyle.Bold);

            btnBack.Size =
                new Size(200, 45);

            btnBack.Location =
                new Point(380, 590);

            btnBack.Click +=
                BtnBack_Click;

            Controls.Add(btnBack);
        }


        // ==========================================
        // ATTACH FILE
        // ==========================================

        private void BtnAttach_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog =
                   new OpenFileDialog())
            {
                dialog.Title =
                    "Select an Image or Document";

                dialog.Filter =
                    "Images (*.jpg;*.jpeg;*.png;*.gif)|" +
                    "*.jpg;*.jpeg;*.png;*.gif|" +
                    "Documents (*.pdf;*.doc;*.docx;*.txt)|" +
                    "*.pdf;*.doc;*.docx;*.txt|" +
                    "All Files (*.*)|*.*";

                dialog.Multiselect = false;

                if (dialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    txtAttachment.Text =
                        dialog.FileName;

                    UpdateProgress();

                    lblEngagement.Text =
                        "Great! Your supporting file has been added.";
                }
            }
        }


        // ==========================================
        // INPUT CHANGE
        // ==========================================

        private void Input_TextChanged(
            object sender,
            EventArgs e)
        {
            UpdateProgress();
        }


        // ==========================================
        // UPDATE PROGRESS
        // ==========================================

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(
                txtLocation.Text))
            {
                progress += 25;
            }

            if (cmbCategory.SelectedIndex >= 0)
            {
                progress += 25;
            }

            if (!string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                progress += 25;
            }

            if (!string.IsNullOrWhiteSpace(
                txtAttachment.Text))
            {
                progress += 25;
            }

            progressBar.Value = progress;


            if (progress == 0)
            {
                lblEngagement.Text =
                    "Every report helps improve your community.";
            }
            else if (progress <= 25)
            {
                lblEngagement.Text =
                    "Great start! Keep going.";
            }
            else if (progress <= 50)
            {
                lblEngagement.Text =
                    "You're halfway there!";
            }
            else if (progress <= 75)
            {
                lblEngagement.Text =
                    "Almost done! Your report is taking shape.";
            }
            else
            {
                lblEngagement.Text =
                    "Excellent! Your report is ready to submit.";
            }
        }


        // ==========================================
        // SUBMIT REPORT
        // ==========================================

        private void BtnSubmit_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();

                return;
            }


            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();

                return;
            }


            if (string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDescription.Focus();

                return;
            }


            // Generate reference number
            string referenceNumber =
                GenerateReferenceNumber();


            // Create Issue object
            Issue newIssue =
                new Issue();

            newIssue.ReferenceNumber =
                referenceNumber;

            newIssue.Location =
                txtLocation.Text.Trim();

            newIssue.Category =
                cmbCategory.SelectedItem.ToString();

            newIssue.Description =
                txtDescription.Text.Trim();

            newIssue.AttachmentPath =
                txtAttachment.Text.Trim();

            newIssue.DateReported =
                DateTime.Now;


            // Store issue
            IssueRepository.AddIssue(
                newIssue);


            // Display success message
            string attachmentMessage;

            if (string.IsNullOrWhiteSpace(
                newIssue.AttachmentPath))
            {
                attachmentMessage =
                    "No attachment was included.";
            }
            else
            {
                attachmentMessage =
                    "Attachment included successfully.";
            }


            MessageBox.Show(
                "Your issue has been successfully submitted!" +
                Environment.NewLine +
                Environment.NewLine +
                "Reference Number: " +
                referenceNumber +
                Environment.NewLine +
                Environment.NewLine +
                attachmentMessage +
                Environment.NewLine +
                Environment.NewLine +
                "Thank you for helping improve your community.",
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            ClearForm();
        }


        // ==========================================
        // GENERATE REFERENCE NUMBER
        // ==========================================

        private string GenerateReferenceNumber()
        {
            return "MUN-" +
                   DateTime.Now.ToString(
                       "yyyyMMddHHmmss");
        }


        // ==========================================
        // CLEAR FORM
        // ==========================================

        private void ClearForm()
        {
            txtLocation.Clear();

            cmbCategory.SelectedIndex = -1;

            txtDescription.Clear();

            txtAttachment.Clear();

            progressBar.Value = 0;

            lblEngagement.Text =
                "Every report helps improve your community.";

            txtLocation.Focus();
        }


        // ==========================================
        // BACK TO MAIN MENU
        // ==========================================

        private void BtnBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}