using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderSlogan;

        // Body
        private Panel pnlBody;
        private TableLayoutPanel tblPage;
        private TableLayoutPanel tblForm;

        // Heading
        private Label lblTitle;
        private Label lblSubtitle;

        // First name
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblFirstNameError;

        // Last name
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblLastNameError;

        // Email
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmailError;

        // Phone
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblPhoneError;

        // Address
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblAddressError;

        // Suburb
        private Label lblSuburb;
        private TextBox txtSuburb;
        private Label lblSuburbError;

        // City
        private Label lblCity;
        private TextBox txtCity;
        private Label lblCityError;

        // Postal code
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private Label lblPostalCodeError;

        // Password
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordError;

        // Confirm password
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPasswordError;

        // Terms
        private CheckBox chkTerms;
        private Label lblTermsError;

        // Buttons
        private Button btnBack;
        private Button btnCreateAccount;

        // Footer
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


            // =====================================================
            // CREATE CONTROLS
            // =====================================================

            this.pnlHeader =
                new Panel();

            this.picLogo =
                new PictureBox();

            this.lblHeaderSlogan =
                new Label();

            this.pnlBody =
                new Panel();

            this.tblPage =
                new TableLayoutPanel();

            this.tblForm =
                new TableLayoutPanel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblFirstName =
                new Label();

            this.txtFirstName =
                new TextBox();

            this.lblFirstNameError =
                new Label();

            this.lblLastName =
                new Label();

            this.txtLastName =
                new TextBox();

            this.lblLastNameError =
                new Label();

            this.lblEmail =
                new Label();

            this.txtEmail =
                new TextBox();

            this.lblEmailError =
                new Label();

            this.lblPhone =
                new Label();

            this.txtPhone =
                new TextBox();

            this.lblPhoneError =
                new Label();

            this.lblAddress =
                new Label();

            this.txtAddress =
                new TextBox();

            this.lblAddressError =
                new Label();

            this.lblSuburb =
                new Label();

            this.txtSuburb =
                new TextBox();

            this.lblSuburbError =
                new Label();

            this.lblCity =
                new Label();

            this.txtCity =
                new TextBox();

            this.lblCityError =
                new Label();

            this.lblPostalCode =
                new Label();

            this.txtPostalCode =
                new TextBox();

            this.lblPostalCodeError =
                new Label();

            this.lblPassword =
                new Label();

            this.txtPassword =
                new TextBox();

            this.lblPasswordError =
                new Label();

            this.lblConfirmPassword =
                new Label();

            this.txtConfirmPassword =
                new TextBox();

            this.lblConfirmPasswordError =
                new Label();

            this.chkTerms =
                new CheckBox();

            this.lblTermsError =
                new Label();

            this.btnBack =
                new Button();

            this.btnCreateAccount =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();


            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "City of Cape Town - Create Account";

            this.ClientSize =
                new Size(
                    1100,
                    760);

            this.MinimumSize =
                new Size(
                    900,
                    650);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                Color.FromArgb(
                    247,
                    250,
                    252);

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


            // =====================================================
            // LOGO
            // =====================================================

            this.picLogo.Location =
                new Point(
                    30,
                    12);

            this.picLogo.Size =
                new Size(
                    70,
                    65);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;


            this.pnlHeader.Controls.Add(
                this.picLogo);


            // =====================================================
            // HEADER SLOGAN
            // =====================================================

            this.lblHeaderSlogan.Text =
                "Making progress possible.\nTogether.";

            this.lblHeaderSlogan.ForeColor =
                Color.White;

            this.lblHeaderSlogan.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Italic);

            this.lblHeaderSlogan.TextAlign =
                ContentAlignment.MiddleRight;

            this.lblHeaderSlogan.Size =
                new Size(
                    250,
                    55);

            this.lblHeaderSlogan.Location =
                new Point(
                    800,
                    18);

            this.lblHeaderSlogan.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;


            this.pnlHeader.Controls.Add(
                this.lblHeaderSlogan);


            // =====================================================
            // BODY
            //
            // AutoScroll stays enabled because Sign Up contains
            // more fields than Sign In.
            // =====================================================

            this.pnlBody.Dock =
                DockStyle.Fill;

            this.pnlBody.AutoScroll =
                true;

            this.pnlBody.BackColor =
                Color.FromArgb(
                    247,
                    250,
                    252);


            // =====================================================
            // PAGE TABLE
            //
            // OLD:
            // 7% | 86% | 7%
            //
            // NEW:
            // 13% | 74% | 13%
            //
            // This stops the fields from stretching almost
            // across the entire application.
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
                    60,
                    0,
                    45);


            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    13F));

            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    74F));

            this.tblPage.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    13F));


            this.pnlBody.Controls.Add(
                this.tblPage);


            // =====================================================
            // FORM TABLE
            // =====================================================

            this.tblForm.Dock =
                DockStyle.Fill;

            this.tblForm.AutoSize =
                true;

            this.tblForm.AutoSizeMode =
                AutoSizeMode.GrowAndShrink;

            this.tblForm.ColumnCount =
                2;

            this.tblForm.RowCount =
                10;

            this.tblForm.BackColor =
                Color.White;

            this.tblForm.Padding =
                new Padding(
                    22,
                    22,
                    22,
                    28);


            this.tblForm.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            this.tblForm.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));


            this.tblPage.Controls.Add(
                this.tblForm,
                1,
                0);


            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.Text =
                "Create an Account";

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblTitle.Margin =
                new Padding(
                    10,
                    5,
                    10,
                    3);


            this.tblForm.Controls.Add(
                this.lblTitle,
                0,
                0);

            this.tblForm.SetColumnSpan(
                this.lblTitle,
                2);


            // =====================================================
            // SUBTITLE
            // =====================================================

            this.lblSubtitle.Text =
                "Create your municipal services account.";

            this.lblSubtitle.AutoSize =
                true;

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(
                    90,
                    105,
                    120);

            this.lblSubtitle.Margin =
                new Padding(
                    12,
                    0,
                    10,
                    25);


            this.tblForm.Controls.Add(
                this.lblSubtitle,
                0,
                1);

            this.tblForm.SetColumnSpan(
                this.lblSubtitle,
                2);


            // =====================================================
            // FIRST NAME
            // =====================================================

            Panel firstNamePanel =
                CreateFieldPanel(
                    "First Name *",
                    this.lblFirstName,
                    this.txtFirstName,
                    this.lblFirstNameError);


            this.tblForm.Controls.Add(
                firstNamePanel,
                0,
                2);


            // =====================================================
            // LAST NAME
            // =====================================================

            Panel lastNamePanel =
                CreateFieldPanel(
                    "Last Name *",
                    this.lblLastName,
                    this.txtLastName,
                    this.lblLastNameError);


            this.tblForm.Controls.Add(
                lastNamePanel,
                1,
                2);


            // =====================================================
            // EMAIL
            // =====================================================

            Panel emailPanel =
                CreateFieldPanel(
                    "Email Address *",
                    this.lblEmail,
                    this.txtEmail,
                    this.lblEmailError);


            this.tblForm.Controls.Add(
                emailPanel,
                0,
                3);


            // =====================================================
            // PHONE
            // =====================================================

            Panel phonePanel =
                CreateFieldPanel(
                    "Phone Number *",
                    this.lblPhone,
                    this.txtPhone,
                    this.lblPhoneError);


            this.tblForm.Controls.Add(
                phonePanel,
                1,
                3);


            // =====================================================
            // ADDRESS
            //
            // Address remains full width because this is
            // appropriate for a longer street address.
            // =====================================================

            Panel addressPanel =
                CreateFieldPanel(
                    "Residential Address *",
                    this.lblAddress,
                    this.txtAddress,
                    this.lblAddressError);


            this.tblForm.Controls.Add(
                addressPanel,
                0,
                4);

            this.tblForm.SetColumnSpan(
                addressPanel,
                2);


            // =====================================================
            // SUBURB
            // =====================================================

            Panel suburbPanel =
                CreateFieldPanel(
                    "Suburb *",
                    this.lblSuburb,
                    this.txtSuburb,
                    this.lblSuburbError);


            this.tblForm.Controls.Add(
                suburbPanel,
                0,
                5);


            // =====================================================
            // CITY
            // =====================================================

            Panel cityPanel =
                CreateFieldPanel(
                    "City / Area *",
                    this.lblCity,
                    this.txtCity,
                    this.lblCityError);


            this.tblForm.Controls.Add(
                cityPanel,
                1,
                5);


            // =====================================================
            // POSTAL CODE
            // =====================================================

            Panel postalPanel =
                CreateFieldPanel(
                    "Postal Code *",
                    this.lblPostalCode,
                    this.txtPostalCode,
                    this.lblPostalCodeError);


            this.tblForm.Controls.Add(
                postalPanel,
                0,
                6);


            // =====================================================
            // EMPTY SPACE NEXT TO POSTAL CODE
            // =====================================================

            Panel postalEmptyPanel =
                new Panel();

            postalEmptyPanel.Dock =
                DockStyle.Fill;

            postalEmptyPanel.Margin =
                new Padding(
                    12,
                    8,
                    12,
                    8);


            this.tblForm.Controls.Add(
                postalEmptyPanel,
                1,
                6);


            // =====================================================
            // PASSWORD
            // =====================================================

            this.txtPassword.UseSystemPasswordChar =
                true;


            Panel passwordPanel =
                CreateFieldPanel(
                    "Password *",
                    this.lblPassword,
                    this.txtPassword,
                    this.lblPasswordError);


            this.tblForm.Controls.Add(
                passwordPanel,
                0,
                7);


            // =====================================================
            // CONFIRM PASSWORD
            // =====================================================

            this.txtConfirmPassword.UseSystemPasswordChar =
                true;


            Panel confirmPasswordPanel =
                CreateFieldPanel(
                    "Confirm Password *",
                    this.lblConfirmPassword,
                    this.txtConfirmPassword,
                    this.lblConfirmPasswordError);


            this.tblForm.Controls.Add(
                confirmPasswordPanel,
                1,
                7);


            // =====================================================
            // TERMS PANEL
            // =====================================================

            Panel termsPanel =
                new Panel();

            termsPanel.Dock =
                DockStyle.Fill;

            termsPanel.Height =
                75;

            termsPanel.Margin =
                new Padding(
                    12,
                    10,
                    12,
                    5);


            this.chkTerms.Text =
                "I agree to the Terms and Conditions and Privacy Policy.";

            this.chkTerms.AutoSize =
                true;

            this.chkTerms.Location =
                new Point(
                    0,
                    8);

            this.chkTerms.ForeColor =
                Color.FromArgb(
                    60,
                    70,
                    80);


            this.lblTermsError.Location =
                new Point(
                    0,
                    38);

            ConfigureErrorLabel(
                this.lblTermsError);


            termsPanel.Controls.Add(
                this.chkTerms);

            termsPanel.Controls.Add(
                this.lblTermsError);


            this.tblForm.Controls.Add(
                termsPanel,
                0,
                8);

            this.tblForm.SetColumnSpan(
                termsPanel,
                2);


            // =====================================================
            // BUTTON TABLE
            // =====================================================

            TableLayoutPanel buttonTable =
                new TableLayoutPanel();

            buttonTable.Dock =
                DockStyle.Fill;

            buttonTable.Height =
                70;

            buttonTable.ColumnCount =
                2;

            buttonTable.RowCount =
                1;

            buttonTable.Margin =
                new Padding(
                    12,
                    5,
                    12,
                    10);


            buttonTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            buttonTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));


            // =====================================================
            // BACK BUTTON
            // =====================================================

            this.btnBack.Text =
                "←  Back to Sign In";

            this.btnBack.Dock =
                DockStyle.Fill;

            this.btnBack.Margin =
                new Padding(
                    0,
                    7,
                    8,
                    7);

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

            this.btnBack.FlatAppearance.BorderSize =
                1;

            this.btnBack.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.btnBack.Cursor =
                Cursors.Hand;


            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click);


            // =====================================================
            // CREATE ACCOUNT BUTTON
            // =====================================================

            this.btnCreateAccount.Text =
                "Create Account";

            this.btnCreateAccount.Dock =
                DockStyle.Fill;

            this.btnCreateAccount.Margin =
                new Padding(
                    8,
                    7,
                    0,
                    7);

            this.btnCreateAccount.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnCreateAccount.ForeColor =
                Color.White;

            this.btnCreateAccount.FlatStyle =
                FlatStyle.Flat;

            this.btnCreateAccount.FlatAppearance.BorderSize =
                0;

            this.btnCreateAccount.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.btnCreateAccount.Cursor =
                Cursors.Hand;


            this.btnCreateAccount.Click +=
                new System.EventHandler(
                    this.btnCreateAccount_Click);


            buttonTable.Controls.Add(
                this.btnBack,
                0,
                0);

            buttonTable.Controls.Add(
                this.btnCreateAccount,
                1,
                0);


            this.tblForm.Controls.Add(
                buttonTable,
                0,
                9);

            this.tblForm.SetColumnSpan(
                buttonTable,
                2);


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
            // ADD MAIN CONTROLS
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
        // CREATE CONSISTENT MODERN INPUT FIELD
        //
        // Each field now has:
        //
        // Label
        // [ taller input container ]
        // Error message
        //
        // This fixes the old small 28px TextBoxes.
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
                112;

            panel.MinimumSize =
                new Size(
                    0,
                    112);

            panel.Margin =
                new Padding(
                    12,
                    6,
                    12,
                    6);


            // =====================================================
            // LABEL
            // =====================================================

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


            // =====================================================
            // INPUT CONTAINER
            //
            // WinForms single-line TextBoxes do not naturally
            // become visually tall just by changing Height.
            //
            // The outer panel creates the modern field height.
            // =====================================================

            Panel inputContainer =
                new Panel();


            inputContainer.Location =
                new Point(
                    0,
                    26);

            inputContainer.Height =
                48;

            inputContainer.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            inputContainer.Width =
                panel.ClientSize.Width;

            inputContainer.BackColor =
                Color.White;

            inputContainer.BorderStyle =
                BorderStyle.FixedSingle;

            inputContainer.Padding =
                new Padding(
                    11,
                    11,
                    11,
                    7);


            // =====================================================
            // TEXTBOX
            // =====================================================

            textBox.Dock =
                DockStyle.Fill;

            textBox.BorderStyle =
                BorderStyle.None;

            textBox.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            textBox.BackColor =
                Color.White;


            inputContainer.Controls.Add(
                textBox);


            // =====================================================
            // ERROR
            // =====================================================

            errorLabel.Location =
                new Point(
                    2,
                    80);

            ConfigureErrorLabel(
                errorLabel);


            // =====================================================
            // ADD CONTROLS
            // =====================================================

            panel.Controls.Add(
                label);

            panel.Controls.Add(
                inputContainer);

            panel.Controls.Add(
                errorLabel);


            return panel;
        }


        // =========================================================
        // ERROR LABEL
        // =========================================================

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

            label.Text =
                "";

            label.Visible =
                false;
        }


        // =========================================================
        // FOOTER COLOUR
        // =========================================================

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