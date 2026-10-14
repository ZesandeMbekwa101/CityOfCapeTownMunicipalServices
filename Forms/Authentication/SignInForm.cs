using System;
using System.Net.Mail;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.Forms.Home;
using CityOfCapeTownMunicipalServices.Forms.Admin;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    public partial class SignInForm : Form
    {
        private readonly AuthenticationService authenticationService;

        public SignInForm()
        {
            InitializeComponent();
            authenticationService = new AuthenticationService();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            HideErrors();
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowError(lblEmailError, "Email address is required.");
                return;
            }
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                ShowError(lblEmailError, "Please enter a valid email address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError(lblPasswordError, "Password is required.");
                return;
            }

            User user = authenticationService.SignIn(txtEmail.Text.Trim(), txtPassword.Text);
            if (user == null)
            {
                ShowError(lblPasswordError, "Incorrect email address or password.");
                using (AuthenticationFailureForm failureForm = new AuthenticationFailureForm(
                    "Sign In Failed", "The email address or password you entered is incorrect.\n\nPlease check your details and try again."))
                {
                    failureForm.ShowDialog(this);
                }
                txtPassword.Focus();
                return;
            }

            UserSession.StartSession(user);
            using (AuthenticationSuccessForm successForm = new AuthenticationSuccessForm(
                "Sign In Successful", "Welcome back, " + user.FirstName + "!\n\nYou have signed in successfully."))
            {
                successForm.ShowDialog(this);
            }

            Form destination = user.Role == UserRole.Admin
                ? (Form)new AdminHomeForm()
                : new HomeForm();

            destination.FormClosed += (s, args) => this.Close();
            destination.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        private void ShowError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

        private void HideErrors()
        {
            lblEmailError.Text = "";
            lblEmailError.Visible = false;
            lblPasswordError.Text = "";
            lblPasswordError.Visible = false;
        }
    }
}
