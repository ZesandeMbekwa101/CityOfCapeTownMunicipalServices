using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Home
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components;

        private Panel pnlHeader;

        private PictureBox picLogo;

        private Label lblBrand;
        private Label lblSlogan;

        private Button btnSignOut;

        private Panel pnlContent;

        private Label lblWelcome;
        private Label lblQuestion;

        private Button btnReportIssue;
        private Button btnEvents;
        private Button btnStatus;

        private Label lblReportDescription;
        private Label lblEventsDescription;
        private Label lblStatusDescription;

        private PictureBox picSkyline;

        private TableLayoutPanel colourStrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            pnlHeader = new Panel();

            picLogo = new PictureBox();

            lblBrand = new Label();
            lblSlogan = new Label();

            btnSignOut = new Button();

            pnlContent = new Panel();

            lblWelcome = new Label();
            lblQuestion = new Label();

            btnReportIssue = new Button();
            btnEvents = new Button();
            btnStatus = new Button();

            lblReportDescription = new Label();
            lblEventsDescription = new Label();
            lblStatusDescription = new Label();

            picSkyline = new PictureBox();

            colourStrip =
                new TableLayoutPanel();

            SuspendLayout();

            // ============================
            // FORM
            // ============================

            Text =
                "City of Cape Town – Municipal Services";

            ClientSize =
                new Size(1050, 720);

            MinimumSize =
                new Size(850, 600);

            StartPosition =
                FormStartPosition.CenterScreen;

            BackColor =
                Color.White;

            AutoScaleMode =
                AutoScaleMode.Dpi;

            // ============================
            // HEADER
            // ============================

            pnlHeader.Dock =
                DockStyle.Top;

            pnlHeader.Height = 100;

            pnlHeader.BackColor =
                Color.FromArgb(0, 59, 113);

            Controls.Add(pnlHeader);

            picLogo.Location =
                new Point(30, 15);

            picLogo.Size =
                new Size(70, 70);

            picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            picLogo.Image =
            Properties.Resources.city_logo;

            pnlHeader.Controls.Add(
                picLogo);

            

            pnlHeader.Controls.Add(
                lblBrand);

            lblSlogan.Text =
                "Making progress possible.\nTogether.";

            lblSlogan.ForeColor =
                Color.White;

            lblSlogan.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Italic);

            lblSlogan.AutoSize = true;

            lblSlogan.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            lblSlogan.Location =
                new Point(680, 30);

            pnlHeader.Controls.Add(
                lblSlogan);

            // SIGN OUT

            btnSignOut.Text =
                "Sign Out";

            btnSignOut.Size =
                new Size(110, 42);

            btnSignOut.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            btnSignOut.Location =
                new Point(900, 29);

            btnSignOut.FlatStyle =
                FlatStyle.Flat;

            btnSignOut.FlatAppearance.BorderColor =
                Color.White;

            btnSignOut.ForeColor =
                Color.White;

            btnSignOut.BackColor =
                Color.FromArgb(0, 59, 113);

            btnSignOut.Cursor =
                Cursors.Hand;

            btnSignOut.Click +=
                btnSignOut_Click;

            pnlHeader.Controls.Add(
                btnSignOut);

            // ============================
            // CONTENT
            // ============================

            pnlContent.Dock =
                DockStyle.Fill;

            pnlContent.AutoScroll = true;

            pnlContent.Padding =
                new Padding(50);

            Controls.Add(
                pnlContent);

            pnlContent.BringToFront();

            // WELCOME

            lblWelcome.Text =
                "Welcome!";

            lblWelcome.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            lblWelcome.ForeColor =
                Color.FromArgb(0, 59, 113);

            lblWelcome.Location =
                new Point(55, 35);

            lblWelcome.AutoSize = true;

            pnlContent.Controls.Add(
                lblWelcome);

            lblQuestion.Text =
                "How can we assist you today?";

            lblQuestion.Font =
                new Font(
                    "Segoe UI",
                    13F);

            lblQuestion.ForeColor =
                Color.FromArgb(0, 59, 113);

            lblQuestion.Location =
                new Point(58, 80);

            lblQuestion.AutoSize = true;

            pnlContent.Controls.Add(
                lblQuestion);

            // ============================
            // REPORT ISSUE
            // ============================

            btnReportIssue.Text =
                "     📝   Report Issue";

            btnReportIssue.TextAlign =
                ContentAlignment.MiddleLeft;

            btnReportIssue.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            btnReportIssue.ForeColor =
                Color.White;

            btnReportIssue.BackColor =
                Color.FromArgb(0, 119, 200);

            btnReportIssue.FlatStyle =
                FlatStyle.Flat;

            btnReportIssue.FlatAppearance.BorderSize =
                0;

            btnReportIssue.Location =
                new Point(55, 135);

            btnReportIssue.Size =
                new Size(900, 75);

            btnReportIssue.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            btnReportIssue.Cursor =
                Cursors.Hand;

            pnlContent.Controls.Add(
                btnReportIssue);

            lblReportDescription.Text =
                "Let us know about a problem in your community.";

            lblReportDescription.ForeColor =
                Color.White;

            lblReportDescription.BackColor =
                Color.FromArgb(0, 119, 200);

            lblReportDescription.Location =
                new Point(135, 180);

            lblReportDescription.AutoSize = true;

            pnlContent.Controls.Add(
                lblReportDescription);
            this.btnReportIssue.Click +=
    new System.EventHandler(
        this.btnReportIssue_Click);

            lblReportDescription.BringToFront();

            // ============================
            // EVENTS
            // ============================

            btnEvents.Text =
                "     📅   Local Events and Announcements        🔒";

            btnEvents.TextAlign =
                ContentAlignment.MiddleLeft;

            btnEvents.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            btnEvents.ForeColor =
                Color.FromArgb(100, 115, 130);

            btnEvents.BackColor =
                Color.FromArgb(240, 243, 245);

            btnEvents.FlatStyle =
                FlatStyle.Flat;

            btnEvents.FlatAppearance.BorderSize =
                0;

            btnEvents.Location =
                new Point(55, 225);

            btnEvents.Size =
                new Size(900, 75);

            btnEvents.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            btnEvents.Enabled = false;

            pnlContent.Controls.Add(
                btnEvents);

            lblEventsDescription.Text =
                "Stay informed about events and important updates.";

            lblEventsDescription.ForeColor =
                Color.Gray;

            lblEventsDescription.BackColor =
                Color.FromArgb(240, 243, 245);

            lblEventsDescription.Location =
                new Point(135, 270);

            lblEventsDescription.AutoSize = true;

            pnlContent.Controls.Add(
                lblEventsDescription);

            lblEventsDescription.BringToFront();

            // ============================
            // SERVICE STATUS
            // ============================

            btnStatus.Text =
                "     📄   Service Request Status                 🔒";

            btnStatus.TextAlign =
                ContentAlignment.MiddleLeft;

            btnStatus.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            btnStatus.ForeColor =
                Color.FromArgb(100, 115, 130);

            btnStatus.BackColor =
                Color.FromArgb(240, 243, 245);

            btnStatus.FlatStyle =
                FlatStyle.Flat;

            btnStatus.FlatAppearance.BorderSize =
                0;

            btnStatus.Location =
                new Point(55, 315);

            btnStatus.Size =
                new Size(900, 75);

            btnStatus.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            btnStatus.Enabled = false;

            pnlContent.Controls.Add(
                btnStatus);

            lblStatusDescription.Text =
                "Check the status of your service request.";

            lblStatusDescription.ForeColor =
                Color.Gray;

            lblStatusDescription.BackColor =
                Color.FromArgb(240, 243, 245);

            lblStatusDescription.Location =
                new Point(135, 360);

            lblStatusDescription.AutoSize = true;

            pnlContent.Controls.Add(
                lblStatusDescription);

            lblStatusDescription.BringToFront();

            // ============================
            // SKYLINE
            // ============================

            picSkyline.Location =
                new Point(55, 420);

            picSkyline.Size =
                new Size(900, 130);

            picSkyline.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            picSkyline.SizeMode =
                PictureBoxSizeMode.Zoom;

            picSkyline.Image =
            Properties.Resources.cape_town_skyline;

            pnlContent.Controls.Add(
                picSkyline);

            // ============================
            // COLOUR STRIP
            // ============================

            colourStrip.Dock =
                DockStyle.Bottom;

            colourStrip.Height = 12;

            colourStrip.ColumnCount = 4;

            for (int i = 0; i < 4; i++)
            {
                colourStrip.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        25F));
            }

            AddColour(
                Color.FromArgb(166, 206, 57),
                0);

            AddColour(
                Color.FromArgb(255, 215, 0),
                1);

            AddColour(
                Color.FromArgb(0, 119, 200),
                2);

            AddColour(
                Color.FromArgb(230, 0, 126),
                3);

            Controls.Add(
                colourStrip);

            ResumeLayout(false);
        }

        private void AddColour(
            Color colour,
            int column)
        {
            Panel panel = new Panel();

            panel.Dock =
                DockStyle.Fill;

            panel.Margin =
                new Padding(0);

            panel.BackColor =
                colour;

            colourStrip.Controls.Add(
                panel,
                column,
                0);
        }
    }
}