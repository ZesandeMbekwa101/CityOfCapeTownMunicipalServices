using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Reports
{
    public partial class MyReportsForm : Form
    {
        private readonly IssueService
            issueService;

        private string currentFilter;


        public MyReportsForm()
        {
            InitializeComponent();

            issueService =
                new IssueService();

            currentFilter =
                "All";

            SetSelectedFilter(
                btnAll);

            LoadReports();
        }


        // =====================================================
        // LOAD REPORTS
        // =====================================================

        private void LoadReports()
        {
            pnlReports.Controls.Clear();


            // =================================================
            // CHECK LOGIN
            // =================================================

            if (!UserSession.IsLoggedIn)
            {
                lblTotalNumber.Text =
                    "0";

                ShowEmptyState(
                    "You must be signed in to view your reports.");

                return;
            }


            // =================================================
            // GET LOGGED-IN USER'S REPORTS
            // =================================================

            string email =
                UserSession.CurrentUser.Email;


            List<IssueReport> reports =
                issueService.GetUserIssues(
                    email);


            // Total should show all of this user's reports,
            // not only the currently filtered reports.

            lblTotalNumber.Text =
                reports.Count.ToString();


            // =================================================
            // SEARCH
            // =================================================

            string search =
                txtSearch.Text
                    .Trim()
                    .ToLower();


            if (!string.IsNullOrWhiteSpace(
                search))
            {
                reports =
                    reports
                        .Where(report =>
                            ContainsText(
                                report.ReferenceNumber,
                                search)

                            ||

                            ContainsText(
                                report.Category,
                                search)

                            ||

                            ContainsText(
                                report.Location,
                                search)

                            ||

                            ContainsText(
                                report.Description,
                                search))
                        .ToList();
            }


            // =================================================
            // FILTER
            // =================================================

            if (currentFilter != "All")
            {
                reports =
                    reports
                        .Where(report =>
                            string.Equals(
                                report.Status,
                                currentFilter,
                                StringComparison.OrdinalIgnoreCase))
                        .ToList();
            }


            // =================================================
            // SORT NEWEST FIRST
            // =================================================

            reports =
                reports
                    .OrderByDescending(
                        report =>
                            report.DateReported)
                    .ToList();


            // =================================================
            // EMPTY
            // =================================================

            if (reports.Count == 0)
            {
                if (
                    string.IsNullOrWhiteSpace(search) &&
                    currentFilter == "All")
                {
                    ShowEmptyState(
                        "Reports you submit will appear here.");
                }
                else
                {
                    ShowEmptyState(
                        "No reports match your search or selected status.");
                }

                return;
            }


            // =================================================
            // CREATE REPORT CARDS
            // =================================================

            foreach (
                IssueReport report in reports)
            {
                Panel card =
                    CreateReportCard(
                        report);

                pnlReports.Controls.Add(
                    card);
            }
        }


        // =====================================================
        // CREATE REPORT CARD
        // =====================================================

        private Panel CreateReportCard(
            IssueReport report)
        {
            Panel card =
                new Panel();

            card.Width =
                Math.Max(
                    800,
                    pnlReports.ClientSize.Width - 30);

            card.Height =
                190;

            card.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    15);

            card.BackColor =
                Color.White;

            card.BorderStyle =
                BorderStyle.FixedSingle;


            // =================================================
            // REFERENCE NUMBER
            // =================================================

            Label lblReference =
                new Label();

            lblReference.Text =
                report.ReferenceNumber;

            lblReference.AutoSize =
                true;

            lblReference.Location =
                new Point(
                    20,
                    15);

            lblReference.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblReference.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // =================================================
            // STATUS
            // =================================================

            Label lblStatus =
                new Label();

            lblStatus.Text =
                report.Status;

            lblStatus.Location =
                new Point(
                    card.Width - 150,
                    15);

            lblStatus.Size =
                new Size(
                    120,
                    30);

            lblStatus.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            lblStatus.TextAlign =
                ContentAlignment.MiddleCenter;

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    8.5F,
                    FontStyle.Bold);

            SetStatusColour(
                lblStatus,
                report.Status);


            // =================================================
            // CATEGORY
            // =================================================

            Label lblCategory =
                new Label();

            lblCategory.Text =
                report.Category;

            lblCategory.AutoSize =
                true;

            lblCategory.Location =
                new Point(
                    20,
                    48);

            lblCategory.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblCategory.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);


            // =================================================
            // LOCATION
            // =================================================

            Label lblLocation =
                new Label();

            lblLocation.Text =
                "⌖  " +
                report.Location;

            lblLocation.Location =
                new Point(
                    20,
                    77);

            lblLocation.Size =
                new Size(
                    390,
                    25);

            lblLocation.AutoEllipsis =
                true;

            lblLocation.ForeColor =
                Color.FromArgb(
                    75,
                    90,
                    105);


            // =================================================
            // DESCRIPTION
            // =================================================

            Label lblDescription =
                new Label();

            string description =
                report.Description ?? "";

            if (description.Length > 100)
            {
                description =
                    description.Substring(
                        0,
                        100) +
                    "...";
            }


            lblDescription.Text =
                description;

            lblDescription.Location =
                new Point(
                    20,
                    107);

            lblDescription.Size =
                new Size(
                    390,
                    42);

            lblDescription.AutoEllipsis =
                true;

            lblDescription.ForeColor =
                Color.FromArgb(
                    90,
                    100,
                    110);


            // =================================================
            // DATE
            // =================================================

            Label lblDate =
                new Label();

            lblDate.Text =
                "Submitted " +
                report.DateReported.ToString(
                    "dd MMM yyyy 'at' HH:mm");

            lblDate.Location =
                new Point(
                    20,
                    157);

            lblDate.AutoSize =
                true;

            lblDate.ForeColor =
                Color.Gray;


            // =================================================
            // PROGRESS TITLE
            // =================================================

            Label lblProgressTitle =
                new Label();

            lblProgressTitle.Text =
                "Report Progress";

            lblProgressTitle.Location =
                new Point(
                    450,
                    55);

            lblProgressTitle.AutoSize =
                true;

            lblProgressTitle.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblProgressTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // =================================================
            // PROGRESS BAR
            // =================================================

            ProgressBar progress =
                new ProgressBar();

            progress.Location =
                new Point(
                    450,
                    83);

            progress.Size =
                new Size(
                    Math.Max(
                        280,
                        card.Width - 480),
                    15);

            progress.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            progress.Minimum =
                0;

            progress.Maximum =
                100;

            progress.Value =
                GetProgressValue(
                    report.Status);


            // =================================================
            // PROGRESS PERCENTAGE
            // =================================================

            Label lblPercentage =
                new Label();

            lblPercentage.Text =
                progress.Value +
                "% complete";

            lblPercentage.Location =
                new Point(
                    450,
                    105);

            lblPercentage.AutoSize =
                true;

            lblPercentage.Font =
                new Font(
                    "Segoe UI",
                    8F);

            lblPercentage.ForeColor =
                Color.Gray;


            // =================================================
            // STATUS STEPS
            // =================================================

            Label lblSteps =
                new Label();

            lblSteps.Text =
                GetProgressText(
                    report.Status);

            lblSteps.Location =
                new Point(
                    450,
                    135);

            lblSteps.Size =
                new Size(
                    Math.Max(
                        300,
                        card.Width - 480),
                    35);

            lblSteps.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            lblSteps.Font =
                new Font(
                    "Segoe UI",
                    8F);

            lblSteps.ForeColor =
                Color.FromArgb(
                    75,
                    90,
                    105);


            // =================================================
            // ADD TO CARD
            // =================================================

            card.Controls.Add(
                lblReference);

            card.Controls.Add(
                lblStatus);

            card.Controls.Add(
                lblCategory);

            card.Controls.Add(
                lblLocation);

            card.Controls.Add(
                lblDescription);

            card.Controls.Add(
                lblDate);

            card.Controls.Add(
                lblProgressTitle);

            card.Controls.Add(
                progress);

            card.Controls.Add(
                lblPercentage);

            card.Controls.Add(
                lblSteps);


            return card;
        }


        // =====================================================
        // STATUS PROGRESS
        // =====================================================

        private int GetProgressValue(
            string status)
        {
            if (string.IsNullOrWhiteSpace(
                status))
            {
                return 25;
            }


            switch (status)
            {
                case "Submitted":

                    return 25;


                case "In Progress":

                    return 50;


                case "Resolved":

                    return 75;


                case "Closed":

                    return 100;


                default:

                    return 25;
            }
        }


        // =====================================================
        // PROGRESS TEXT
        // =====================================================

        private string GetProgressText(
            string status)
        {
            switch (status)
            {
                case "In Progress":

                    return
                        "● Submitted     ● In Progress     ○ Resolved     ○ Closed";


                case "Resolved":

                    return
                        "● Submitted     ● In Progress     ● Resolved     ○ Closed";


                case "Closed":

                    return
                        "● Submitted     ● In Progress     ● Resolved     ● Closed";


                default:

                    return
                        "● Submitted     ○ In Progress     ○ Resolved     ○ Closed";
            }
        }


        // =====================================================
        // STATUS COLOUR
        // =====================================================

        private void SetStatusColour(
            Label label,
            string status)
        {
            switch (status)
            {
                case "In Progress":

                    label.BackColor =
                        Color.FromArgb(
                            220,
                            240,
                            255);

                    label.ForeColor =
                        Color.FromArgb(
                            0,
                            119,
                            200);

                    break;


                case "Resolved":

                    label.BackColor =
                        Color.FromArgb(
                            225,
                            245,
                            225);

                    label.ForeColor =
                        Color.FromArgb(
                            40,
                            140,
                            65);

                    break;


                case "Closed":

                    label.BackColor =
                        Color.FromArgb(
                            230,
                            233,
                            236);

                    label.ForeColor =
                        Color.FromArgb(
                            80,
                            90,
                            100);

                    break;


                default:

                    label.BackColor =
                        Color.FromArgb(
                            255,
                            245,
                            205);

                    label.ForeColor =
                        Color.FromArgb(
                            170,
                            110,
                            0);

                    break;
            }
        }


        // =====================================================
        // SEARCH
        // =====================================================

        private bool ContainsText(
            string value,
            string search)
        {
            if (string.IsNullOrWhiteSpace(
                value))
            {
                return false;
            }


            return value
                .ToLower()
                .Contains(
                    search);
        }


        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            LoadReports();
        }


        // =====================================================
        // ALL
        // =====================================================

        private void btnAll_Click(
            object sender,
            EventArgs e)
        {
            currentFilter =
                "All";

            SetSelectedFilter(
                btnAll);

            LoadReports();
        }


        // =====================================================
        // SUBMITTED
        // =====================================================

        private void btnSubmitted_Click(
            object sender,
            EventArgs e)
        {
            currentFilter =
                "Submitted";

            SetSelectedFilter(
                btnSubmitted);

            LoadReports();
        }


        // =====================================================
        // IN PROGRESS
        // =====================================================

        private void btnInProgress_Click(
            object sender,
            EventArgs e)
        {
            currentFilter =
                "In Progress";

            SetSelectedFilter(
                btnInProgress);

            LoadReports();
        }


        // =====================================================
        // RESOLVED
        // =====================================================

        private void btnResolved_Click(
            object sender,
            EventArgs e)
        {
            currentFilter =
                "Resolved";

            SetSelectedFilter(
                btnResolved);

            LoadReports();
        }


        // =====================================================
        // CLOSED
        // =====================================================

        private void btnClosed_Click(
            object sender,
            EventArgs e)
        {
            currentFilter =
                "Closed";

            SetSelectedFilter(
                btnClosed);

            LoadReports();
        }


        // =====================================================
        // SELECTED FILTER
        // =====================================================

        private void SetSelectedFilter(
            Button selectedButton)
        {
            Button[] buttons =
            {
                btnAll,
                btnSubmitted,
                btnInProgress,
                btnResolved,
                btnClosed
            };


            foreach (
                Button button in buttons)
            {
                button.BackColor =
                    Color.FromArgb(
                        235,
                        247,
                        253);

                button.ForeColor =
                    Color.FromArgb(
                        0,
                        59,
                        113);
            }


            selectedButton.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            selectedButton.ForeColor =
                Color.White;
        }


        // =====================================================
        // EMPTY STATE
        // =====================================================

        private void ShowEmptyState(
            string message)
        {
            pnlEmpty.Width =
                Math.Max(
                    800,
                    pnlReports.ClientSize.Width - 30);

            lblEmptyIcon.Width =
                pnlEmpty.Width;

            lblEmptyTitle.Width =
                pnlEmpty.Width;

            lblEmptyMessage.Width =
                pnlEmpty.Width;

            lblEmptyMessage.Text =
                message;

            pnlReports.Controls.Add(
                pnlEmpty);
        }


        // =====================================================
        // BACK
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }


        // =====================================================
        // NEW REPORT
        // =====================================================

        private void btnNewReport_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}