using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    partial class RecommendedEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;

        private Panel pnlContent;

        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;

        private FlowLayoutPanel pnlRecommendations;

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

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.pnlRecommendations =
                new FlowLayoutPanel();

            this.pnlBottom =
                new Panel();

            this.btnBack =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();


            this.SuspendLayout();


            this.Text =
                "Recommended for You";

            this.ClientSize =
                new Size(
                    1050,
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


            this.lblIcon.Text =
                "★";

            this.lblIcon.Location =
                new Point(
                    45,
                    25);

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


            this.lblTitle.Text =
                "Recommended for You";

            this.lblTitle.Location =
                new Point(
                    120,
                    25);

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.lblSubtitle.Text =
                "Based on your recent searches, interests and viewed events.";

            this.lblSubtitle.Location =
                new Point(
                    123,
                    62);

            this.lblSubtitle.Size =
                new Size(
                    800,
                    25);

            this.lblSubtitle.ForeColor =
                Color.Gray;


            this.pnlRecommendations.Location =
                new Point(
                    45,
                    115);

            this.pnlRecommendations.Size =
                new Size(
                    960,
                    465);

            this.pnlRecommendations.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlRecommendations.AutoScroll =
                true;

            this.pnlRecommendations.FlowDirection =
                FlowDirection.LeftToRight;

            this.pnlRecommendations.WrapContents =
                true;


            this.pnlContent.Controls.Add(
                this.lblIcon);

            this.pnlContent.Controls.Add(
                this.lblTitle);

            this.pnlContent.Controls.Add(
                this.lblSubtitle);

            this.pnlContent.Controls.Add(
                this.pnlRecommendations);


            // BOTTOM

            this.pnlBottom.Dock =
                DockStyle.Bottom;

            this.pnlBottom.Height =
                65;

            this.pnlBottom.BackColor =
                Color.White;


            this.btnBack.Text =
                "←  Back to Events";

            this.btnBack.Location =
                new Point(
                    45,
                    12);

            this.btnBack.Size =
                new Size(
                    180,
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