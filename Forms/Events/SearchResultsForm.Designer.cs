using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    partial class SearchResultsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderText;

        private TableLayoutPanel mainLayout;

        private Panel pnlTitle;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSearchInfo;

        private FlowLayoutPanel pnlResults;

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

            this.lblHeaderText =
                new Label();

            this.mainLayout =
                new TableLayoutPanel();

            this.pnlTitle =
                new Panel();

            this.lblIcon =
                new Label();

            this.lblTitle =
                new Label();

            this.lblSearchInfo =
                new Label();

            this.pnlResults =
                new FlowLayoutPanel();

            this.pnlBottom =
                new Panel();

            this.btnBack =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();


            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "Search Results";

            this.ClientSize =
                new Size(
                    1000,
                    720);

            this.MinimumSize =
                new Size(
                    800,
                    600);

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

            this.AutoScaleMode =
                AutoScaleMode.Dpi;


            // =====================================================
            // HEADER
            // =====================================================

            this.pnlHeader.Dock =
                DockStyle.Top;

            this.pnlHeader.Height =
                90;

            this.pnlHeader.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.picLogo.Location =
                new Point(
                    25,
                    10);

            this.picLogo.Size =
                new Size(
                    75,
                    68);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;


            this.lblHeaderText.Text =
                "Making progress possible.\nTogether.";

            this.lblHeaderText.Size =
                new Size(
                    250,
                    50);

            this.lblHeaderText.Location =
                new Point(
                    720,
                    20);

            this.lblHeaderText.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblHeaderText.ForeColor =
                Color.White;

            this.lblHeaderText.TextAlign =
                ContentAlignment.MiddleRight;


            this.pnlHeader.Controls.Add(
                this.picLogo);

            this.pnlHeader.Controls.Add(
                this.lblHeaderText);


            // =====================================================
            // MAIN
            // =====================================================

            this.mainLayout.Dock =
                DockStyle.Fill;

            this.mainLayout.Padding =
                new Padding(
                    45,
                    15,
                    45,
                    10);

            this.mainLayout.ColumnCount =
                1;

            this.mainLayout.RowCount =
                2;


            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    100F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));


            // =====================================================
            // TITLE
            // =====================================================

            this.pnlTitle.Dock =
                DockStyle.Fill;


            this.lblIcon.Text =
                "⌕";

            this.lblIcon.Location =
                new Point(
                    0,
                    10);

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
                "Search Results";

            this.lblTitle.Location =
                new Point(
                    75,
                    10);

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


            this.lblSearchInfo.Location =
                new Point(
                    77,
                    53);

            this.lblSearchInfo.Size =
                new Size(
                    760,
                    35);

            this.lblSearchInfo.ForeColor =
                Color.Gray;


            this.pnlTitle.Controls.Add(
                this.lblIcon);

            this.pnlTitle.Controls.Add(
                this.lblTitle);

            this.pnlTitle.Controls.Add(
                this.lblSearchInfo);


            // =====================================================
            // RESULTS
            // =====================================================

            this.pnlResults.Dock =
                DockStyle.Fill;

            this.pnlResults.AutoScroll =
                true;

            this.pnlResults.FlowDirection =
                FlowDirection.TopDown;

            this.pnlResults.WrapContents =
                false;

            this.pnlResults.Padding =
                new Padding(
                    0,
                    5,
                    5,
                    10);


            this.mainLayout.Controls.Add(
                this.pnlTitle,
                0,
                0);

            this.mainLayout.Controls.Add(
                this.pnlResults,
                0,
                1);


            // =====================================================
            // BOTTOM
            // =====================================================

            this.pnlBottom.Dock =
                DockStyle.Bottom;

            this.pnlBottom.Height =
                60;

            this.pnlBottom.BackColor =
                Color.White;


            this.btnBack.Text =
                "←  Back to Events";

            this.btnBack.Location =
                new Point(
                    45,
                    10);

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

            this.btnBack.Cursor =
                Cursors.Hand;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);


            this.pnlBottom.Controls.Add(
                this.btnBack);


            // =====================================================
            // STRIP
            // =====================================================

            this.colourStrip.Dock =
                DockStyle.Bottom;

            this.colourStrip.Height =
                10;

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
                this.mainLayout);

            this.Controls.Add(
                this.pnlBottom);

            this.Controls.Add(
                this.colourStrip);

            this.Controls.Add(
                this.pnlHeader);


            this.pnlHeader.BringToFront();

            this.pnlBottom.BringToFront();

            this.colourStrip.BringToFront();


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