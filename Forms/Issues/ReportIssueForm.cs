using System;
using System.IO;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Forms.Reports;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    public partial class ReportIssueForm : Form
    {
        private readonly IssueService
            issueService;

        private string selectedFilePath;


        public ReportIssueForm()
        {
            InitializeComponent();

            issueService =
                new IssueService();

            selectedFilePath =
                string.Empty;
        }


        // =====================================================
        // SUBMIT
        // =====================================================

        private void btnSubmit_Click(
            object sender,
            EventArgs e)
        {
            HideErrors();


            if (!ValidateForm())
            {
                return;
            }


            string userEmail =
                string.Empty;


            if (UserSession.IsLoggedIn)
            {
                userEmail =
                    UserSession.CurrentUser.Email;
            }


            IssueReport submittedIssue;

            string message;


            bool success =
                issueService.SubmitIssue(
                    userEmail,
                    txtLocation.Text,
                    cmbCategory.SelectedItem.ToString(),
                    rtbDescription.Text,
                    selectedFilePath,
                    out submittedIssue,
                    out message);


            if (!success)
            {
                ShowFailureDialog(
                    message);

                return;
            }


            ShowSuccessDialog(
                submittedIssue.ReferenceNumber);


            ClearForm();
        }

        // =====================================================
        // MY REPORTS
        // =====================================================

        private void btnMyReports_Click(
            object sender,
            EventArgs e)
        {
            MyReportsForm myReportsForm =
                new MyReportsForm();

            myReportsForm.ShowDialog(this);
        }


        // =====================================================
        // VALIDATION
        // =====================================================

        private bool ValidateForm()
        {
            bool valid =
                true;


            // LOCATION

            if (string.IsNullOrWhiteSpace(
                txtLocation.Text))
            {
                ShowError(
                    lblLocationError,
                    "Please enter the location of the issue.");

                valid =
                    false;
            }


            // CATEGORY

            if (cmbCategory.SelectedIndex <= 0)
            {
                ShowError(
                    lblCategoryError,
                    "Please select an issue category.");

                valid =
                    false;
            }


            // DESCRIPTION

            if (string.IsNullOrWhiteSpace(
                rtbDescription.Text))
            {
                ShowError(
                    lblDescriptionError,
                    "Please describe the issue.");

                valid =
                    false;
            }
            else if (
                rtbDescription.Text.Trim().Length < 10)
            {
                ShowError(
                    lblDescriptionError,
                    "Please provide a little more detail.");

                valid =
                    false;
            }


            return valid;
        }


        // =====================================================
        // CHOOSE FILE
        // =====================================================

        private void btnChooseFile_Click(
            object sender,
            EventArgs e)
        {
            lblAttachmentError.Visible =
                false;


            DialogResult result =
                openFileDialog.ShowDialog();


            if (result != DialogResult.OK)
            {
                return;
            }


            string filePath =
                openFileDialog.FileName;


            // =================================================
            // CHECK EXTENSION
            // =================================================

            string extension =
                Path.GetExtension(
                    filePath)
                .ToLower();


            if (
                extension != ".jpg" &&
                extension != ".jpeg" &&
                extension != ".png" &&
                extension != ".pdf")
            {
                ShowError(
                    lblAttachmentError,
                    "Only JPG, PNG and PDF files are supported.");

                return;
            }


            // =================================================
            // CHECK FILE SIZE
            // =================================================

            FileInfo file =
                new FileInfo(
                    filePath);


            const long maximumSize =
                5 * 1024 * 1024;


            if (file.Length > maximumSize)
            {
                ShowError(
                    lblAttachmentError,
                    "The selected file must be smaller than 5 MB.");

                return;
            }


            selectedFilePath =
                filePath;


            lblSelectedFile.Text =
                file.Name;

            lblSelectedFile.ForeColor =
                System.Drawing.Color.FromArgb(
                    0,
                    59,
                    113);
        }


        // =====================================================
        // DESCRIPTION COUNTER
        // =====================================================

        private void rtbDescription_TextChanged(
            object sender,
            EventArgs e)
        {
            lblCharacterCount.Text =
                rtbDescription.Text.Length +
                " / 1000";
        }


        // =====================================================
        // BACK
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            if (HasUnsavedInformation())
            {
                DialogResult result =
                    MessageBox.Show(
                        "Your report will not be saved.\n\n" +
                        "Are you sure you want to go back?",
                        "Go Back to Main Menu?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (result != DialogResult.Yes)
                {
                    return;
                }
            }


            this.Close();
        }


        // =====================================================
        // UNSAVED INFORMATION
        // =====================================================

        private bool HasUnsavedInformation()
        {
            return
                !string.IsNullOrWhiteSpace(
                    txtLocation.Text)

                ||

                cmbCategory.SelectedIndex > 0

                ||

                !string.IsNullOrWhiteSpace(
                    rtbDescription.Text)

                ||

                !string.IsNullOrWhiteSpace(
                    selectedFilePath);
        }


        // =====================================================
        // CLEAR FORM
        // =====================================================

        private void ClearForm()
        {
            txtLocation.Clear();

            cmbCategory.SelectedIndex =
                0;

            rtbDescription.Clear();

            selectedFilePath =
                string.Empty;

            lblSelectedFile.Text =
                "No file selected";

            lblSelectedFile.ForeColor =
                System.Drawing.Color.Gray;

            lblCharacterCount.Text =
                "0 / 1000";

            HideErrors();
        }


        // =====================================================
        // SHOW ERROR
        // =====================================================

        private void ShowError(
            Label label,
            string message)
        {
            label.Text =
                message;

            label.Visible =
                true;
        }


        // =====================================================
        // HIDE ERRORS
        // =====================================================

        private void HideErrors()
        {
            lblLocationError.Visible =
                false;

            lblCategoryError.Visible =
                false;

            lblDescriptionError.Visible =
                false;

            lblAttachmentError.Visible =
                false;
        }


        // =====================================================
        // SUCCESS DIALOG
        // =====================================================

        private void ShowSuccessDialog(
            string referenceNumber)
        {
            using (
                ReportSuccessForm successForm =
                    new ReportSuccessForm(
                        referenceNumber))
            {
                successForm.ShowDialog(
                    this);
            }
        }


        // =====================================================
        // FAILURE DIALOG
        // =====================================================

        private void ShowFailureDialog(
            string message)
        {
            using (
                ReportFailureForm failureForm =
                    new ReportFailureForm(
                        message))
            {
                failureForm.ShowDialog(
                    this);
            }
        }
    }
}