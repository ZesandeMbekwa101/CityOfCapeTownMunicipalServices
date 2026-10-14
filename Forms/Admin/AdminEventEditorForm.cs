using System;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminEventEditorForm : Form
    {
        private readonly bool isAnnouncement;
        private readonly MunicipalEvent existing;

        private static readonly string[] EventCategories = {
            "Community", "Education", "Recreation", "Safety", "Environment",
            "Health", "Sports", "Arts & Culture", "Youth Development", "Public Participation"
        };
        private static readonly string[] AnnouncementCategories = {
            "Municipal Notice", "Water Supply", "Electricity", "Roads & Transport",
            "Waste Collection", "Service Disruption", "Public Safety",
            "Emergency Alert", "Maintenance", "General Announcement"
        };

        public AdminEventEditorForm(bool announcement, MunicipalEvent item = null)
        {
            InitializeComponent();
            AdminUi.Secure(this);
            isAnnouncement = announcement;
            existing = item;
            string type = announcement ? "Announcement" : "Event";
            string action = item == null ? "Add New " : "Edit ";
            Text = action + type + " - City of Cape Town";
            lblEditorTitle.Text = action + type;
            lblSubtitle.Text = item == null ? "Create a municipal " + type.ToLower() + "." : "Update this municipal " + type.ToLower() + ".";
            btnSave.Text = item == null ? "Add " + type : "Save Changes";
            cmbCategory.Items.AddRange(announcement ? AnnouncementCategories : EventCategories);
            cmbCategory.SelectedIndex = -1;
            dtStart.Value = DateTime.Now.AddDays(1);
            dtEnd.Value = DateTime.Now.AddDays(1).AddHours(2);
            if (item != null)
            {
                txtTitle.Text = item.Title;
                txtLocation.Text = item.Location;
                txtDescription.Text = item.Description;
                dtStart.Value = item.EventDate;
                dtEnd.Value = item.EndDate;
                int index = cmbCategory.FindStringExact(item.Category ?? "");
                if (index < 0 && !string.IsNullOrWhiteSpace(item.Category))
                {
                    cmbCategory.Items.Add(item.Category);
                    index = cmbCategory.FindStringExact(item.Category);
                }
                cmbCategory.SelectedIndex = index;
            }
        }

        public AdminEventEditorForm(MunicipalEvent item, bool announcement)
            : this(announcement, item) { }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || cmbCategory.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Complete all required fields and select a category.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtEnd.Value <= dtStart.Value)
            {
                MessageBox.Show("End date must be after start date.", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MunicipalEvent value = new MunicipalEvent
            {
                EventId = existing == null ? EventStore.GetNextEventId() : existing.EventId,
                Title = txtTitle.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Location = txtLocation.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                EventDate = dtStart.Value,
                EndDate = dtEnd.Value,
                IsAnnouncement = isAnnouncement
            };
            bool saved = existing == null ? EventStore.AddEvent(value) : EventStore.UpdateEvent(value);
            if (!saved)
            {
                MessageBox.Show("Unable to save this item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) { Close(); }
        private void btnBack_Click(object sender, EventArgs e) { Close(); }
    }
}
