using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    partial class EventDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;

        private Panel pnlContent;

        private Label lblIcon;
        private Label lblPageTitle;

        private Panel pnlHero;
        private Label lblHeroText;

        private Panel pnlInformation;

        private Label lblEventTitle;
        private Label lblCategory;

        private Label lblDate;
        private Label lblTime;
        private Label lblLocation;

        private Label lblDescriptionHeading;
        private Label lblDescription;

        private Panel pnlBottom;
        private Button btnBack;

        private TableLayoutPanel colourStrip;


        protected override void Dispose(
            bool disposing)
        {
            if (
                disposing &&
                components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.pnlHeader =
                new Panel();

            this.picLogo =
                new PictureBox();

            this.pnlContent =
                new Panel();

            this.lblIcon =
                new Label();

            this.lblPageTitle =
                new Label();

            this.pnlHero =
                new Panel();

            this.lblHeroText =
                new Label();

            this.pnlInformation =
                new Panel();

            this.lblEventTitle =
                new Label();

            this.lblCategory =
                new Label();

            this.lblDate =
                new Label();

            this.lblTime =
                new Label();

            this.lblLocation =
                new Label();

            this.lblDescriptionHeading =
                new Label();

            this.lblDescription =
                new Label();

            this.pnlBottom =
                new Panel();

            this.btnBack =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();


            this.SuspendLayout();


            this.Text =
                "Event Details";

            this.ClientSize =
                new Size(
                    1000,
                    720);

            this.MinimumSize =
                new Size(
                    850,
                    620);

            this.StartPosition =
                FormStartPosition.CenterParent;

            this.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);

            this.Font =
                new Font(
                    "Segoe UI",
                    9F);


            // HEADER

            this.pnlHeader.Dock =
                DockStyle.Top;

            this.pnlHeader.Height =
                95;

            this.pnlHeader.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.picLogo.Location =
                new Point(
                    25,
                    12);

            this.picLogo.Size =
                new Size(
                    75,
                    70);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;


            this.pnlHeader.Controls.Add(
                this.picLogo);


            // CONTENT

            this.pnlContent.Dock =
                DockStyle.Fill;

            this.pnlContent.AutoScroll =
                true;


            this.lblIcon.Text =
                "▣";

            this.lblIcon.Location =
                new Point(
                    45,
                    20);

            this.lblIcon.Size =
                new Size(
                    55,
                    55);

            this.lblIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblIcon.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.lblIcon.ForeColor =
                Color.White;

            this.lblIcon.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);


            this.lblPageTitle.Text =
                "Event Details";

            this.lblPageTitle.Location =
                new Point(
                    120,
                    28);

            this.lblPageTitle.AutoSize =
                true;

            this.lblPageTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblPageTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // HERO

            this.pnlHero.Location =
                new Point(
                    45,
                    95);

            this.pnlHero.Size =
                new Size(
                    910,
                    150);

            this.pnlHero.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlHero.BackColor =
                Color.FromArgb(
                    225,
                    241,
                    251);


            this.lblHeroText.Text =
                "CITY OF CAPE TOWN\nCOMMUNITY EVENT";

            this.lblHeroText.Dock =
                DockStyle.Fill;

            this.lblHeroText.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblHeroText.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblHeroText.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.pnlHero.Controls.Add(
                this.lblHeroText);


            // INFORMATION CARD

            this.pnlInformation.Location =
                new Point(
                    45,
                    265);

            this.pnlInformation.Size =
                new Size(
                    910,
                    300);

            this.pnlInformation.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlInformation.BackColor =
                Color.White;

            this.pnlInformation.BorderStyle =
                BorderStyle.FixedSingle;


            this.lblEventTitle.Location =
                new Point(
                    25,
                    20);

            this.lblEventTitle.Size =
                new Size(
                    650,
                    35);

            this.lblEventTitle.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            this.lblEventTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.lblCategory.Location =
                new Point(
                    700,
                    20);

            this.lblCategory.Size =
                new Size(
                    170,
                    30);

            this.lblCategory.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblCategory.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblCategory.BackColor =
                Color.FromArgb(
                    225,
                    241,
                    251);

            this.lblCategory.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);


            this.lblDate.Location =
                new Point(
                    25,
                    75);

            this.lblDate.Size =
                new Size(
                    300,
                    30);

            this.lblDate.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);


            this.lblTime.Location =
                new Point(
                    25,
                    115);

            this.lblTime.Size =
                new Size(
                    300,
                    30);


            this.lblLocation.Location =
                new Point(
                    430,
                    115);

            this.lblLocation.Size =
                new Size(
                    430,
                    30);


            this.lblDescriptionHeading.Text =
                "Description";

            this.lblDescriptionHeading.Location =
                new Point(
                    25,
                    170);

            this.lblDescriptionHeading.AutoSize =
                true;

            this.lblDescriptionHeading.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            this.lblDescriptionHeading.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.lblDescription.Location =
                new Point(
                    25,
                    205);

            this.lblDescription.Size =
                new Size(
                    835,
                    75);

            this.lblDescription.ForeColor =
                Color.FromArgb(
                    70,
                    85,
                    100);


            this.pnlInformation.Controls.Add(
                this.lblEventTitle);

            this.pnlInformation.Controls.Add(
                this.lblCategory);

            this.pnlInformation.Controls.Add(
                this.lblDate);

            this.pnlInformation.Controls.Add(
                this.lblTime);

            this.pnlInformation.Controls.Add(
                this.lblLocation);

            this.pnlInformation.Controls.Add(
                this.lblDescriptionHeading);

            this.pnlInformation.Controls.Add(
                this.lblDescription);


            this.pnlContent.Controls.Add(
                this.lblIcon);

            this.pnlContent.Controls.Add(
                this.lblPageTitle);

            this.pnlContent.Controls.Add(
                this.pnlHero);

            this.pnlContent.Controls.Add(
                this.pnlInformation);


            // BOTTOM

            this.pnlBottom.Dock =
                DockStyle.Bottom;

            this.pnlBottom.Height =
                65;

            this.pnlBottom.BackColor =
                Color.White;


            this.btnBack.Text =
                "←  Back";

            this.btnBack.Location =
                new Point(
                    45,
                    12);

            this.btnBack.Size =
                new Size(
                    150,
                    40);

            this.btnBack.BackColor =
                Color.White;

            this.btnBack.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnBack.FlatStyle =
                FlatStyle.Flat;

            this.btnBack.FlatAppearance.BorderColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);


            this.pnlBottom.Controls.Add(
                this.btnBack);


            // STRIP

            this.colourStrip.Dock =
                DockStyle.Bottom;

            this.colourStrip.Height =
                12;

            this.colourStrip.ColumnCount =
                4;

            this.colourStrip.RowCount =
                1;


            for (int i = 0; i < 4; i++)
            {
                this.colourStrip.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        25F));
            }


            AddColour(
                Color.FromArgb(
                    166,
                    206,
                    57),
                0);

            AddColour(
                Color.FromArgb(
                    255,
                    215,
                    0),
                1);

            AddColour(
                Color.FromArgb(
                    0,
                    119,
                    200),
                2);

            AddColour(
                Color.FromArgb(
                    230,
                    0,
                    126),
                3);


            this.Controls.Add(
                this.pnlContent);

            this.Controls.Add(
                this.pnlBottom);

            this.Controls.Add(
                this.colourStrip);

            this.Controls.Add(
                this.pnlHeader);


            this.ResumeLayout(false);
        }


        private void AddColour(
            Color colour,
            int column)
        {
            Panel panel =
                new Panel();

            panel.Dock =
                DockStyle.Fill;

            panel.Margin =
                new Padding(0);

            panel.BackColor =
                colour;

            this.colourStrip.Controls.Add(
                panel,
                column,
                0);
        }
    }
}