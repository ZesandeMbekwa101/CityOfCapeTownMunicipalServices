using System;
using System.Drawing;
using System.Windows.Forms;
namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    partial class AdminAddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader, pnlBody;
        private PictureBox picLogo;
        private Label lblBrand, lblPortal, lblSubtitle;
        private TableLayoutPanel colourStrip;
        private Button btnBack, btnSave, btnCancel;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtSuburb;
        private TextBox txtCity;
        private TextBox txtPostal;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtConfirm;

        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Text = "Add New User - City of Cape Town"; ClientSize = new Size(950, 750); MinimumSize = new Size(860, 590);
            StartPosition = FormStartPosition.CenterParent; Font = new Font("Segoe UI", 10F); BackColor = Color.White; AutoScaleMode = AutoScaleMode.Dpi;
            pnlHeader = new Panel { Dock = DockStyle.Top, Height = 112, BackColor = Color.FromArgb(0, 119, 75) };
            picLogo = new PictureBox { Image = Properties.Resources.city_logo, SizeMode = PictureBoxSizeMode.Zoom, Location = new Point(22, 17), Size = new Size(74, 74) };
            lblBrand = new Label { Text = "CITY OF CAPE TOWN\nISIXEKO SASEKAPA\nSTAD KAAPSTAD", ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(104, 24), Size = new Size(195, 68) };
            lblPortal = new Label { Text = "Municipal Services - Admin Portal", ForeColor = Color.White, Font = new Font("Segoe UI", 19F, FontStyle.Bold), Location = new Point(318, 19), Size = new Size(610, 43) };
            lblSubtitle = new Label { Text = "Create a citizen or administrator account.", ForeColor = Color.White, Location = new Point(320, 66), Size = new Size(610, 27) };
            pnlHeader.Controls.AddRange(new Control[] { picLogo, lblBrand, lblPortal, lblSubtitle });
            colourStrip = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 12, ColumnCount = 4, RowCount = 1, Margin = new Padding(0) };
            Color[] colors = { Color.FromArgb(166, 206, 57), Color.FromArgb(255, 215, 0), Color.FromArgb(0, 119, 200), Color.FromArgb(230, 0, 126) };
            for (int i = 0; i < 4; i++) { colourStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25)); colourStrip.Controls.Add(new Panel { Dock = DockStyle.Fill, Margin = new Padding(0), BackColor = colors[i] }, i, 0); }
            pnlBody = new Panel { Dock = DockStyle.Fill, Padding = new Padding(26), BackColor = Color.FromArgb(248, 250, 252) };
            Controls.Add(pnlBody); Controls.Add(pnlHeader); Controls.Add(colourStrip);
            var header = new Panel { Dock = DockStyle.Top, Height = 75 }; btnBack = new Button { Text = "← Back", Location = new Point(0, 0), Size = new Size(105, 34), FlatStyle = FlatStyle.Flat, BackColor = Color.White }; btnBack.Click += btnBack_Click; header.Controls.Add(btnBack); header.Controls.Add(new Label { Text = "Add New User", Font = new Font("Segoe UI", 19F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 75, 58), Location = new Point(0, 37), AutoSize = true });
            var bottom = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 62, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(0, 7, 8, 0) };
            btnSave = new Button { Text = "Create User", Width = 160, Height = 40, BackColor = Color.FromArgb(0, 119, 75), ForeColor = Color.White, FlatStyle = FlatStyle.Flat }; btnSave.Click += btnSave_Click; btnCancel = new Button { Text = "Cancel", Width = 115, Height = 40, BackColor = Color.White, FlatStyle = FlatStyle.Flat }; btnCancel.Click += btnCancel_Click; bottom.Controls.Add(btnSave); bottom.Controls.Add(btnCancel);
            var scroll = new Panel { Dock = DockStyle.Fill, AutoScroll = true }; var fieldsTable = new TableLayoutPanel { Dock = DockStyle.Top, ColumnCount = 2, RowCount = 11, AutoSize = true, Padding = new Padding(8), BackColor = Color.White }; fieldsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190)); fieldsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "First name *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 0);
            txtFirst = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtFirst, 1, 0);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Last name *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 1);
            txtLast = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtLast, 1, 1);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Email *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 2);
            txtEmail = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtEmail, 1, 2);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Phone", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 3);
            txtPhone = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtPhone, 1, 3);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Residential address", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 4);
            txtAddress = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtAddress, 1, 4);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Suburb", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 5);
            txtSuburb = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtSuburb, 1, 5);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "City", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 6);
            txtCity = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtCity, 1, 6);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Postal code", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 7);
            txtPostal = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtPostal, 1, 7);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Role *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 8);
            cmbRole = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(8, 10, 14, 10) };
            cmbRole.Items.AddRange(new object[] { "Citizen", "Admin" }); cmbRole.SelectedIndex = 0;
            fieldsTable.Controls.Add(cmbRole, 1, 8);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Password *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 9);
            txtPassword = new TextBox { Dock = DockStyle.Fill, UseSystemPasswordChar = true, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtPassword, 1, 9);
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.Controls.Add(new Label { Text = "Confirm password *", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) }, 0, 10);
            txtConfirm = new TextBox { Dock = DockStyle.Fill, UseSystemPasswordChar = true, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtConfirm, 1, 10);
            scroll.Controls.Add(fieldsTable); pnlBody.Controls.Add(scroll); pnlBody.Controls.Add(bottom); pnlBody.Controls.Add(header);
        }
    }
}
