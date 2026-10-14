using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Events
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderText;

        private TableLayoutPanel mainLayout;

        private Panel pnlTitleArea;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblInformation;

        private TableLayoutPanel pnlSearch;
        private TextBox txtSearch;
        private Button btnSearch;

        private FlowLayoutPanel pnlCategories;

        private Button btnAll;
        private Button btnCommunity;
        private Button btnEnvironment;
        private Button btnSafety;
        private Button btnHealth;
        private Button btnEducation;

        private TableLayoutPanel pnlSectionHeader;
        private Label lblUpcoming;
        private Button btnRecommended;

        private FlowLayoutPanel pnlEvents;

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

            this.pnlTitleArea =
                new Panel();

            this.lblIcon =
                new Label();

            this.lblTitle =
                new Label();

            this.lblInformation =
                new Label();

            this.pnlSearch =
                new TableLayoutPanel();

            this.txtSearch =
                new TextBox();

            this.btnSearch =
                new Button();

            this.pnlCategories =
                new FlowLayoutPanel();

            this.btnAll =
                new Button();

            this.btnCommunity =
                new Button();

            this.btnEnvironment =
                new Button();

            this.btnSafety =
                new Button();

            this.btnHealth =
                new Button();

            this.btnEducation =
                new Button();

            this.pnlSectionHeader =
                new TableLayoutPanel();

            this.lblUpcoming =
                new Label();

            this.btnRecommended =
                new Button();

            this.pnlEvents =
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
                "Local Events and Announcements";

            this.ClientSize =
                new Size(
                    1100,
                    760);

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
                    820,
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
            // MAIN LAYOUT
            // =====================================================

            this.mainLayout.Dock =
                DockStyle.Fill;

            this.mainLayout.Padding =
                new Padding(
                    40,
                    12,
                    40,
                    8);

            this.mainLayout.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);

            this.mainLayout.ColumnCount =
                1;

            this.mainLayout.RowCount =
                5;


            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));


            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    90F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));


            // =====================================================
            // TITLE
            // =====================================================

            this.pnlTitleArea.Dock =
                DockStyle.Fill;

            this.pnlTitleArea.Margin =
                new Padding(0);


            this.lblIcon.Text =
                "▣";

            this.lblIcon.Location =
                new Point(
                    0,
                    10);

            this.lblIcon.Size =
                new Size(
                    58,
                    58);

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
                "Local Events and Announcements";

            this.lblTitle.Location =
                new Point(
                    75,
                    8);

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


            this.lblInformation.Text =
                "Stay informed about what's happening in your community.";

            this.lblInformation.Location =
                new Point(
                    77,
                    50);

            this.lblInformation.AutoSize =
                true;

            this.lblInformation.ForeColor =
                Color.FromArgb(
                    0,
                    90,
                    170);


            this.pnlTitleArea.Controls.Add(
                this.lblIcon);

            this.pnlTitleArea.Controls.Add(
                this.lblTitle);

            this.pnlTitleArea.Controls.Add(
                this.lblInformation);


            // =====================================================
            // SEARCH
            // =====================================================

            this.pnlSearch.Dock =
                DockStyle.Fill;

            this.pnlSearch.Margin =
                new Padding(
                    0,
                    4,
                    0,
                    7);

            this.pnlSearch.BackColor =
                Color.White;

            this.pnlSearch.CellBorderStyle =
                TableLayoutPanelCellBorderStyle.Single;

            this.pnlSearch.ColumnCount =
                2;

            this.pnlSearch.RowCount =
                1;


            this.pnlSearch.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            this.pnlSearch.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Absolute,
                    130F));


            this.txtSearch.Dock =
                DockStyle.Fill;

            this.txtSearch.Margin =
                new Padding(
                    15,
                    10,
                    10,
                    5);

            this.txtSearch.BorderStyle =
                BorderStyle.None;

            this.txtSearch.Font =
                new Font(
                    "Segoe UI",
                    10.5F);


            this.btnSearch.Text =
                "Search";

            this.btnSearch.Dock =
                DockStyle.Fill;

            this.btnSearch.Margin =
                new Padding(0);

            this.btnSearch.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnSearch.ForeColor =
                Color.White;

            this.btnSearch.FlatStyle =
                FlatStyle.Flat;

            this.btnSearch.FlatAppearance.BorderSize =
                0;

            this.btnSearch.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            this.btnSearch.Cursor =
                Cursors.Hand;

            this.btnSearch.Click +=
                new System.EventHandler(
                    this.btnSearch_Click);


            this.pnlSearch.Controls.Add(
                this.txtSearch,
                0,
                0);

            this.pnlSearch.Controls.Add(
                this.btnSearch,
                1,
                0);


            // =====================================================
            // CATEGORIES
            // =====================================================

            this.pnlCategories.Dock =
                DockStyle.Fill;

            this.pnlCategories.Margin =
                new Padding(
                    0,
                    2,
                    0,
                    5);

            this.pnlCategories.FlowDirection =
                FlowDirection.LeftToRight;

            this.pnlCategories.WrapContents =
                false;

            this.pnlCategories.AutoScroll =
                true;


            ConfigureCategoryButton(
                this.btnAll,
                "All");

            ConfigureCategoryButton(
                this.btnCommunity,
                "Community");

            ConfigureCategoryButton(
                this.btnEnvironment,
                "Environment");

            ConfigureCategoryButton(
                this.btnSafety,
                "Safety");

            ConfigureCategoryButton(
                this.btnHealth,
                "Health");

            ConfigureCategoryButton(
                this.btnEducation,
                "Education");


            this.btnAll.Click +=
                new System.EventHandler(
                    this.btnAll_Click);

            this.btnCommunity.Click +=
                new System.EventHandler(
                    this.btnCommunity_Click);

            this.btnEnvironment.Click +=
                new System.EventHandler(
                    this.btnEnvironment_Click);

            this.btnSafety.Click +=
                new System.EventHandler(
                    this.btnSafety_Click);

            this.btnHealth.Click +=
                new System.EventHandler(
                    this.btnHealth_Click);

            this.btnEducation.Click +=
                new System.EventHandler(
                    this.btnEducation_Click);


            this.pnlCategories.Controls.Add(
                this.btnAll);

            this.pnlCategories.Controls.Add(
                this.btnCommunity);

            this.pnlCategories.Controls.Add(
                this.btnEnvironment);

            this.pnlCategories.Controls.Add(
                this.btnSafety);

            this.pnlCategories.Controls.Add(
                this.btnHealth);

            this.pnlCategories.Controls.Add(
                this.btnEducation);


            // =====================================================
            // SECTION HEADER
            //
            // RECOMMEND BUTTON HAS ITS OWN COLUMN.
            // IT CANNOT DISAPPEAR OFF THE RIGHT SIDE.
            // =====================================================

            this.pnlSectionHeader.Dock =
                DockStyle.Fill;

            this.pnlSectionHeader.Margin =
                new Padding(
                    0,
                    2,
                    0,
                    5);

            this.pnlSectionHeader.BackColor =
                Color.White;

            this.pnlSectionHeader.CellBorderStyle =
                TableLayoutPanelCellBorderStyle.Single;

            this.pnlSectionHeader.ColumnCount =
                2;

            this.pnlSectionHeader.RowCount =
                1;


            this.pnlSectionHeader.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            this.pnlSectionHeader.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Absolute,
                    250F));


            this.lblUpcoming.Text =
                "Upcoming Events";

            this.lblUpcoming.Dock =
                DockStyle.Fill;

            this.lblUpcoming.Margin =
                new Padding(
                    15,
                    0,
                    0,
                    0);

            this.lblUpcoming.TextAlign =
                ContentAlignment.MiddleLeft;

            this.lblUpcoming.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            this.lblUpcoming.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.btnRecommended.Text =
                "★  Recommended for You";

            this.btnRecommended.Dock =
                DockStyle.Fill;

            this.btnRecommended.Margin =
                new Padding(
                    6,
                    5,
                    6,
                    5);

            this.btnRecommended.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnRecommended.ForeColor =
                Color.White;

            this.btnRecommended.FlatStyle =
                FlatStyle.Flat;

            this.btnRecommended.FlatAppearance.BorderSize =
                0;

            this.btnRecommended.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            this.btnRecommended.Cursor =
                Cursors.Hand;

            this.btnRecommended.UseVisualStyleBackColor =
                false;

            this.btnRecommended.Click +=
                new System.EventHandler(
                    this.btnRecommended_Click);


            this.pnlSectionHeader.Controls.Add(
                this.lblUpcoming,
                0,
                0);

            this.pnlSectionHeader.Controls.Add(
                this.btnRecommended,
                1,
                0);


            // =====================================================
            // EVENTS
            // =====================================================

            this.pnlEvents.Dock =
                DockStyle.Fill;

            this.pnlEvents.Margin =
                new Padding(
                    0,
                    3,
                    0,
                    3);

            this.pnlEvents.Padding =
                new Padding(
                    0,
                    5,
                    5,
                    10);

            this.pnlEvents.AutoScroll =
                true;

            this.pnlEvents.FlowDirection =
                FlowDirection.LeftToRight;

            this.pnlEvents.WrapContents =
                true;

            this.pnlEvents.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);


            // =====================================================
            // ADD MAIN LAYOUT
            // =====================================================

            this.mainLayout.Controls.Add(
                this.pnlTitleArea,
                0,
                0);

            this.mainLayout.Controls.Add(
                this.pnlSearch,
                0,
                1);

            this.mainLayout.Controls.Add(
                this.pnlCategories,
                0,
                2);

            this.mainLayout.Controls.Add(
                this.pnlSectionHeader,
                0,
                3);

            this.mainLayout.Controls.Add(
                this.pnlEvents,
                0,
                4);


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
                "←  Back to Main Menu";

            this.btnBack.Location =
                new Point(
                    40,
                    10);

            this.btnBack.Size =
                new Size(
                    190,
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

            this.btnBack.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnBack.Cursor =
                Cursors.Hand;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);


            this.pnlBottom.Controls.Add(
                this.btnBack);


            // =====================================================
            // COLOUR STRIP
            // =====================================================

            this.colourStrip.Dock =
                DockStyle.Bottom;

            this.colourStrip.Height =
                10;

            this.colourStrip.ColumnCount =
                4;

            this.colourStrip.RowCount =
                1;

            this.colourStrip.Margin =
                new Padding(0);


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


            // =====================================================
            // FORM CONTROLS
            // =====================================================

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


        // =====================================================
        // CATEGORY BUTTON STYLE
        // =====================================================

        private void ConfigureCategoryButton(
            Button button,
            string text)
        {
            button.Text =
                text;

            button.Size =
                new Size(
                    140,
                    38);

            button.Margin =
                new Padding(
                    0,
                    2,
                    10,
                    0);

            button.BackColor =
                Color.FromArgb(
                    230,
                    243,
                    253);

            button.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.Font =
                new Font(
                    "Segoe UI",
                    9F);

            button.Cursor =
                Cursors.Hand;
        }


        // =====================================================
        // COLOUR STRIP
        // =====================================================

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