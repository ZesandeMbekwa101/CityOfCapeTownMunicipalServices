using System;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;
using CityOfCapeTownMunicipalServices.Forms.Authentication;
namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm() { InitializeComponent(); }
        protected override void OnShown(EventArgs e) { base.OnShown(e); AdminUi.RequireAdmin(this); }
        private void AdminResource_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser == null || UserSession.CurrentUser.Role != UserRole.Admin) { MessageBox.Show("Admin access required."); return; }
            Button b = sender as Button; if (b == null) return; string section = Convert.ToString(b.Tag);
            Form target = null;
            switch (section)
            {
                case "Service Requests": target = new AdminRequestsForm(); break;
                case "Events": target = new AdminEventsForm(); break;
                case "Announcements": target = new AdminAnnouncementsForm(); break;
                case "Users": target = new AdminUsersForm(); break;
                default: MessageBox.Show(section + " management is not implemented yet."); return;
            }
            using (target) target.ShowDialog(this);
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSession.EndSession(); new SignInForm().Show(); Hide();
        }
    }
}
