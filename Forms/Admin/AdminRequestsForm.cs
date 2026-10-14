
using System;
using System.Linq;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.DataStructures;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminRequestsForm : Form
    {
        private IssueReport[] visible =
            new IssueReport[0];

        public AdminRequestsForm()
        {
            InitializeComponent();

            // Restrict access to administrators
            AdminUi.Secure(this);

            // Search requests
            txtSearch.TextChanged += (s, e) =>
            {
                LoadRows();
            };

            // Filter by status
            cmbStatus.SelectedIndexChanged += (s, e) =>
            {
                LoadRows();
            };

            // Refresh whenever admin returns to this form
            Activated += (s, e) =>
            {
                LoadRows();
            };

            // Initial load
            LoadRows();
        }

        // =====================================================
        // LOAD ALL CITIZEN SERVICE REQUESTS
        // =====================================================

        private void LoadRows()
        {
            string search = txtSearch.Text.Trim();
            string status = cmbStatus.Text;

            // Read the SAME store used by citizens
            var requests = IssueStore.GetAllIssues();

            visible = requests
                .Where(issue =>
                    (
                        status == "All" ||
                        string.Equals(
                            issue.Status,
                            status,
                            StringComparison.OrdinalIgnoreCase)
                    )
                    &&
                    (
                        string.IsNullOrWhiteSpace(search)
                        ||
                        (
                            (issue.ReferenceNumber ?? "") + " " +
                            (issue.UserEmail ?? "") + " " +
                            (issue.Category ?? "") + " " +
                            (issue.Description ?? "") + " " +
                            (issue.Location ?? "")
                        ).IndexOf(
                            search,
                            StringComparison.OrdinalIgnoreCase
                        ) >= 0
                    )
                )
                .OrderByDescending(issue =>
                    issue.DateReported)
                .ToArray();

            grid.Rows.Clear();

            foreach (IssueReport issue in visible)
            {
                grid.Rows.Add(
                    issue.ReferenceNumber,
                    issue.UserEmail,
                    issue.Category,
                    issue.Description,
                    issue.Location,
                    issue.Status,
                    issue.DateReported.ToString("dd MMM yyyy")
                );
            }
        }

        // =====================================================
        // GET SELECTED REQUEST
        // =====================================================

        private IssueReport Selected()
        {
            if (grid.CurrentRow == null)
            {
                return null;
            }

            int index = grid.CurrentRow.Index;

            if (index < 0 || index >= visible.Length)
            {
                return null;
            }

            return visible[index];
        }

        // =====================================================
        // OPEN REQUEST DETAILS
        // =====================================================

        private void Open(bool edit)
        {
            IssueReport selectedIssue = Selected();

            if (selectedIssue == null)
            {
                MessageBox.Show(
                    "Please select a service request first.",
                    "No Request Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (AdminRequestDetailsForm detailsForm =
                new AdminRequestDetailsForm(
                    selectedIssue,
                    edit))
            {
                detailsForm.ShowDialog(this);
            }

            // Refresh after details form closes
            LoadRows();
        }

        // =====================================================
        // VIEW DETAILS
        // =====================================================

        private void btnView_Click(
            object sender,
            EventArgs e)
        {
            Open(false);
        }

        // =====================================================
        // CHANGE STATUS
        // =====================================================

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            Open(true);
        }

        // =====================================================
        // BACK TO ADMIN DASHBOARD
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}
