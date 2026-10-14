using System;
using System.Drawing;
using System.Windows.Forms;
namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    partial class AdminRequestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader, pnlBody;
        private PictureBox picLogo;
        private Label lblBrand, lblPortal, lblSubtitle;
        private TableLayoutPanel colourStrip;
        private Button btnBack;
        private DataGridView grid; private TextBox txtSearch; private ComboBox cmbStatus; private Button btnView, btnUpdate;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Text = "Service Requests - City of Cape Town"; ClientSize = new Size(1120, 730); MinimumSize = new Size(860, 590);
            StartPosition = FormStartPosition.CenterParent; Font = new Font("Segoe UI", 10F); BackColor = Color.White; AutoScaleMode = AutoScaleMode.Dpi;
            pnlHeader = new Panel { Dock = DockStyle.Top, Height = 112, BackColor = Color.FromArgb(0, 119, 75) };
            picLogo = new PictureBox { Image = Properties.Resources.city_logo, SizeMode = PictureBoxSizeMode.Zoom, Location = new Point(22, 17), Size = new Size(74, 74) };
            lblBrand = new Label { Text = "CITY OF CAPE TOWN\nISIXEKO SASEKAPA\nSTAD KAAPSTAD", ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(104, 24), Size = new Size(195, 68) };
            lblPortal = new Label { Text = "Municipal Services - Admin Portal", ForeColor = Color.White, Font = new Font("Segoe UI", 19F, FontStyle.Bold), Location = new Point(318, 19), Size = new Size(610, 43) };
            lblSubtitle = new Label { Text = "Review residents’ submissions and update status.", ForeColor = Color.White, Location = new Point(320, 66), Size = new Size(610, 27) };
            pnlHeader.Controls.AddRange(new Control[] { picLogo, lblBrand, lblPortal, lblSubtitle });
            colourStrip = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 12, ColumnCount = 4, RowCount = 1, Margin = new Padding(0) };
            Color[] colors = { Color.FromArgb(166, 206, 57), Color.FromArgb(255, 215, 0), Color.FromArgb(0, 119, 200), Color.FromArgb(230, 0, 126) };
            for (int i = 0; i < 4; i++) { colourStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25)); colourStrip.Controls.Add(new Panel { Dock = DockStyle.Fill, Margin = new Padding(0), BackColor = colors[i] }, i, 0); }
            pnlBody = new Panel { Dock = DockStyle.Fill, Padding = new Padding(26), BackColor = Color.FromArgb(248, 250, 252) };
            Controls.Add(pnlBody); Controls.Add(pnlHeader); Controls.Add(colourStrip);
            grid = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.White, BorderStyle = BorderStyle.FixedSingle, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, RowHeadersVisible = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, ColumnHeadersHeight = 40, RowTemplate = { Height = 35 }, EnableHeadersVisualStyles = false };
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(234, 242, 246); grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(18, 40, 65);
            grid.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewTextBoxColumn { Name = "Reference", HeaderText = "Reference" }, new DataGridViewTextBoxColumn { Name = "Resident", HeaderText = "Resident email" }, new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "Category" }, new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Description" }, new DataGridViewTextBoxColumn { Name = "Location", HeaderText = "Location" }, new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status" }, new DataGridViewTextBoxColumn { Name = "Date", HeaderText = "Date submitted" } }); pnlBody.Controls.Add(grid);
            var toolbar = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 67, WrapContents = false, AutoScroll = true, Padding = new Padding(0, 10, 0, 8) };
            txtSearch = new TextBox { Width = 250, Margin = new Padding(5, 7, 14, 4), Font = new Font("Segoe UI", 10F) }; toolbar.Controls.Add(new Label { Text = "Search", AutoSize = true, Margin = new Padding(5, 12, 0, 0) }); toolbar.Controls.Add(txtSearch);
            cmbStatus = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 155, Margin = new Padding(5, 7, 14, 4) }; cmbStatus.Items.AddRange(new object[] { "All", "Pending", "In Progress", "Resolved", "Rejected" }); cmbStatus.SelectedIndex = 0; toolbar.Controls.Add(new Label { Text = "Status", AutoSize = true, Margin = new Padding(5, 12, 0, 0) }); toolbar.Controls.Add(cmbStatus);
            btnView = new Button { Text = "View Details", Width = 142, Height = 37, Margin = new Padding(6, 4, 2, 2), BackColor = Color.FromArgb(0, 119, 75), ForeColor = Color.White, FlatStyle = FlatStyle.Flat }; btnView.Click += btnView_Click; toolbar.Controls.Add(btnView);
            btnUpdate = new Button { Text = "Change Status", Width = 142, Height = 37, Margin = new Padding(6, 4, 2, 2), BackColor = Color.FromArgb(0, 119, 75), ForeColor = Color.White, FlatStyle = FlatStyle.Flat }; btnUpdate.Click += btnUpdate_Click; toolbar.Controls.Add(btnUpdate);
            pnlBody.Controls.Add(toolbar);
            var header = new Panel { Dock = DockStyle.Top, Height = 102 };
            btnBack = new Button { Text = "← Back", Location = new Point(0, 2), Size = new Size(105, 35), BackColor = Color.White, ForeColor = Color.FromArgb(0, 75, 58), FlatStyle = FlatStyle.Flat }; btnBack.Click += btnBack_Click; header.Controls.Add(btnBack);
            var pageTitle = new Label { Text = "Service Requests", Font = new Font("Segoe UI", 21F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 75, 58), Location = new Point(0, 43), AutoSize = true }; header.Controls.Add(pageTitle);
            var pageDescription = new Label { Text = "Search, view and update submitted municipal issues.", ForeColor = Color.FromArgb(70, 85, 105), Location = new Point(0, 84), AutoSize = true }; header.Controls.Add(pageDescription);
            pnlBody.Controls.Add(header);
        }
    }
}
