using System;
using System.Linq;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.DataStructures;
namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminAddUserForm : Form
    {
        public AdminAddUserForm() { InitializeComponent(); AdminUi.Secure(this); }
        private void btnSave_Click(object s, EventArgs e) { if (string.IsNullOrWhiteSpace(txtFirst.Text) || string.IsNullOrWhiteSpace(txtLast.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("First name, last name, email and password are required."); return; } if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MessageBox.Show("Enter a valid email address."); return; } if (txtPassword.Text.Length < 8 || !txtPassword.Text.Any(char.IsUpper) || !txtPassword.Text.Any(char.IsLower) || !txtPassword.Text.Any(char.IsDigit)) { MessageBox.Show("Use at least 8 characters, uppercase, lowercase and a number."); return; } if (txtPassword.Text != txtConfirm.Text) { MessageBox.Show("Passwords do not match."); return; } if (UserStore.UserExists(txtEmail.Text)) { MessageBox.Show("This email is already registered."); return; } var user = new User { FirstName = txtFirst.Text.Trim(), LastName = txtLast.Text.Trim(), Email = txtEmail.Text.Trim(), PhoneNumber = txtPhone.Text.Trim(), ResidentialAddress = txtAddress.Text.Trim(), Suburb = txtSuburb.Text.Trim(), City = txtCity.Text.Trim(), PostalCode = txtPostal.Text.Trim(), Password = txtPassword.Text }; string message; bool ok = cmbRole.Text == "Admin" ? new AdminAccountService().RegisterAdmin(user, out message) : new AuthenticationService().Register(user, out message); MessageBox.Show(message); if (ok) { DialogResult = DialogResult.OK; Close(); } }
        private void btnBack_Click(object s, EventArgs e) { Close(); }
        private void btnCancel_Click(object s, EventArgs e) { Close(); }
    }
}
