using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    partial class AdminHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblBrand;
        private Label lblSlogan;
        private Label lblPortal;
        private Label lblPortalSubtitle;
        private Button btnSignOut;
        private Panel pnlContent;
        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblQuestion;
        private TableLayoutPanel tblCards;
        private PictureBox picSkyline;
        private TableLayoutPanel colourStrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            lblBrand = new Label();
            lblSlogan = new Label();
            lblPortal = new Label();
            lblPortalSubtitle = new Label();
            btnSignOut = new Button();
            pnlContent = new Panel();
            tblMain = new TableLayoutPanel();
            lblWelcome = new Label();
            lblQuestion = new Label();
            tblCards = new TableLayoutPanel();
            picSkyline = new PictureBox();
            colourStrip = new TableLayoutPanel();

            SuspendLayout();
            Text = "City of Cape Town - Municipal Services Admin Portal";
            ClientSize = new Size(1150, 760);
            MinimumSize = new Size(920, 670);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);
            AutoScaleMode = AutoScaleMode.Dpi;

            // Bottom municipal colour strip
            colourStrip.Dock = DockStyle.Bottom;
            colourStrip.Height = 12;
            colourStrip.Margin = new Padding(0);
            colourStrip.RowCount = 1;
            colourStrip.ColumnCount = 4;
            for (int i = 0; i < 4; i++)
                colourStrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AddColour(Color.FromArgb(166, 206, 57), 0);
            AddColour(Color.FromArgb(255, 215, 0), 1);
            AddColour(Color.FromArgb(0, 119, 200), 2);
            AddColour(Color.FromArgb(230, 0, 126), 3);

            // Green header
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 115;
            pnlHeader.BackColor = Color.FromArgb(0, 119, 75);

            picLogo.Image = Properties.Resources.city_logo;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Location = new Point(24, 21);
            picLogo.Size = new Size(75, 75);
            pnlHeader.Controls.Add(picLogo);

            lblBrand.Text = "CITY OF CAPE TOWN\nISIXEKO SASEKAPA\nSTAD KAAPSTAD";
            lblBrand.ForeColor = Color.White;
            lblBrand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrand.Location = new Point(110, 23);
            lblBrand.Size = new Size(188, 70);
            pnlHeader.Controls.Add(lblBrand);

            Panel divider = new Panel();
            divider.BackColor = Color.FromArgb(150, 210, 180);
            divider.Location = new Point(305, 22);
            divider.Size = new Size(2, 70);
            pnlHeader.Controls.Add(divider);

            lblPortal.Text = "Municipal Services - Admin Portal";
            lblPortal.ForeColor = Color.White;
            lblPortal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPortal.Location = new Point(330, 20);
            lblPortal.Size = new Size(560, 39);
            pnlHeader.Controls.Add(lblPortal);

            lblPortalSubtitle.Text = "Manage service requests, events, announcements and users.";
            lblPortalSubtitle.ForeColor = Color.FromArgb(226, 247, 234);
            lblPortalSubtitle.Font = new Font("Segoe UI", 10F);
            lblPortalSubtitle.Location = new Point(333, 65);
            lblPortalSubtitle.Size = new Size(555, 27);
            pnlHeader.Controls.Add(lblPortalSubtitle);

            lblSlogan.Text = "Making progress possible.\nTogether.";
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSlogan.TextAlign = ContentAlignment.MiddleRight;
            lblSlogan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSlogan.Location = new Point(810, 17);
            lblSlogan.Size = new Size(180, 42);
            pnlHeader.Controls.Add(lblSlogan);

            btnSignOut.Text = "Sign Out";
            btnSignOut.ForeColor = Color.White;
            btnSignOut.BackColor = Color.FromArgb(0, 119, 75);
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.FlatAppearance.BorderColor = Color.White;
            btnSignOut.FlatAppearance.BorderSize = 1;
            btnSignOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignOut.Cursor = Cursors.Hand;
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.Location = new Point(1005, 39);
            btnSignOut.Size = new Size(120, 40);
            btnSignOut.Click += btnSignOut_Click;
            pnlHeader.Controls.Add(btnSignOut);
            pnlHeader.Resize += (s, e) =>
            {
                btnSignOut.Left = pnlHeader.ClientSize.Width - btnSignOut.Width - 25;
                lblSlogan.Left = btnSignOut.Left - lblSlogan.Width - 14;
            };

            // Scrollable body with fixed-width content
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.White;
            pnlContent.AutoScroll = true;
            pnlContent.Padding = new Padding(34, 28, 34, 15);

            tblMain.Dock = DockStyle.Top;
            tblMain.AutoSize = true;
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.ColumnCount = 1;
            tblMain.RowCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            pnlContent.Controls.Add(tblMain);

            lblWelcome.Text = "Welcome, Admin!";
            lblWelcome.ForeColor = Color.FromArgb(0, 75, 58);
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            tblMain.Controls.Add(lblWelcome, 0, 0);

            lblQuestion.Text = "What would you like to manage today?";
            lblQuestion.ForeColor = Color.FromArgb(60, 83, 105);
            lblQuestion.Font = new Font("Segoe UI", 12F);
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.TextAlign = ContentAlignment.TopLeft;
            tblMain.Controls.Add(lblQuestion, 0, 1);

            tblCards.Dock = DockStyle.Fill;
            tblCards.ColumnCount = 3;
            tblCards.RowCount = 2;
            tblCards.Margin = new Padding(0);
            for (int i = 0; i < 3; i++)
                tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblCards, 0, 2);

            AddCard("Service Requests", "View and manage residents'\nsubmitted service requests.",
                "SR", Color.FromArgb(235, 246, 255), Color.FromArgb(0, 119, 200), 0, 0);
            AddCard("Events", "Add, edit and manage\nlocal community events.",
                "EV", Color.FromArgb(237, 249, 237), Color.FromArgb(0, 135, 76), 1, 0);
            AddCard("Announcements", "Create and update\nmunicipal announcements.",
                "AN", Color.FromArgb(255, 249, 229), Color.FromArgb(161, 111, 0), 2, 0);
            AddCard("Users", "View registered residents\nand administrator accounts.",
                "US", Color.FromArgb(255, 238, 238), Color.FromArgb(180, 40, 40), 0, 1);
            AddCard("Resources", "Manage helpful contacts\nand municipal information.",
                "RE", Color.FromArgb(244, 238, 255), Color.FromArgb(95, 65, 170), 1, 1);
            AddCard("Settings", "Manage application settings\nand issue categories.",
                "SE", Color.FromArgb(237, 243, 247), Color.FromArgb(45, 72, 95), 2, 1);

            picSkyline.Image = Properties.Resources.cape_town_skyline;
            picSkyline.SizeMode = PictureBoxSizeMode.Zoom;
            picSkyline.Dock = DockStyle.Fill;
            picSkyline.Margin = new Padding(0, 12, 0, 0);
            tblMain.Controls.Add(picSkyline, 0, 3);

            // Dock order: fill first, then top and bottom
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(colourStrip);
            pnlHeader.BringToFront();
            colourStrip.BringToFront();
            ResumeLayout(false);

            // Adjust table width when the form changes size.
            pnlContent.Resize += (s, e) =>
            {
                tblMain.Width = Math.Max(810, pnlContent.ClientSize.Width -
                    pnlContent.Padding.Left - pnlContent.Padding.Right);
            };
            tblMain.Width = 1080;
        }

        private void AddCard(string title, string description, string initials,
            Color background, Color accent, int column, int row)
        {
            Panel card = new Panel();
            card.Dock = DockStyle.Fill;
            card.Margin = new Padding(7);
            card.BackColor = background;
            card.Padding = new Padding(12);
            card.BorderStyle = BorderStyle.FixedSingle;

            Label iconLabel = new Label();
            iconLabel.Text = initials;
            iconLabel.ForeColor = Color.White;
            iconLabel.BackColor = accent;
            iconLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;
            iconLabel.Location = new Point(15, 24);
            iconLabel.Size = new Size(55, 58);
            card.Controls.Add(iconLabel);

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(16, 37, 61);
            titleLabel.Location = new Point(85, 18);
            titleLabel.Size = new Size(225, 30);
            card.Controls.Add(titleLabel);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = description;
            descriptionLabel.Font = new Font("Segoe UI", 9.5F);
            descriptionLabel.ForeColor = Color.FromArgb(65, 84, 105);
            descriptionLabel.Location = new Point(86, 51);
            descriptionLabel.Size = new Size(225, 51);
            card.Controls.Add(descriptionLabel);

            Button openButton = new Button();
            openButton.Text = "Open  >";
            openButton.Tag = title;
            openButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            openButton.ForeColor = accent;
            openButton.BackColor = background;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.FlatAppearance.BorderColor = accent;
            openButton.Cursor = Cursors.Hand;
            openButton.Size = new Size(84, 29);
            openButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            openButton.Click += AdminResource_Click;
            card.Controls.Add(openButton);
            card.Resize += (s, e) =>
            {
                openButton.Location = new Point(card.ClientSize.Width - openButton.Width - 12,
                    card.ClientSize.Height - openButton.Height - 9);
                titleLabel.Width = Math.Max(130, card.ClientSize.Width - 100);
                descriptionLabel.Width = Math.Max(130, card.ClientSize.Width - 100);
            };
            tblCards.Controls.Add(card, column, row);
        }

        private void AddColour(Color colour, int column)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(0);
            panel.BackColor = colour;
            colourStrip.Controls.Add(panel, column, 0);
        }
    }
}
