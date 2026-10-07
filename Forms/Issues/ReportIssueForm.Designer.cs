using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderTitle;

        private Panel pnlBody;
        private TableLayoutPanel tblPage;
        private TableLayoutPanel tblForm;

        private Panel pnlInfo;
        private Label lblInfoIcon;
        private Label lblInfo;

        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblLocationError;

        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblCategoryError;

        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblDescriptionError;
        private Label lblCharacterCount;

        private Label lblAttachment;
        private Button btnChooseFile;
        private Label lblSelectedFile;
        private Label lblAttachmentError;

        private Button btnBack;
        private Button btnMyReports;
        private Button btnSubmit;

        private Panel pnlEngagement;
        private Label lblEngagement;
        private ProgressBar progressEngagement;
        private Label lblCommunity;

        private OpenFileDialog openFileDialog;

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

            this.tblPage =
                new TableLayoutPanel();

            this.tblForm =
                new TableLayoutPanel();

            this.pnlInfo =
                new Panel();

            this.lblInfoIcon =
                new Label();

            this.lblInfo =
                new Label();

            this.lblLocation =
                new Label();

            this.txtLocation =
                new TextBox();

            this.lblLocationError =
                new Label();

            this.lblCategory =
                new Label();

            this.cmbCategory =
                new ComboBox();

            this.lblCategoryError =
                new Label();

            this.lblDescription =
                new Label();

            this.rtbDescription =
                new RichTextBox();

            this.lblDescriptionError =
                new Label();

            this.lblCharacterCount =
                new Label();

            this.lblAttachment =
                new Label();

            this.btnChooseFile =
                new Button();

            this.lblSelectedFile =
                new Label();

            this.lblAttachmentError =
                new Label();

            this.btnBack =
                new Button();

            this.btnMyReports =
                new Button();

            this.btnSubmit =
                new Button();

            this.pnlEngagement =
                new Panel();

            this.lblEngagement =
                new Label();

            this.progressEngagement =
                new ProgressBar();

            this.lblCommunity =
                new Label();

            this.openFileDialog =
                new OpenFileDialog();

            this.colourStrip =
                new TableLayoutPanel();

            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "City of Cape Town - Report an Issue";

            this.ClientSize =
                new Size(
                    1050,
                    760);

            this.MinimumSize =
                new Size(
                    850,
                    650);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                Color.White;

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


            // LOGO

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


            // HEADER TITLE

            this.lblHeaderTitle.Text =
                "▧  Report an Issue";

            this.lblHeaderTitle.AutoSize =
                false;

            this.lblHeaderTitle.Size =
                new Size(
                    300,
                    60);

            this.lblHeaderTitle.Location =
                new Point(
                    700,
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

            this.pnlBody.AutoScroll =
                true;

            this.pnlBody.BackColor =
                Color.White;


            // =====================================================
            // PAGE LAYOUT
            // =====================================================

            this.tblPage.Dock =
                DockStyle.Top;

            this.tblPage.AutoSize =
                true;

            this.tblPage.AutoSizeMode =
                AutoSizeMode.GrowAndShrink;

            this.tblPage.ColumnCount =
                3;

            this.tblPage.RowCount =
                1;

            this.tblPage.Padding =
                new Padding(
                    0,
                    20,
                    0,
                    30);

            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    5F));

            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    90F));

            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    5F));

            this.pnlBody.Controls.Add(
                this.tblPage);


            // =====================================================
            // FORM LAYOUT
            // =====================================================

            this.tblForm.Dock =
                DockStyle.Fill;

            this.tblForm.AutoSize =
                true;

            this.tblForm.AutoSizeMode =
                AutoSizeMode.GrowAndShrink;

            this.tblForm.ColumnCount =
                1;

            this.tblForm.RowCount =
                8;

            this.tblPage.Controls.Add(
                this.tblForm,
                1,
                0);


            // =====================================================
            // INFORMATION PANEL
            // =====================================================

            this.pnlInfo.Dock =
                DockStyle.Top;

            this.pnlInfo.Height =
                65;

            this.pnlInfo.Margin =
                new Padding(
                    5,
                    0,
                    5,
                    15);

            this.pnlInfo.BackColor =
                Color.FromArgb(
                    235,
                    247,
                    253);


            this.lblInfoIcon.Text =
                "ⓘ";

            this.lblInfoIcon.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblInfoIcon.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.lblInfoIcon.Location =
                new Point(
                    15,
                    15);

            this.lblInfoIcon.Size =
                new Size(
                    40,
                    35);


            this.lblInfo.Text =
                "Help us keep Cape Town clean, safe and running.\n" +
                "Please provide as much detail as possible about the issue.";

            this.lblInfo.AutoSize =
                true;

            this.lblInfo.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblInfo.Location =
                new Point(
                    60,
                    13);


            this.pnlInfo.Controls.Add(
                this.lblInfoIcon);

            this.pnlInfo.Controls.Add(
                this.lblInfo);


            this.tblForm.Controls.Add(
                this.pnlInfo,
                0,
                0);


            // =====================================================
            // LOCATION
            // =====================================================

            Panel locationPanel =
                CreateFieldPanel(
                    "⌖   Location *",
                    this.lblLocation,
                    this.txtLocation,
                    this.lblLocationError);

            this.tblForm.Controls.Add(
                locationPanel,
                0,
                1);


            // =====================================================
            // CATEGORY
            // =====================================================

            Panel categoryPanel =
                new Panel();

            categoryPanel.Dock =
                DockStyle.Fill;

            categoryPanel.Height =
                90;

            categoryPanel.Margin =
                new Padding(
                    5,
                    3,
                    5,
                    3);


            this.lblCategory.Text =
                "◇   Category *";

            this.lblCategory.AutoSize =
                true;

            this.lblCategory.Location =
                new Point(
                    0,
                    0);

            this.lblCategory.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblCategory.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.cmbCategory.Location =
                new Point(
                    0,
                    25);

            this.cmbCategory.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.cmbCategory.Width =
                categoryPanel.ClientSize.Width;

            this.cmbCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cmbCategory.Font =
                new Font(
                    "Segoe UI",
                    10F);


            this.cmbCategory.Items.AddRange(
                new object[]
                {
                    "Select a category",
                    "Roads and Potholes",
                    "Water and Sanitation",
                    "Electricity",
                    "Waste and Refuse",
                    "Street Lights",
                    "Traffic Signals",
                    "Stormwater and Drainage",
                    "Public Spaces",
                    "Illegal Dumping",
                    "Other"
                });


            this.cmbCategory.SelectedIndex =
                0;


            this.lblCategoryError.Location =
                new Point(
                    0,
                    58);

            ConfigureErrorLabel(
                this.lblCategoryError);


            categoryPanel.Controls.Add(
                this.lblCategory);

            categoryPanel.Controls.Add(
                this.cmbCategory);

            categoryPanel.Controls.Add(
                this.lblCategoryError);


            this.tblForm.Controls.Add(
                categoryPanel,
                0,
                2);


            // =====================================================
            // DESCRIPTION
            // =====================================================

            Panel descriptionPanel =
                new Panel();

            descriptionPanel.Dock =
                DockStyle.Fill;

            descriptionPanel.Height =
                175;

            descriptionPanel.Margin =
                new Padding(
                    5,
                    3,
                    5,
                    3);


            this.lblDescription.Text =
                "✎   Description *";

            this.lblDescription.AutoSize =
                true;

            this.lblDescription.Location =
                new Point(
                    0,
                    0);

            this.lblDescription.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblDescription.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.rtbDescription.Location =
                new Point(
                    0,
                    25);

            this.rtbDescription.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.rtbDescription.Width =
                descriptionPanel.ClientSize.Width;

            this.rtbDescription.Height =
                105;

            this.rtbDescription.BorderStyle =
                BorderStyle.FixedSingle;

            this.rtbDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.rtbDescription.MaxLength =
                1000;

            this.rtbDescription.TextChanged +=
                new System.EventHandler(
                    this.rtbDescription_TextChanged);


            this.lblDescriptionError.Location =
                new Point(
                    0,
                    138);

            ConfigureErrorLabel(
                this.lblDescriptionError);


            this.lblCharacterCount.Text =
                "0 / 1000";

            this.lblCharacterCount.AutoSize =
                true;

            this.lblCharacterCount.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblCharacterCount.Location =
                new Point(
                    descriptionPanel.ClientSize.Width - 70,
                    138);

            this.lblCharacterCount.ForeColor =
                Color.Gray;


            descriptionPanel.Controls.Add(
                this.lblDescription);

            descriptionPanel.Controls.Add(
                this.rtbDescription);

            descriptionPanel.Controls.Add(
                this.lblDescriptionError);

            descriptionPanel.Controls.Add(
                this.lblCharacterCount);


            this.tblForm.Controls.Add(
                descriptionPanel,
                0,
                3);


            // =====================================================
            // ATTACHMENT
            // =====================================================

            Panel attachmentPanel =
                new Panel();

            attachmentPanel.Dock =
                DockStyle.Fill;

            attachmentPanel.Height =
                100;

            attachmentPanel.Margin =
                new Padding(
                    5,
                    3,
                    5,
                    3);


            this.lblAttachment.Text =
                "📎   Attach Image / Document";

            this.lblAttachment.AutoSize =
                true;

            this.lblAttachment.Location =
                new Point(
                    0,
                    0);

            this.lblAttachment.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblAttachment.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.btnChooseFile.Text =
                "Choose File";

            this.btnChooseFile.Location =
                new Point(
                    0,
                    28);

            this.btnChooseFile.Size =
                new Size(
                    120,
                    35);

            this.btnChooseFile.FlatStyle =
                FlatStyle.Flat;

            this.btnChooseFile.FlatAppearance.BorderSize =
                0;

            this.btnChooseFile.BackColor =
                Color.FromArgb(
                    230,
                    236,
                    241);

            this.btnChooseFile.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.btnChooseFile.Cursor =
                Cursors.Hand;

            this.btnChooseFile.Click +=
                new System.EventHandler(
                    this.btnChooseFile_Click);


            this.lblSelectedFile.Text =
                "No file selected";

            this.lblSelectedFile.AutoEllipsis =
                true;

            this.lblSelectedFile.Location =
                new Point(
                    135,
                    35);

            this.lblSelectedFile.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.lblSelectedFile.Size =
                new Size(
                    600,
                    25);

            this.lblSelectedFile.ForeColor =
                Color.Gray;


            this.lblAttachmentError.Location =
                new Point(
                    0,
                    70);

            ConfigureErrorLabel(
                this.lblAttachmentError);


            attachmentPanel.Controls.Add(
                this.lblAttachment);

            attachmentPanel.Controls.Add(
                this.btnChooseFile);

            attachmentPanel.Controls.Add(
                this.lblSelectedFile);

            attachmentPanel.Controls.Add(
                this.lblAttachmentError);


            this.tblForm.Controls.Add(
                attachmentPanel,
                0,
                4);


            // =====================================================
            // BUTTONS
            // =====================================================

            TableLayoutPanel buttonTable =
                new TableLayoutPanel();

            buttonTable.Dock =
                DockStyle.Fill;

            buttonTable.Height =
                60;

            buttonTable.ColumnCount =
                3;

            buttonTable.Margin =
                new Padding(
                    5,
                    5,
                    5,
                    10);

            buttonTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Absolute,
                    180F));

            buttonTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    100F));

            buttonTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Absolute,
                    160F));


            this.btnBack.Text =
                "← Back to Main Menu";

            this.btnBack.Dock =
                DockStyle.Fill;

            this.btnBack.Margin =
                new Padding(
                    0,
                    5,
                    10,
                    5);

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

            // =====================================================
            // MY REPORTS BUTTON
            // =====================================================

            this.btnMyReports.Text =
                "☷  My Reports";

            this.btnMyReports.Dock =
                DockStyle.Fill;

            this.btnMyReports.Margin =
                new Padding(
                    10,
                    5,
                    10,
                    5);

            this.btnMyReports.BackColor =
                Color.White;

            this.btnMyReports.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.btnMyReports.FlatStyle =
                FlatStyle.Flat;

            this.btnMyReports.FlatAppearance.BorderColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.btnMyReports.FlatAppearance.BorderSize =
                1;

            this.btnMyReports.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnMyReports.Cursor =
                Cursors.Hand;

            this.btnMyReports.Click +=
                new System.EventHandler(
                    this.btnMyReports_Click);


            this.btnSubmit.Text =
                "➤  Submit";

            this.btnSubmit.Dock =
                DockStyle.Fill;

            this.btnSubmit.Margin =
                new Padding(
                    10,
                    5,
                    0,
                    5);

            this.btnSubmit.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnSubmit.ForeColor =
                Color.White;

            this.btnSubmit.FlatStyle =
                FlatStyle.Flat;

            this.btnSubmit.FlatAppearance.BorderSize =
                0;

            this.btnSubmit.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnSubmit.Cursor =
                Cursors.Hand;

            this.btnSubmit.Click +=
                new System.EventHandler(
                    this.btnSubmit_Click);


            buttonTable.Controls.Add(
                this.btnBack,
                0,
                0);
            buttonTable.Controls.Add(
                this.btnMyReports,
                1,
                0);

            buttonTable.Controls.Add(
                this.btnSubmit,
                2,
                0);


            this.tblForm.Controls.Add(
                buttonTable,
                0,
                5);


            // =====================================================
            // ENGAGEMENT
            // =====================================================

            this.pnlEngagement.Dock =
                DockStyle.Fill;

            this.pnlEngagement.Height =
                75;

            this.pnlEngagement.Margin =
                new Padding(
                    5,
                    5,
                    5,
                    10);

            this.pnlEngagement.BackColor =
                Color.FromArgb(
                    248,
                    251,
                    253);


            this.lblEngagement.Text =
                "👥  Your report makes a difference!";

            this.lblEngagement.AutoSize =
                true;

            this.lblEngagement.Location =
                new Point(
                    10,
                    10);

            this.lblEngagement.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblEngagement.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);


            this.progressEngagement.Location =
                new Point(
                    35,
                    38);

            this.progressEngagement.Size =
                new Size(
                    430,
                    12);

            this.progressEngagement.Minimum =
                0;

            this.progressEngagement.Maximum =
                100;

            this.progressEngagement.Value =
                72;


            this.lblCommunity.Text =
                "🌱  Stronger communities";

            this.lblCommunity.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblCommunity.AutoSize =
                true;

            this.lblCommunity.Location =
                new Point(
                    700,
                    25);

            this.lblCommunity.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.pnlEngagement.Controls.Add(
                this.lblEngagement);

            this.pnlEngagement.Controls.Add(
                this.progressEngagement);

            this.pnlEngagement.Controls.Add(
                this.lblCommunity);


            this.tblForm.Controls.Add(
                this.pnlEngagement,
                0,
                6);


            // =====================================================
            // OPEN FILE DIALOG
            // =====================================================

            this.openFileDialog.Title =
                "Select an image or document";

            this.openFileDialog.Filter =
                "Supported Files (*.jpg;*.jpeg;*.png;*.pdf)|" +
                "*.jpg;*.jpeg;*.png;*.pdf|" +
                "Images (*.jpg;*.jpeg;*.png)|" +
                "*.jpg;*.jpeg;*.png|" +
                "PDF Documents (*.pdf)|*.pdf";

            this.openFileDialog.Multiselect =
                false;


            // =====================================================
            // FOOTER
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
            // ADD TO FORM
            // =====================================================

            this.Controls.Add(
                this.pnlBody);

            this.Controls.Add(
                this.colourStrip);

            this.Controls.Add(
                this.pnlHeader);

            this.pnlHeader.BringToFront();

            this.colourStrip.BringToFront();

            this.ResumeLayout(false);
        }


        // =========================================================
        // STANDARD TEXT FIELD
        // =========================================================

        private Panel CreateFieldPanel(
            string title,
            Label label,
            TextBox textBox,
            Label errorLabel)
        {
            Panel panel =
                new Panel();

            panel.Dock =
                DockStyle.Fill;

            panel.Height =
                90;

            panel.Margin =
                new Padding(
                    5,
                    3,
                    5,
                    3);


            label.Text =
                title;

            label.AutoSize =
                true;

            label.Location =
                new Point(
                    0,
                    0);

            label.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            label.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            textBox.Location =
                new Point(
                    0,
                    25);

            textBox.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            textBox.Width =
                panel.ClientSize.Width;

            textBox.Font =
                new Font(
                    "Segoe UI",
                    10F);

            textBox.BorderStyle =
                BorderStyle.FixedSingle;


            errorLabel.Location =
                new Point(
                    0,
                    58);

            ConfigureErrorLabel(
                errorLabel);


            panel.Controls.Add(
                label);

            panel.Controls.Add(
                textBox);

            panel.Controls.Add(
                errorLabel);

            return panel;
        }


        private void ConfigureErrorLabel(
            Label label)
        {
            label.AutoSize =
                true;

            label.ForeColor =
                Color.FromArgb(
                    200,
                    45,
                    45);

            label.Font =
                new Font(
                    "Segoe UI",
                    8F);

            label.Visible =
                false;
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