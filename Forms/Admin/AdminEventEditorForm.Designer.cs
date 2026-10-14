using System;
using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    partial class AdminEventEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader, pnlBody;
        private PictureBox picLogo;
        private Label lblBrand, lblPortal, lblSubtitle, lblEditorTitle;
        private TableLayoutPanel colourStrip;
        private Button btnBack, btnSave, btnCancel;
        private TextBox txtTitle, txtLocation, txtDescription;
        private ComboBox cmbCategory;
        private DateTimePicker dtStart, dtEnd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Text = "Event / Announcement - City of Cape Town";
            ClientSize = new Size(950, 750);
            MinimumSize = new Size(860, 590);
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.White;
            AutoScaleMode = AutoScaleMode.Dpi;
            pnlHeader = new Panel { Dock = DockStyle.Top, Height = 112, BackColor = Color.FromArgb(0, 119, 75) };
            picLogo = new PictureBox { Image = Properties.Resources.city_logo, SizeMode = PictureBoxSizeMode.Zoom, Location = new Point(22, 17), Size = new Size(74, 74) };
            lblBrand = new Label { Text = "CITY OF CAPE TOWN\nISIXEKO SASEKAPA\nSTAD KAAPSTAD", ForeColor = Color.White, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(104, 24), Size = new Size(195, 68) };
            lblPortal = new Label { Text = "Municipal Services - Admin Portal", ForeColor = Color.White, Font = new Font("Segoe UI", 19F, FontStyle.Bold), Location = new Point(318, 19), Size = new Size(610, 43) };
            lblSubtitle = new Label { Text = "Create or edit a municipal item.", ForeColor = Color.White, Location = new Point(320, 66), Size = new Size(610, 27) };
            pnlHeader.Controls.AddRange(new Control[] { picLogo, lblBrand, lblPortal, lblSubtitle });
            colourStrip = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 12, ColumnCount = 4, RowCount = 1, Margin = new Padding(0) };
            Color[] colors = { Color.FromArgb(166, 206, 57), Color.FromArgb(255, 215, 0), Color.FromArgb(0, 119, 200), Color.FromArgb(230, 0, 126) };
            for (int i = 0; i < 4; i++)
            {
                colourStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                colourStrip.Controls.Add(new Panel { Dock = DockStyle.Fill, Margin = new Padding(0), BackColor = colors[i] }, i, 0);
            }
            pnlBody = new Panel { Dock = DockStyle.Fill, Padding = new Padding(26), BackColor = Color.FromArgb(248, 250, 252) };
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(colourStrip);
            Panel header = new Panel { Dock = DockStyle.Top, Height = 75 };
            btnBack = new Button { Text = "← Back", Location = new Point(0, 0), Size = new Size(105, 34), FlatStyle = FlatStyle.Flat, BackColor = Color.White };
            btnBack.Click += btnBack_Click;
            header.Controls.Add(btnBack);
            lblEditorTitle = new Label { Text = "Event / Announcement", Font = new Font("Segoe UI", 19F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 75, 58), Location = new Point(0, 37), AutoSize = true };
            header.Controls.Add(lblEditorTitle);
            FlowLayoutPanel bottom = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 62, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(0, 7, 8, 0) };
            btnSave = new Button { Text = "Save Item", Width = 160, Height = 40, BackColor = Color.FromArgb(0, 119, 75), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnSave.Click += btnSave_Click;
            btnCancel = new Button { Text = "Cancel", Width = 115, Height = 40, BackColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnCancel.Click += btnCancel_Click;
            bottom.Controls.Add(btnSave);
            bottom.Controls.Add(btnCancel);
            Panel scroll = new Panel { Dock = DockStyle.Fill, AutoScroll = true };
            TableLayoutPanel fieldsTable = new TableLayoutPanel { Dock = DockStyle.Top, ColumnCount = 2, RowCount = 6, AutoSize = true, Padding = new Padding(8), BackColor = Color.White };
            fieldsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190));
            fieldsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            for (int i = 0; i < 5; i++) fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 110));
            fieldsTable.Controls.Add(FieldLabel("Title *"), 0, 0);
            txtTitle = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtTitle, 1, 0);
            fieldsTable.Controls.Add(FieldLabel("Category *"), 0, 1);
            cmbCategory = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(cmbCategory, 1, 1);
            fieldsTable.Controls.Add(FieldLabel("Location *"), 0, 2);
            txtLocation = new TextBox { Dock = DockStyle.Fill, Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(txtLocation, 1, 2);
            fieldsTable.Controls.Add(FieldLabel("Start date and time *"), 0, 3);
            dtStart = new DateTimePicker { Dock = DockStyle.Fill, Format = DateTimePickerFormat.Custom, CustomFormat = "dd MMM yyyy HH:mm", Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(dtStart, 1, 3);
            fieldsTable.Controls.Add(FieldLabel("End date and time *"), 0, 4);
            dtEnd = new DateTimePicker { Dock = DockStyle.Fill, Format = DateTimePickerFormat.Custom, CustomFormat = "dd MMM yyyy HH:mm", Margin = new Padding(8, 10, 14, 10) };
            fieldsTable.Controls.Add(dtEnd, 1, 4);
            fieldsTable.Controls.Add(FieldLabel("Description *"), 0, 5);
            txtDescription = new TextBox { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical, Margin = new Padding(8, 8, 14, 8) };
            fieldsTable.Controls.Add(txtDescription, 1, 5);
            scroll.Controls.Add(fieldsTable);
            pnlBody.Controls.Add(scroll);
            pnlBody.Controls.Add(bottom);
            pnlBody.Controls.Add(header);
        }

        private Label FieldLabel(string value)
        {
            return new Label { Text = value, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0) };
        }
    }
}
