using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    public partial class SignUpForm : Form
    {
        private readonly AuthenticationService
            authenticationService;


        public SignUpForm()
        {
            InitializeComponent();

            authenticationService =
                new AuthenticationService();
        }


        // =====================================================
        // CREATE ACCOUNT
        // =====================================================

        private void btnCreateAccount_Click(
            object sender,
            EventArgs e)
        {
            // Remove old error messages
            HideErrors();


            // =================================================
            // VALIDATE FORM
            // =================================================

            if (!ValidateForm())
            {
                using (
                    AuthenticationFailureForm failureForm =
                        new AuthenticationFailureForm(
                            "Check Your Details",
                            "Some of the information entered is missing or invalid.\n\n" +
                            "Please correct the highlighted fields and try again."))
                {
                    failureForm.ShowDialog(this);
                }

                return;
            }


            // =================================================
            // CREATE USER
            // =================================================

            User newUser =
                new User();


            newUser.FirstName =
                txtFirstName.Text.Trim();


            newUser.LastName =
                txtLastName.Text.Trim();


            newUser.Email =
                txtEmail.Text.Trim();


            newUser.PhoneNumber =
                txtPhone.Text.Trim();


            newUser.ResidentialAddress =
                txtAddress.Text.Trim();


            newUser.Suburb =
                txtSuburb.Text.Trim();


            newUser.City =
                txtCity.Text.Trim();


            newUser.PostalCode =
                txtPostalCode.Text.Trim();


            newUser.Password =
                txtPassword.Text;


            // =================================================
            // REGISTER USER
            // =================================================

            string message;


            bool registered =
                authenticationService.Register(
                    newUser,
                    out message);


            // =================================================
            // REGISTRATION FAILED
            // =================================================

            if (!registered)
            {
                // Show the error underneath email as well
                ShowError(
                    lblEmailError,
                    message);


                // Custom failure dialog
                using (
                    AuthenticationFailureForm failureForm =
                        new AuthenticationFailureForm(
                            "Account Creation Failed",
                            message))
                {
                    failureForm.ShowDialog(this);
                }


                txtEmail.Focus();

                return;
            }


            // =================================================
            // ACCOUNT CREATED SUCCESSFULLY
            // =================================================

            using (
                AuthenticationSuccessForm successForm =
                    new AuthenticationSuccessForm(
                        "Account Created",
                        "Welcome, " +
                        newUser.FirstName +
                        "!\n\nYour municipal services account has been created successfully.\n" +
                        "You can now sign in using your email address."))
            {
                successForm.ShowDialog(this);
            }


            // =================================================
            // RETURN TO SIGN IN
            // =================================================

            OpenSignIn();
        }


        // =====================================================
        // VALIDATE FORM
        // =====================================================

        private bool ValidateForm()
        {
            bool valid =
                true;


            // =================================================
            // FIRST NAME
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtFirstName.Text))
            {
                ShowError(
                    lblFirstNameError,
                    "First name is required.");

                valid =
                    false;
            }


            // =================================================
            // LAST NAME
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtLastName.Text))
            {
                ShowError(
                    lblLastNameError,
                    "Last name is required.");

                valid =
                    false;
            }


            // =================================================
            // EMAIL
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtEmail.Text))
            {
                ShowError(
                    lblEmailError,
                    "Email address is required.");

                valid =
                    false;
            }
            else if (!IsValidEmail(
                txtEmail.Text.Trim()))
            {
                ShowError(
                    lblEmailError,
                    "Please enter a valid email address.");

                valid =
                    false;
            }


            // =================================================
            // PHONE
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtPhone.Text))
            {
                ShowError(
                    lblPhoneError,
                    "Phone number is required.");

                valid =
                    false;
            }
            else if (!IsValidPhone(
                txtPhone.Text))
            {
                ShowError(
                    lblPhoneError,
                    "Enter a valid South African phone number.");

                valid =
                    false;
            }


            // =================================================
            // ADDRESS
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtAddress.Text))
            {
                ShowError(
                    lblAddressError,
                    "Residential address is required.");

                valid =
                    false;
            }


            // =================================================
            // SUBURB
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtSuburb.Text))
            {
                ShowError(
                    lblSuburbError,
                    "Suburb is required.");

                valid =
                    false;
            }


            // =================================================
            // CITY
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtCity.Text))
            {
                ShowError(
                    lblCityError,
                    "City or area is required.");

                valid =
                    false;
            }


            // =================================================
            // POSTAL CODE
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtPostalCode.Text))
            {
                ShowError(
                    lblPostalCodeError,
                    "Postal code is required.");

                valid =
                    false;
            }
            else if (!Regex.IsMatch(
                txtPostalCode.Text.Trim(),
                @"^\d{4}$"))
            {
                ShowError(
                    lblPostalCodeError,
                    "Postal code must contain exactly 4 digits.");

                valid =
                    false;
            }


            // =================================================
            // PASSWORD
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                ShowError(
                    lblPasswordError,
                    "Password is required.");

                valid =
                    false;
            }
            else if (!IsStrongPassword(
                txtPassword.Text))
            {
                ShowError(
                    lblPasswordError,
                    "Use 8+ characters, uppercase, lowercase and a number.");

                valid =
                    false;
            }


            // =================================================
            // CONFIRM PASSWORD
            // =================================================

            if (string.IsNullOrWhiteSpace(
                txtConfirmPassword.Text))
            {
                ShowError(
                    lblConfirmPasswordError,
                    "Please confirm your password.");

                valid =
                    false;
            }
            else if (
                txtPassword.Text !=
                txtConfirmPassword.Text)
            {
                ShowError(
                    lblConfirmPasswordError,
                    "Passwords do not match.");

                valid =
                    false;
            }


            // =================================================
            // TERMS AND CONDITIONS
            // =================================================

            if (!chkTerms.Checked)
            {
                ShowError(
                    lblTermsError,
                    "Please accept the Terms and Conditions.");

                valid =
                    false;
            }


            return valid;
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
        // PHONE VALIDATION
        // =====================================================

        private bool IsValidPhone(
            string phone)
        {
            if (string.IsNullOrWhiteSpace(
                phone))
            {
                return false;
            }


            string cleaned =
                phone
                    .Replace(" ", "")
                    .Replace("-", "")
                    .Replace("(", "")
                    .Replace(")", "");


            // Accepted examples:
            //
            // 0712345678
            // 071 234 5678
            // 071-234-5678
            // +27712345678
            // +27 71 234 5678

            return Regex.IsMatch(
                cleaned,
                @"^(\+27[6-8][0-9]{8}|0[6-8][0-9]{8})$");
        }


        // =====================================================
        // PASSWORD VALIDATION
        // =====================================================

        private bool IsStrongPassword(
            string password)
        {
            if (string.IsNullOrEmpty(
                password))
            {
                return false;
            }


            if (password.Length < 8)
            {
                return false;
            }


            bool hasUppercase =
                Regex.IsMatch(
                    password,
                    @"[A-Z]");


            bool hasLowercase =
                Regex.IsMatch(
                    password,
                    @"[a-z]");


            bool hasNumber =
                Regex.IsMatch(
                    password,
                    @"[0-9]");


            return
                hasUppercase &&
                hasLowercase &&
                hasNumber;
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
        // HIDE ALL ERRORS
        // =====================================================

        private void HideErrors()
        {
            lblFirstNameError.Text =
                "";

            lblFirstNameError.Visible =
                false;


            lblLastNameError.Text =
                "";

            lblLastNameError.Visible =
                false;


            lblEmailError.Text =
                "";

            lblEmailError.Visible =
                false;


            lblPhoneError.Text =
                "";

            lblPhoneError.Visible =
                false;


            lblAddressError.Text =
                "";

            lblAddressError.Visible =
                false;


            lblSuburbError.Text =
                "";

            lblSuburbError.Visible =
                false;


            lblCityError.Text =
                "";

            lblCityError.Visible =
                false;


            lblPostalCodeError.Text =
                "";

            lblPostalCodeError.Visible =
                false;


            lblPasswordError.Text =
                "";

            lblPasswordError.Visible =
                false;


            lblConfirmPasswordError.Text =
                "";

            lblConfirmPasswordError.Visible =
                false;


            lblTermsError.Text =
                "";

            lblTermsError.Visible =
                false;
        }


        // =====================================================
        // BACK BUTTON
        // =====================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            OpenSignIn();
        }


        // =====================================================
        // OPEN SIGN IN
        // =====================================================

        private void OpenSignIn()
        {
            SignInForm signInForm =
                new SignInForm();

            signInForm.Show();

            this.Hide();
        }
    }
}