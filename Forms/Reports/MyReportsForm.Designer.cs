using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Reports
{
    partial class MyReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderTitle;

        private Panel pnlBody;

        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlSummary;
        private Label lblTotalNumber;
        private Label lblTotalText;

        private Panel pnlSearch;
        private Label lblSearchIcon;
        private TextBox txtSearch;

        private FlowLayoutPanel pnlFilters;

        private Button btnAll;
        private Button btnSubmitted;
        private Button btnInProgress;
        private Button btnResolved;
        private Button btnClosed;

        private FlowLayoutPanel pnlReports;

        private Panel pnlEmpty;
        private Label lblEmptyIcon;
        private Label lblEmptyTitle;
        private Label lblEmptyMessage;

        private Panel pnlBottom;
        private Button btnBack;
        private Button btnNewReport;

        private TableLayoutPanel colourStrip;


        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
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

            this.lblHeaderTitle =
                new Label();

            this.pnlBody =
                new Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.pnlSummary =
                new Panel();

            this.lblTotalNumber =
                new Label();

            this.lblTotalText =
                new Label();

            this.pnlSearch =
                new Panel();

            this.lblSearchIcon =
                new Label();

            this.txtSearch =
                new TextBox();

            this.pnlFilters =
                new FlowLayoutPanel();

            this.btnAll =
                new Button();

            this.btnSubmitted =
                new Button();

            this.btnInProgress =
                new Button();

            this.btnResolved =
                new Button();

            this.btnClosed =
                new Button();

            this.pnlReports =
                new FlowLayoutPanel();

            this.pnlEmpty =
                new Panel();

            this.lblEmptyIcon =
                new Label();

            this.lblEmptyTitle =
                new Label();

            this.lblEmptyMessage =
                new Label();

            this.pnlBottom =
                new Panel();

            this.btnBack =
                new Button();

            this.btnNewReport =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();

            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "City of Cape Town - My Reports";

            this.ClientSize =
                new Size(
                    1100,
                    760);

            this.MinimumSize =
                new Size(
                    900,
                    650);

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
                100;

            this.pnlHeader.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // =====================================================
            // LOGO
            // =====================================================

            this.picLogo.Location =
                new Point(
                    30,
                    15);

            this.picLogo.Size =
                new Size(
                    70,
                    70);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;

            this.pnlHeader.Controls.Add(
                this.picLogo);


            // =====================================================
            // HEADER TITLE
            // =====================================================

            this.lblHeaderTitle.Text =
                "☷  My Reports";

            this.lblHeaderTitle.AutoSize =
                false;

            this.lblHeaderTitle.Size =
                new Size(
                    300,
                    60);

            this.lblHeaderTitle.Location =
                new Point(
                    750,
                    20);

            this.lblHeaderTitle.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblHeaderTitle.TextAlign =
                ContentAlignment.MiddleRight;

            this.lblHeaderTitle.ForeColor =
                Color.White;

            this.lblHeaderTitle.Font =
                new Font(
                    "Segoe UI",
                    16F,
                    FontStyle.Bold);

            this.pnlHeader.Controls.Add(
                this.lblHeaderTitle);


            // =====================================================
            // BODY
            // =====================================================

            this.pnlBody.Dock =
                DockStyle.Fill;

            this.pnlBody.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);


            // =====================================================
            // PAGE TITLE
            // =====================================================

            this.lblTitle.Text =
                "My Submitted Reports";

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Location =
                new Point(
                    50,
                    25);

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.pnlBody.Controls.Add(
                this.lblTitle);


            this.lblSubtitle.Text =
                "View and track the progress of issues you have reported.";

            this.lblSubtitle.AutoSize =
                true;

            this.lblSubtitle.Location =
                new Point(
                    54,
                    70);

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(
                    90,
                    105,
                    120);

            this.pnlBody.Controls.Add(
                this.lblSubtitle);


            // =====================================================
            // SUMMARY
            // =====================================================

            this.pnlSummary.Size =
                new Size(
                    145,
                    65);

            this.pnlSummary.Location =
                new Point(
                    905,
                    20);

            this.pnlSummary.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.pnlSummary.BackColor =
                Color.White;

            this.pnlSummary.BorderStyle =
                BorderStyle.FixedSingle;


            this.lblTotalNumber.Text =
                "0";

            this.lblTotalNumber.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblTotalNumber.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.lblTotalNumber.Location =
                new Point(
                    10,
                    5);

            this.lblTotalNumber.Size =
                new Size(
                    125,
                    30);

            this.lblTotalNumber.TextAlign =
                ContentAlignment.MiddleCenter;


            this.lblTotalText.Text =
                "Total Reports";

            this.lblTotalText.ForeColor =
                Color.Gray;

            this.lblTotalText.Location =
                new Point(
                    10,
                    36);

            this.lblTotalText.Size =
                new Size(
                    125,
                    20);

            this.lblTotalText.TextAlign =
                ContentAlignment.MiddleCenter;


            this.pnlSummary.Controls.Add(
                this.lblTotalNumber);

            this.pnlSummary.Controls.Add(
                this.lblTotalText);

            this.pnlBody.Controls.Add(
                this.pnlSummary);


            // =====================================================
            // SEARCH
            // =====================================================

            this.pnlSearch.Location =
                new Point(
                    50,
                    110);

            this.pnlSearch.Size =
                new Size(
                    1000,
                    48);

            this.pnlSearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlSearch.BackColor =
                Color.White;

            this.pnlSearch.BorderStyle =
                BorderStyle.FixedSingle;


            this.lblSearchIcon.Text =
                "⌕";

            this.lblSearchIcon.Location =
                new Point(
                    12,
                    7);

            this.lblSearchIcon.Size =
                new Size(
                    35,
                    30);

            this.lblSearchIcon.Font =
                new Font(
                    "Segoe UI",
                    16F);

            this.lblSearchIcon.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);


            this.txtSearch.Location =
                new Point(
                    50,
                    12);

            this.txtSearch.Size =
                new Size(
                    930,
                    25);

            this.txtSearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.txtSearch.BorderStyle =
                BorderStyle.None;

            this.txtSearch.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged);


            this.pnlSearch.Controls.Add(
                this.lblSearchIcon);

            this.pnlSearch.Controls.Add(
                this.txtSearch);

            this.pnlBody.Controls.Add(
                this.pnlSearch);


            // =====================================================
            // FILTERS
            // =====================================================

            this.pnlFilters.Location =
                new Point(
                    50,
                    175);

            this.pnlFilters.Size =
                new Size(
                    1000,
                    42);

            this.pnlFilters.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlFilters.FlowDirection =
                FlowDirection.LeftToRight;

            this.pnlFilters.WrapContents =
                false;


            ConfigureFilterButton(
                this.btnAll,
                "All Reports");

            ConfigureFilterButton(
                this.btnSubmitted,
                "Submitted");

            ConfigureFilterButton(
                this.btnInProgress,
                "In Progress");

            ConfigureFilterButton(
                this.btnResolved,
                "Resolved");

            ConfigureFilterButton(
                this.btnClosed,
                "Closed");


            this.btnAll.Click +=
                new System.EventHandler(
                    this.btnAll_Click);

            this.btnSubmitted.Click +=
                new System.EventHandler(
                    this.btnSubmitted_Click);

            this.btnInProgress.Click +=
                new System.EventHandler(
                    this.btnInProgress_Click);

            this.btnResolved.Click +=
                new System.EventHandler(
                    this.btnResolved_Click);

            this.btnClosed.Click +=
                new System.EventHandler(
                    this.btnClosed_Click);


            this.pnlFilters.Controls.Add(
                this.btnAll);

            this.pnlFilters.Controls.Add(
                this.btnSubmitted);

            this.pnlFilters.Controls.Add(
                this.btnInProgress);

            this.pnlFilters.Controls.Add(
                this.btnResolved);

            this.pnlFilters.Controls.Add(
                this.btnClosed);

            this.pnlBody.Controls.Add(
                this.pnlFilters);


            // =====================================================
            // REPORTS CONTAINER
            // =====================================================

            this.pnlReports.Location =
                new Point(
                    50,
                    230);

            this.pnlReports.Size =
                new Size(
                    1000,
                    390);

            this.pnlReports.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.pnlReports.AutoScroll =
                true;

            this.pnlReports.FlowDirection =
                FlowDirection.TopDown;

            this.pnlReports.WrapContents =
                false;

            this.pnlReports.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);

            this.pnlBody.Controls.Add(
                this.pnlReports);


            // =====================================================
            // EMPTY STATE
            // =====================================================

            this.pnlEmpty.Size =
                new Size(
                    960,
                    250);

            this.pnlEmpty.BackColor =
                Color.White;

            this.pnlEmpty.BorderStyle =
                BorderStyle.FixedSingle;


            this.lblEmptyIcon.Text =
                "☷";

            this.lblEmptyIcon.Location =
                new Point(
                    0,
                    30);

            this.lblEmptyIcon.Size =
                new Size(
                    960,
                    70);

            this.lblEmptyIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblEmptyIcon.Font =
                new Font(
                    "Segoe UI",
                    34F);

            this.lblEmptyIcon.ForeColor =
                Color.FromArgb(
                    180,
                    190,
                    200);


            this.lblEmptyTitle.Text =
                "No reports found";

            this.lblEmptyTitle.Location =
                new Point(
                    0,
                    110);

            this.lblEmptyTitle.Size =
                new Size(
                    960,
                    35);

            this.lblEmptyTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblEmptyTitle.Font =
                new Font(
                    "Segoe UI",
                    13F,
                    FontStyle.Bold);

            this.lblEmptyTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.lblEmptyMessage.Text =
                "Reports you submit will appear here.";

            this.lblEmptyMessage.Location =
                new Point(
                    0,
                    150);

            this.lblEmptyMessage.Size =
                new Size(
                    960,
                    30);

            this.lblEmptyMessage.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblEmptyMessage.ForeColor =
                Color.Gray;


            this.pnlEmpty.Controls.Add(
                this.lblEmptyIcon);

            this.pnlEmpty.Controls.Add(
                this.lblEmptyTitle);

            this.pnlEmpty.Controls.Add(
                this.lblEmptyMessage);


            // =====================================================
            // BOTTOM NAVIGATION
            // =====================================================

            this.pnlBottom.Dock =
                DockStyle.Bottom;

            this.pnlBottom.Height =
                70;

            this.pnlBottom.BackColor =
                Color.White;


            // BACK

            this.btnBack.Text =
                "←  Back to Report Issue";

            this.btnBack.Location =
                new Point(
                    50,
                    14);

            this.btnBack.Size =
                new Size(
                    190,
                    42);

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


            // NEW REPORT

            this.btnNewReport.Text =
                "＋  New Report";

            this.btnNewReport.Size =
                new Size(
                    160,
                    42);

            this.btnNewReport.Location =
                new Point(
                    890,
                    14);

            this.btnNewReport.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.btnNewReport.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnNewReport.ForeColor =
                Color.White;

            this.btnNewReport.FlatStyle =
                FlatStyle.Flat;

            this.btnNewReport.FlatAppearance.BorderSize =
                0;

            this.btnNewReport.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnNewReport.Cursor =
                Cursors.Hand;

            this.btnNewReport.Click +=
                new System.EventHandler(
                    this.btnNewReport_Click);


            this.pnlBottom.Controls.Add(
                this.btnBack);

            this.pnlBottom.Controls.Add(
                this.btnNewReport);


            // =====================================================
            // COLOUR STRIP
            // =====================================================

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


            // =====================================================
            // FORM CONTROLS
            // =====================================================

            this.Controls.Add(
                this.pnlBody);

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
        // FILTER BUTTON
        // =====================================================

        private void ConfigureFilterButton(
            Button button,
            string text)
        {
            button.Text =
                text;

            button.Size =
                new Size(
                    140,
                    36);

            button.Margin =
                new Padding(
                    0,
                    0,
                    10,
                    0);

            button.BackColor =
                Color.FromArgb(
                    235,
                    247,
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
                    9F,
                    FontStyle.Bold);

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