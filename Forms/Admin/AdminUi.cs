using System;
using System.Drawing;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Models;
using CityOfCapeTownMunicipalServices.Services;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    internal static class AdminUi
    {
        internal static readonly Color Green = Color.FromArgb(0, 119, 75);
        internal static readonly Color Dark = Color.FromArgb(0, 75, 58);
        internal static readonly Color Blue = Color.FromArgb(0, 119, 200);
        internal static void RequireAdmin(Form form)
        {
            if (UserSession.CurrentUser == null || UserSession.CurrentUser.Role != UserRole.Admin)
            { MessageBox.Show("Administrator access required.", "Access denied"); form.BeginInvoke(new Action(form.Close)); }
        }
        internal static Form Make(string title, string subtitle, out Panel body)
        {
            Form f = new Form
            {
                Text = title + " - City of Cape Town",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(1130, 730),
                MinimumSize = new Size(850, 600),
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            Panel header = new Panel { Dock = DockStyle.Top, Height = 112, BackColor = Green };
            PictureBox logo = new PictureBox
            {
                Image = Properties.Resources.city_logo,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(22, 18),
                Size = new Size(72, 72)
            }; header.Controls.Add(logo);
            Label brand = new Label
            {
                Text = "CITY OF CAPE TOWN\nISIXEKO SASEKAPA\nSTAD KAAPSTAD",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(103, 23),
                Size = new Size(190, 65)
            }; header.Controls.Add(brand);
            Label heading = new Label
            {
                Text = "Municipal Services - Admin Portal",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 19, FontStyle.Bold),
                Location = new Point(320, 19),
                Size = new Size(650, 43)
            }; header.Controls.Add(heading);
            Label sub = new Label { Text = subtitle, ForeColor = Color.White, Location = new Point(324, 67), Size = new Size(680, 28) }; header.Controls.Add(sub);
            TableLayoutPanel strip = new TableLayoutPanel { Dock = DockStyle.Bottom, Height = 12, ColumnCount = 4, Margin = new Padding(0) };
            Color[] colors = { Color.FromArgb(166, 206, 57), Color.FromArgb(255, 215, 0), Blue, Color.FromArgb(230, 0, 126) };
            for (int i = 0; i < 4; i++) { strip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25)); strip.Controls.Add(new Panel { Dock = DockStyle.Fill, Margin = new Padding(0), BackColor = colors[i] }, i, 0); }
            body = new Panel { Dock = DockStyle.Fill, Padding = new Padding(28, 24, 28, 22), BackColor = Color.FromArgb(248, 250, 252) };
            f.Controls.Add(body); f.Controls.Add(header); f.Controls.Add(strip);
            return f;
        }
        internal static Label Title(string text) { return new Label { Text = text, Font = new Font("Segoe UI", 21, FontStyle.Bold), ForeColor = Dark, AutoSize = true, Margin = new Padding(0, 0, 0, 8) }; }
        internal static Button Button(string text, EventHandler action, bool green = true)
        {
            Button b = new Button
            {
                Text = text,
                Height = 39,
                Width = 145,
                BackColor = green ? Green : Color.White,
                ForeColor = green ? Color.White : Dark,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(5)
            };
            b.FlatAppearance.BorderColor = Green; b.Click += action; return b;
        }
        internal static TextBox Input(int width = 240) { return new TextBox { Width = width, Font = new Font("Segoe UI", 10), Margin = new Padding(4, 7, 12, 7) }; }
        internal static ComboBox Combo(params string[] items) { ComboBox c = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 170, Margin = new Padding(5, 7, 12, 7) }; c.Items.AddRange(items); c.SelectedIndex = 0; return c; }
        internal static DataGridView Grid()
        {
            return new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                RowHeadersVisible = false,
                RowTemplate = { Height = 33 },
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 38,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            };
        }
        internal static TableLayoutPanel Layout(Panel body, string title, string subtitle, Control toolbar, DataGridView grid)
        {
            TableLayoutPanel layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 4 };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49)); layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65)); layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(Title(title), 0, 0); layout.Controls.Add(new Label { Text = subtitle, AutoSize = true, ForeColor = Color.DimGray }, 0, 1);
            toolbar.Dock = DockStyle.Fill; layout.Controls.Add(toolbar, 0, 2); layout.Controls.Add(grid, 0, 3); body.Controls.Add(layout); return layout;
        }
        internal static FlowLayoutPanel Bar() { return new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false, AutoScroll = true, FlowDirection = FlowDirection.LeftToRight }; }
        internal static bool Confirm(string message) { return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes; }
        internal static void Secure(Form f) { f.Shown += (s, e) => RequireAdmin(f); }
        internal static void AddRow(FlowLayoutPanel panel, string caption, Control input)
        { panel.Controls.Add(new Label { Text = caption, AutoSize = true, Margin = new Padding(6, 14, 3, 0) }); panel.Controls.Add(input); }
        internal static void AddField(TableLayoutPanel table, int row, string caption, Control input)
        { table.RowCount = Math.Max(table.RowCount, row + 1); table.RowStyles.Add(new RowStyle(SizeType.Absolute, input is TextBox && ((TextBox)input).Multiline ? 94 : 48)); table.Controls.Add(new Label { Text = caption, TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, row); input.Dock = DockStyle.Fill; input.Margin = new Padding(3, 6, 3, 6); table.Controls.Add(input, 1, row); }
        internal static Form Editor(string title, TableLayoutPanel fields)
        {
            Form f = new Form { Text = title, ClientSize = new Size(600, Math.Min(760, fields.RowCount * 48 + 115)), MinimumSize = new Size(540, 450), StartPosition = FormStartPosition.CenterParent, Font = new Font("Segoe UI", 10), BackColor = Color.White };
            Panel top = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Green }; top.Controls.Add(new Label { Text = title, ForeColor = Color.White, Font = new Font("Segoe UI", 16, FontStyle.Bold), Dock = DockStyle.Fill, Padding = new Padding(18, 12, 0, 0) });
            Panel host = new Panel { Dock = DockStyle.Fill, AutoScroll = true, Padding = new Padding(20) }; fields.Dock = DockStyle.Top; fields.AutoSize = true; host.Controls.Add(fields); f.Controls.Add(host); f.Controls.Add(top); return f;
        }
        internal static TableLayoutPanel Fields() { var t = new TableLayoutPanel { ColumnCount = 2, RowCount = 0, AutoSize = true, Padding = new Padding(8) }; t.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180)); t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); return t; }
    }
}
