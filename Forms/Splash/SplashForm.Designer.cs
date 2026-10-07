using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CityOfCapeTownMunicipalServices.Forms.Splash
{
    partial class SplashForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout;
        private Panel pnlImage;
        private Panel pnlOverlay;

        private PictureBox picBackground;
        private PictureBox picLogo;

        private Label lblCity;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblSlogan;

        private TableLayoutPanel colourStrip;

        private Timer splashTimer;

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

            mainLayout = new TableLayoutPanel();

            pnlImage = new Panel();
            pnlOverlay = new Panel();

            picBackground = new PictureBox();
            picLogo = new PictureBox();

            lblCity = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblSlogan = new Label();

            colourStrip = new TableLayoutPanel();

            splashTimer =
                new Timer(components);

            SuspendLayout();

            // ===============================
            // FORM
            // ===============================

            Text =
                "City of Cape Town – Municipal Services";

            BackColor = Color.White;

            ClientSize =
                new Size(1100, 720);

            MinimumSize =
                new Size(850, 550);

            StartPosition =
                FormStartPosition.CenterScreen;

            AutoScaleMode =
                AutoScaleMode.Dpi;

            // ===============================
            // MAIN
            // ===============================

            mainLayout.Dock = DockStyle.Fill;

            mainLayout.RowCount = 2;

            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    98F));

            mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    2F));

            Controls.Add(mainLayout);

            // ===============================
            // IMAGE PANEL
            // ===============================

            pnlImage.Dock = DockStyle.Fill;

            pnlImage.Padding =
                new Padding(0);

            mainLayout.Controls.Add(
                pnlImage,
                0,
                0);

            // Background

            picBackground.Dock =
                DockStyle.Fill;

            picBackground.SizeMode =
                PictureBoxSizeMode.Zoom;

            picBackground.BackColor =
                Color.FromArgb(225, 242, 252);

            // Add image through Resources:
            //
            picBackground.Image =
            Properties.Resources.cape_town_background;

            pnlImage.Controls.Add(
                picBackground);

            // ===============================
            // CONTENT OVERLAY
            // ===============================

            pnlOverlay.Width = 510;

            pnlOverlay.Dock =
                DockStyle.Left;

            pnlOverlay.Padding =
                new Padding(55, 45, 40, 40);

            pnlOverlay.BackColor =
                Color.FromArgb(235, 247, 253);

            pnlImage.Controls.Add(
                pnlOverlay);

            // ===============================
            // LOGO
            // ===============================

            picLogo.Location =
                new Point(55, 40);

            picLogo.Size =
                new Size(90, 90);

            picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            picLogo.Image =
            Properties.Resources.city_logo;

            pnlOverlay.Controls.Add(
                picLogo);

           

            // ===============================
            // TITLE
            // ===============================

            lblTitle.Text =
                "Together for a\nbetter Cape Town";

            lblTitle.Location =
                new Point(55, 190);

            lblTitle.Size =
                new Size(400, 100);

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    25F,
                    FontStyle.Bold);

            lblTitle.ForeColor =
                Color.FromArgb(0, 59, 113);

            pnlOverlay.Controls.Add(
                lblTitle);

            // ===============================
            // DESCRIPTION
            // ===============================

            lblDescription.Text =
                "Report issues. Build stronger\ncommunities.";

            lblDescription.Location =
                new Point(58, 300);

            lblDescription.Size =
                new Size(380, 70);

            lblDescription.Font =
                new Font(
                    "Segoe UI",
                    13F);

            lblDescription.ForeColor =
                Color.FromArgb(0, 59, 113);

            pnlOverlay.Controls.Add(
                lblDescription);

            // ===============================
            // SLOGAN
            // ===============================

            lblSlogan.Text =
                "Making progress possible.\nTogether.";

            lblSlogan.Anchor =
                AnchorStyles.Left |
                AnchorStyles.Bottom;

            lblSlogan.Location =
                new Point(
                    58,
                    590);

            lblSlogan.AutoSize = true;

            lblSlogan.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            lblSlogan.ForeColor =
                Color.FromArgb(0, 59, 113);

            pnlOverlay.Controls.Add(
                lblSlogan);

            // ===============================
            // COLOUR STRIP
            // ===============================

            colourStrip.Dock =
                DockStyle.Fill;

            colourStrip.ColumnCount = 4;

            colourStrip.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F));

            colourStrip.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F));

            colourStrip.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F));

            colourStrip.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    25F));

            AddColour(
                colourStrip,
                Color.FromArgb(166, 206, 57),
                0);

            AddColour(
                colourStrip,
                Color.FromArgb(255, 215, 0),
                1);

            AddColour(
                colourStrip,
                Color.FromArgb(0, 119, 200),
                2);

            AddColour(
                colourStrip,
                Color.FromArgb(230, 0, 126),
                3);

            mainLayout.Controls.Add(
                colourStrip,
                0,
                1);

            // ===============================
            // TIMER
            // ===============================

            splashTimer.Interval = 2500;

            splashTimer.Tick +=
                splashTimer_Tick;

            ResumeLayout(false);
        }

        private void AddColour(
            TableLayoutPanel table,
            Color colour,
            int column)
        {
            Panel panel = new Panel();

            panel.Dock =
                DockStyle.Fill;

            panel.BackColor =
                colour;

            panel.Margin =
                new Padding(0);

            table.Controls.Add(
                panel,
                column,
                0);
        }
    }
}