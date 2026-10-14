
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Admin
{
    partial class AdminRequestDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlBody;
        private Panel pnlDetails;
        private Panel pnlTop;

        private PictureBox picLogo;

        private Label lblBrand;
        private Label lblPortal;
        private Label lblSubtitle;

        private Label lblPageTitle;
        private Label lblPageDescription;

        private Label lblReferenceValue;
        private Label lblResidentValue;
        private Label lblCategoryValue;
        private Label lblLocationValue;
        private Label lblDateValue;
        private Label lblCurrentStatusValue;
        private Label lblAttachmentValue;

        private TextBox txtDescription;
        private ComboBox cmbStatus;

        private Button btnBack;
        private Button btnSave;
        private Button btnViewAttachment;

        private TableLayoutPanel colourStrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            Text = "Service Request Details - City of Cape Town";

            ClientSize = new Size(1000, 760);
            MinimumSize = new Size(800, 650);

            StartPosition =
                FormStartPosition.CenterParent;

            Font = new Font("Segoe UI", 10F);

            BackColor = Color.White;

            AutoScaleMode = AutoScaleMode.Dpi;

            // =====================================================
            // MUNICIPAL HEADER
            // =====================================================

            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 112,
                BackColor = Color.FromArgb(0, 119, 75)
            };

            picLogo = new PictureBox
            {
                Image = Properties.Resources.city_logo,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(22, 17),
                Size = new Size(74, 74)
            };

            lblBrand = new Label
            {
                Text =
                    "CITY OF CAPE TOWN\n" +
                    "ISIXEKO SASEKAPA\n" +
                    "STAD KAAPSTAD",

                ForeColor = Color.White,

                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold),

                Location = new Point(104, 24),
                Size = new Size(195, 68)
            };

            lblPortal = new Label
            {
                Text = "Municipal Services - Admin Portal",

                ForeColor = Color.White,

                Font = new Font(
                    "Segoe UI",
                    19F,
                    FontStyle.Bold),

                Location = new Point(318, 19),
                Size = new Size(610, 43)
            };

            lblSubtitle = new Label
            {
                Text = "Review and manage citizen service requests.",

                ForeColor = Color.White,

                Location = new Point(320, 66),
                Size = new Size(610, 27)
            };

            pnlHeader.Controls.AddRange(
                new Control[]
                {
                    picLogo,
                    lblBrand,
                    lblPortal,
                    lblSubtitle
                });

            // =====================================================
            // MUNICIPAL COLOUR STRIP
            // =====================================================

            colourStrip = new TableLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 12,
                ColumnCount = 4,
                RowCount = 1,
                Margin = new Padding(0)
            };

            Color[] colors =
            {
                Color.FromArgb(166, 206, 57),
                Color.FromArgb(255, 215, 0),
                Color.FromArgb(0, 119, 200),
                Color.FromArgb(230, 0, 126)
            };

            for (int i = 0; i < 4; i++)
            {
                colourStrip.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        25F));

                colourStrip.Controls.Add(
                    new Panel
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        BackColor = colors[i]
                    },
                    i,
                    0);
            }

            // =====================================================
            // MAIN BODY
            // =====================================================

            pnlBody = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(26),
                AutoScroll = true,
                BackColor = Color.FromArgb(248, 250, 252)
            };

            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(colourStrip);

            // =====================================================
            // PAGE HEADER
            // =====================================================

            pnlTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 105
            };

            btnBack = new Button
            {
                Text = "← Back",
                Location = new Point(0, 2),
                Size = new Size(105, 35),

                BackColor = Color.White,
                ForeColor = Color.FromArgb(0, 75, 58),

                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnBack.Click += btnBack_Click;

            lblPageTitle = new Label
            {
                Text = "Service Request Details",

                Font = new Font(
                    "Segoe UI",
                    21F,
                    FontStyle.Bold),

                ForeColor = Color.FromArgb(0, 75, 58),

                Location = new Point(0, 43),
                AutoSize = true
            };

            lblPageDescription = new Label
            {
                Text = "Review the details submitted by the resident.",

                ForeColor = Color.FromArgb(70, 85, 105),

                Location = new Point(0, 84),
                AutoSize = true
            };

            pnlTop.Controls.Add(btnBack);
            pnlTop.Controls.Add(lblPageTitle);
            pnlTop.Controls.Add(lblPageDescription);

            // =====================================================
            // DETAILS PANEL
            // =====================================================

            pnlDetails = new Panel
            {
                Dock = DockStyle.Top,
                Height = 510,
                BackColor = Color.White,
                Padding = new Padding(24),
                BorderStyle = BorderStyle.FixedSingle
            };

            // =====================================================
            // REFERENCE NUMBER
            // =====================================================

            AddFieldLabel(
                "Reference Number",
                25,
                22);

            lblReferenceValue = CreateValueLabel(
                220,
                22,
                650);

            pnlDetails.Controls.Add(
                lblReferenceValue);

            // =====================================================
            // RESIDENT EMAIL
            // =====================================================

            AddFieldLabel(
                "Resident Email",
                25,
                65);

            lblResidentValue = CreateValueLabel(
                220,
                65,
                650);

            pnlDetails.Controls.Add(
                lblResidentValue);

            // =====================================================
            // CATEGORY
            // =====================================================

            AddFieldLabel(
                "Category",
                25,
                108);

            lblCategoryValue = CreateValueLabel(
                220,
                108,
                650);

            pnlDetails.Controls.Add(
                lblCategoryValue);

            // =====================================================
            // LOCATION
            // =====================================================

            AddFieldLabel(
                "Location",
                25,
                151);

            lblLocationValue = CreateValueLabel(
                220,
                151,
                650);

            pnlDetails.Controls.Add(
                lblLocationValue);

            // =====================================================
            // DATE REPORTED
            // =====================================================

            AddFieldLabel(
                "Date Reported",
                25,
                194);

            lblDateValue = CreateValueLabel(
                220,
                194,
                650);

            pnlDetails.Controls.Add(
                lblDateValue);

            // =====================================================
            // CURRENT STATUS
            // =====================================================

            AddFieldLabel(
                "Current Status",
                25,
                237);

            lblCurrentStatusValue = CreateValueLabel(
                220,
                237,
                650);

            lblCurrentStatusValue.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            pnlDetails.Controls.Add(
                lblCurrentStatusValue);

            // =====================================================
            // DESCRIPTION
            // =====================================================

            AddFieldLabel(
                "Description",
                25,
                283);

            txtDescription = new TextBox
            {
                Location = new Point(220, 280),
                Size = new Size(650, 82),

                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,

                BackColor = Color.FromArgb(
                    248, 250, 252),

                BorderStyle = BorderStyle.FixedSingle
            };

            txtDescription.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            pnlDetails.Controls.Add(
                txtDescription);

            // =====================================================
            // ATTACHMENT
            // =====================================================

            AddFieldLabel(
                "Attachment",
                25,
                380);

            lblAttachmentValue = CreateValueLabel(
                220,
                380,
                390);

            pnlDetails.Controls.Add(
                lblAttachmentValue);

            btnViewAttachment = new Button
            {
                Text = "View Attachment",

                Location = new Point(670, 374),
                Size = new Size(170, 35),

                BackColor = Color.FromArgb(0, 119, 200),
                ForeColor = Color.White,

                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnViewAttachment.FlatAppearance.BorderSize = 0;

            btnViewAttachment.Click +=
                btnViewAttachment_Click;

            pnlDetails.Controls.Add(
                btnViewAttachment);

            // =====================================================
            // CHANGE STATUS
            // =====================================================

            AddFieldLabel(
                "Update Status",
                25,
                437);

            cmbStatus = new ComboBox
            {
                Location = new Point(220, 431),
                Size = new Size(260, 34),

                DropDownStyle =
                    ComboBoxStyle.DropDownList
            };

            cmbStatus.Items.AddRange(
                new object[]
                {
                    "Pending",
                    "In Progress",
                    "Resolved",
                    "Rejected"
                });

            cmbStatus.SelectedIndex = 0;

            pnlDetails.Controls.Add(cmbStatus);

            // =====================================================
            // SAVE BUTTON
            // =====================================================

            btnSave = new Button
            {
                Text = "Save Changes",

                Location = new Point(670, 430),
                Size = new Size(170, 40),

                BackColor = Color.FromArgb(0, 119, 75),
                ForeColor = Color.White,

                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold),

                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnSave.FlatAppearance.BorderSize = 0;

            btnSave.Click += btnSave_Click;

            pnlDetails.Controls.Add(btnSave);

            // =====================================================
            // ADD TO BODY
            // =====================================================

            pnlBody.Controls.Add(pnlDetails);
            pnlBody.Controls.Add(pnlTop);

            ResumeLayout(false);
        }

        // =====================================================
        // CREATE FIELD LABEL
        // =====================================================

        private void AddFieldLabel(
            string text,
            int x,
            int y)
        {
            Label label = new Label
            {
                Text = text,

                Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold),

                ForeColor = Color.FromArgb(55, 70, 85),

                Location = new Point(x, y),
                Size = new Size(180, 28)
            };

            pnlDetails.Controls.Add(label);
        }

        // =====================================================
        // CREATE VALUE LABEL
        // =====================================================

        private Label CreateValueLabel(
            int x,
            int y,
            int width)
        {
            return new Label
            {
                Text = "-",

                Font = new Font(
                    "Segoe UI",
                    10F),

                ForeColor = Color.FromArgb(30, 45, 60),

                Location = new Point(x, y),
                Size = new Size(width, 28),

                AutoEllipsis = true
            };
        }
    }
}
