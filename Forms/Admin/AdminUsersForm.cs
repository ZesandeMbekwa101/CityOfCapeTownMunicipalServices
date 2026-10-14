using System;
using System.Linq;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.DataStructures;
namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminUsersForm : Form
    {
        private User[] visible = new User[0];
        public AdminUsersForm() { InitializeComponent(); AdminUi.Secure(this); txtSearch.TextChanged += (s, e) => LoadRows(); cmbRole.SelectedIndexChanged += (s, e) => LoadRows(); Activated += (s, e) => LoadRows(); LoadRows(); }
        private void LoadRows() { string q = txtSearch.Text.Trim(), role = cmbRole.Text; visible = UserStore.GetAllUsers().Where(x => (role == "All" || x.Role.ToString() == role) && (string.IsNullOrEmpty(q) || ((x.FullName ?? "") + (x.Email ?? "")).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0)).ToArray(); grid.Rows.Clear(); foreach (var x in visible) grid.Rows.Add(x.FirstName, x.LastName, x.Email, x.PhoneNumber, x.Role.ToString()); }
        private void btnAdd_Click(object s, EventArgs e) { using (var f = new AdminAddUserForm()) f.ShowDialog(this); LoadRows(); }
        private void btnBack_Click(object s, EventArgs e) { Close(); }
    }
}
