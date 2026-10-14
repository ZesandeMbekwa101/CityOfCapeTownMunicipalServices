
using System;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Forms.Issues;
using CityOfCapeTownMunicipalServices.Forms.Events;
using CityOfCapeTownMunicipalServices.Forms.Authentication;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            LoadCurrentUser();
        }

        // =====================================================
        // LOAD CURRENT USER
        // =====================================================

        private void LoadCurrentUser()
        {
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show(
                    "Please sign in to continue.",
                    "Sign In Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            lblWelcome.Text =
                "Welcome, " +
                UserSession.CurrentUser.FirstName +
                "!";
        }

        // =====================================================
        // REPORT ISSUE
        // =====================================================

        private void btnReportIssue_Click(
            object sender,
            EventArgs e)
        {
            using (ReportIssueForm reportIssueForm =
                new ReportIssueForm())
            {
                reportIssueForm.ShowDialog(this);
            }
        }

        // =====================================================
        // LOCAL EVENTS AND ANNOUNCEMENTS
        // =====================================================

        private void btnEvents_Click(
            object sender,
            EventArgs e)
        {
            using (LocalEventsForm localEventsForm =
                new LocalEventsForm())
            {
                localEventsForm.ShowDialog(this);
            }
        }

        // =====================================================
        // SIGN OUT - RETURN TO SIGN UP
        // =====================================================

        private void btnSignOut_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Clear logged-in user session
            UserSession.EndSession();

            // Open the Sign Up screen
            SignInForm signInForm = new SignInForm();

            // Keep this dashboard hidden
            // while the Sign Up screen is open.
            this.Hide();

            signInForm.FormClosed += (s, args) =>
            {
                this.Close();
            };

            signInForm.Show();
        }
    }
}
