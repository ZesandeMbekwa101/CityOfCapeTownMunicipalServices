using System;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Forms.Issues;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.Forms.Authentication;

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
        private void btnReportIssue_Click(
                object sender,
                EventArgs e)
        {
            ReportIssueForm reportIssueForm =
                new ReportIssueForm();

            reportIssueForm.ShowDialog(this);
        }


        // =====================================================
        // SIGN OUT
        // =====================================================

        private void btnSignOut_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to sign out?",
                    "Sign Out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
                return;
            }


            // Remove logged-in user
            UserSession.EndSession();


            // Return to sign in
            SignInForm signInForm =
                new SignInForm();

            signInForm.Show();

            this.Hide();
        }
    }
}