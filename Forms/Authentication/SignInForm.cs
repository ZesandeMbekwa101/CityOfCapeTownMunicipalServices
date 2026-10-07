using System;
using System.Net.Mail;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.Forms.Home;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    public partial class SignInForm : Form
    {
        private readonly AuthenticationService
            authenticationService;


        public SignInForm()
        {
            InitializeComponent();

            authenticationService =
                new AuthenticationService();
        }


        // =====================================================
        // SIGN IN
        // =====================================================

        private void btnSignIn_Click(
            object sender,
            EventArgs e)
        {
            // Remove previous inline errors
            HideErrors();


            // =================================================
            // EMAIL EMPTY
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtEmail.Text))
            {
                ShowError(
                    lblEmailError,
                    "Email address is required.");

                return;
            }


            // =================================================
            // INVALID EMAIL
            // =================================================

            if (!IsValidEmail(
                txtEmail.Text.Trim()))
            {
                ShowError(
                    lblEmailError,
                    "Please enter a valid email address.");

                return;
            }


            // =================================================
            // PASSWORD EMPTY
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                ShowError(
                    lblPasswordError,
                    "Password is required.");

                return;
            }


            // =================================================
            // TRY SIGNING IN
            // =================================================

            User user =
                authenticationService.SignIn(
                    txtEmail.Text.Trim(),
                    txtPassword.Text);


            // =================================================
            // SIGN IN FAILED
            // =================================================

            if (user == null)
            {
                // Keep the inline error as well
                ShowError(
                    lblPasswordError,
                    "Incorrect email address or password.");


                // Show custom failure dialog
                using (
                    AuthenticationFailureForm failureForm =
                        new AuthenticationFailureForm(
                            "Sign In Failed",
                            "The email address or password you entered is incorrect.\n\n" +
                            "Please check your details and try again."))
                {
                    failureForm.ShowDialog(this);
                }


                // Put cursor back on password
                txtPassword.Focus();

                return;
            }


            // =================================================
            // START USER SESSION
            // =================================================

            UserSession.StartSession(
                user);


            // =================================================
            // SIGN IN SUCCESS
            // =================================================

            using (
                AuthenticationSuccessForm successForm =
                    new AuthenticationSuccessForm(
                        "Sign In Successful",
                        "Welcome back, " +
                        user.FirstName +
                        "!\n\nYou have signed in successfully."))
            {
                successForm.ShowDialog(this);
            }


            // =================================================
            // OPEN HOME
            // =================================================

            HomeForm homeForm =
                new HomeForm();

            homeForm.Show();

            this.Hide();
        }


        // =====================================================
        // CREATE ACCOUNT
        // =====================================================

        private void btnCreateAccount_Click(
            object sender,
            EventArgs e)
        {
            SignUpForm signUpForm =
                new SignUpForm();

            signUpForm.Show();

            this.Hide();
        }


        // =====================================================
        // EMAIL VALIDATION
        // =====================================================

        private bool IsValidEmail(
            string email)
        {
            try
            {
                MailAddress address =
                    new MailAddress(
                        email);

                return
                    address.Address ==
                    email;
            }
            catch
            {
                return false;
            }
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
            lblEmailError.Text =
                "";

            lblEmailError.Visible =
                false;


            lblPasswordError.Text =
                "";

            lblPasswordError.Visible =
                false;
        }
    }
}