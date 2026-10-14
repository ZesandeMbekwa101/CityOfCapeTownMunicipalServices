using System;
using System.Linq;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.DataStructures;
using CityOfCapeTownMunicipalServices.Models;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    public partial class AdminAnnouncementsForm : Form
    {
        private MunicipalEvent[] visible = new MunicipalEvent[0];

        public AdminAnnouncementsForm()
        {
            InitializeComponent();
            AdminUi.Secure(this);
            txtSearch.TextChanged += (s, e) => LoadRows();
            cmbCategory.SelectedIndexChanged += CategoryChanged;
            Activated += (s, e) => LoadRows();
            LoadRows();
        }

        private void LoadRows()
        {
            string previousCategory = cmbCategory.SelectedItem as string ?? "All Categories";
            var all = EventStore.GetAllEvents().Where(x => x.IsAnnouncement == true).ToList();
            var categories = all.Select(x => x.Category)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(x => x).ToArray();
            cmbCategory.SelectedIndexChanged -= CategoryChanged;
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            cmbCategory.Items.AddRange(categories);
            int categoryIndex = cmbCategory.FindStringExact(previousCategory);
            cmbCategory.SelectedIndex = categoryIndex >= 0 ? categoryIndex : 0;
            cmbCategory.SelectedIndexChanged += CategoryChanged;
            string category = cmbCategory.SelectedItem.ToString();
            string q = txtSearch.Text.Trim();
            visible = all.Where(x =>
                (category == "All Categories" || string.Equals(x.Category, category, StringComparison.OrdinalIgnoreCase)) &&
                (q.Length == 0 || ((x.Title ?? "") + " " + (x.Category ?? "") + " " +
                  (x.Description ?? "") + " " + (x.Location ?? ""))
                  .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0))
                .OrderBy(x => x.EventDate).ToArray();
            grid.Rows.Clear();
            foreach (MunicipalEvent item in visible)
            {
                int index = grid.Rows.Add(item.EventId, item.Title, item.Category,
                    item.Location, item.EventDate.ToString("dd MMM yyyy HH:mm"),
                    item.EndDate.ToString("dd MMM yyyy HH:mm"));
                grid.Rows[index].Tag = item.EventId;
            }
            lblCount.Text = visible.Length + " announcements";
        }

        private void CategoryChanged(object sender, EventArgs e) { LoadRows(); }

        private MunicipalEvent Selected()
        {
            if (grid.CurrentRow == null || grid.CurrentRow.Tag == null) return null;
            return EventStore.GetEventById((int)grid.CurrentRow.Tag);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AdminEventEditorForm(true))
            {
                if (form.ShowDialog(this) == DialogResult.OK) LoadRows();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MunicipalEvent item = Selected();
            if (item == null) { MessageBox.Show("Select an item first."); return; }
            using (var form = new AdminEventEditorForm(true, item))
            {
                if (form.ShowDialog(this) == DialogResult.OK) LoadRows();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MunicipalEvent item = Selected();
            if (item == null) { MessageBox.Show("Select an item first."); return; }
            if (MessageBox.Show("Delete '" + item.Title + "'?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            if (!EventStore.DeleteEvent(item.EventId))
            {
                MessageBox.Show("Could not delete the selected item."); return;
            }
            LoadRows();
        }

        private void btnBack_Click(object sender, EventArgs e) { Close(); }
    }
}
