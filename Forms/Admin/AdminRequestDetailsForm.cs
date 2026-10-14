
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminRequestDetailsForm : Form
    {
        private readonly IssueReport currentIssue;
        private readonly bool editMode;

        public AdminRequestDetailsForm(
            IssueReport issue,
            bool edit)
        {
            InitializeComponent();

            if (issue == null)
            {
                throw new ArgumentNullException("issue");
            }

            currentIssue = issue;
            editMode = edit;

            AdminUi.Secure(this);

            LoadIssueDetails();
            ConfigureMode();
        }

        // =====================================================
        // LOAD SERVICE REQUEST DETAILS
        // =====================================================

        private void LoadIssueDetails()
        {
            lblReferenceValue.Text =
                currentIssue.ReferenceNumber ?? "N/A";

            lblResidentValue.Text =
                currentIssue.UserEmail ?? "N/A";

            lblCategoryValue.Text =
                currentIssue.Category ?? "N/A";

            lblLocationValue.Text =
                currentIssue.Location ?? "N/A";

            lblDateValue.Text =
                currentIssue.DateReported.ToString(
                    "dd MMMM yyyy, HH:mm");

            txtDescription.Text =
                currentIssue.Description ?? "";

            lblCurrentStatusValue.Text =
                string.IsNullOrWhiteSpace(currentIssue.Status)
                    ? "Pending"
                    : currentIssue.Status;

            cmbStatus.SelectedItem =
                lblCurrentStatusValue.Text;

            if (cmbStatus.SelectedIndex == -1)
            {
                cmbStatus.SelectedIndex = 0;
            }

            // Attachment
            if (!string.IsNullOrWhiteSpace(
                    currentIssue.AttachmentPath))
            {
                lblAttachmentValue.Text =
                    Path.GetFileName(
                        currentIssue.AttachmentPath);

                btnViewAttachment.Enabled =
                    File.Exists(
                        currentIssue.AttachmentPath);
            }
            else
            {
                lblAttachmentValue.Text =
                    "No attachment provided";

                btnViewAttachment.Enabled = false;
            }

            ApplyStatusColour();
        }

        // =====================================================
        // VIEW OR EDIT MODE
        // =====================================================

        private void ConfigureMode()
        {
            cmbStatus.Enabled = editMode;
            btnSave.Visible = editMode;

            lblPageTitle.Text = editMode
                ? "Update Service Request"
                : "Service Request Details";

            lblPageDescription.Text = editMode
                ? "Review the request and update its status."
                : "Review the details submitted by the resident.";

            txtDescription.ReadOnly = true;
        }

        // =====================================================
        // STATUS COLOUR
        // =====================================================

        private void ApplyStatusColour()
        {
            string status =
                lblCurrentStatusValue.Text;

            switch (status)
            {
                case "Pending":
                    lblCurrentStatusValue.ForeColor =
                        Color.FromArgb(180, 120, 0);
                    break;

                case "In Progress":
                    lblCurrentStatusValue.ForeColor =
                        Color.FromArgb(0, 119, 200);
                    break;

                case "Resolved":
                    lblCurrentStatusValue.ForeColor =
                        Color.FromArgb(0, 119, 75);
                    break;

                case "Rejected":
                    lblCurrentStatusValue.ForeColor =
                        Color.FromArgb(190, 40, 50);
                    break;

                default:
                    lblCurrentStatusValue.ForeColor =
                        Color.DimGray;
                    break;
            }
        }

        // =====================================================
        // SAVE STATUS CHANGE
        // =====================================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!editMode)
            {
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string newStatus =
                cmbStatus.SelectedItem.ToString();

            DialogResult result =
                MessageBox.Show(
                    "Change request " +
                    currentIssue.ReferenceNumber +
                    " to \"" + newStatus + "\"?",
                    "Confirm Status Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Find the original report in IssueStore
            IssueReport storedIssue =
                IssueStore.GetIssueByReference(
                    currentIssue.ReferenceNumber);

            if (storedIssue == null)
            {
                MessageBox.Show(
                    "The service request could not be found.",
                    "Request Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Update the shared issue object
            storedIssue.Status = newStatus;

            currentIssue.Status = newStatus;

            lblCurrentStatusValue.Text =
                newStatus;

            ApplyStatusColour();

            MessageBox.Show(
                "Service request status updated successfully.",
                "Update Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        // =====================================================
        // OPEN ATTACHMENT
        // =====================================================

        private void btnViewAttachment_Click(
            object sender,
            EventArgs e)
        {
            string path =
                currentIssue.AttachmentPath;

            if (string.IsNullOrWhiteSpace(path) ||
                !File.Exists(path))
            {
                MessageBox.Show(
                    "The attachment could not be found.",
                    "Attachment Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open attachment: " +
                    ex.Message,
                    "Attachment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BACK TO SERVICE REQUESTS
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}
