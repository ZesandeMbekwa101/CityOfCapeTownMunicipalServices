using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblHeaderSlogan;

        private TableLayoutPanel mainLayout;

        private Panel pnlLogin;
        private Panel pnlCommunity;

        private TableLayoutPanel loginOuterLayout;
        private TableLayoutPanel loginFormLayout;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblEmail;
        private Panel pnlEmailInput;
        private TextBox txtEmail;
        private Label lblEmailError;

        private Label lblPassword;
        private Panel pnlPasswordInput;
        private TextBox txtPassword;
        private Label lblPasswordError;

        private CheckBox chkRemember;
        private LinkLabel lnkForgotPassword;

        private Button btnSignIn;

        private Label lblNoAccount;
        private Button btnCreateAccount;

        private PictureBox picCommunity;
        private Panel pnlCommunityText;
        private Label lblCommunityTitle;
        private Label lblCommunityDescription;
        private Label lblCommunityFeature1;
        private Label lblCommunityFeature2;
        private Label lblCommunityFeature3;

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

            this.lblHeaderSlogan =
                new Label();

            this.mainLayout =
                new TableLayoutPanel();

            this.pnlLogin =
                new Panel();

            this.pnlCommunity =
                new Panel();

            this.loginOuterLayout =
                new TableLayoutPanel();

            this.loginFormLayout =
                new TableLayoutPanel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblEmail =
                new Label();

            this.pnlEmailInput =
                new Panel();

            this.txtEmail =
                new TextBox();

            this.lblEmailError =
                new Label();

            this.lblPassword =
                new Label();

            this.pnlPasswordInput =
                new Panel();

            this.txtPassword =
                new TextBox();

            this.lblPasswordError =
                new Label();

            this.chkRemember =
                new CheckBox();

            this.lnkForgotPassword =
                new LinkLabel();

            this.btnSignIn =
                new Button();

            this.lblNoAccount =
                new Label();

            this.btnCreateAccount =
                new Button();

            this.picCommunity =
                new PictureBox();

            this.pnlCommunityText =
                new Panel();

            this.lblCommunityTitle =
                new Label();

            this.lblCommunityDescription =
                new Label();

            this.lblCommunityFeature1 =
                new Label();

            this.lblCommunityFeature2 =
                new Label();

            this.lblCommunityFeature3 =
                new Label();

            this.colourStrip =
                new TableLayoutPanel();


            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "City of Cape Town - Sign In";

            this.ClientSize =
                new Size(
                    1100,
                    720);

            this.MinimumSize =
                new Size(
                    900,
                    620);

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

            this.picLogo.Size =
                new Size(
                    70,
                    65);

            this.picLogo.Location =
                new Point(
                    30,
                    12);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;


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

            this.lblHeaderSlogan.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblHeaderSlogan.Size =
                new Size(
                    240,
                    50);

            this.lblHeaderSlogan.Location =
                new Point(
                    825,
                    20);


            this.pnlHeader.Controls.Add(
                this.picLogo);

            this.pnlHeader.Controls.Add(
                this.lblHeaderSlogan);


            // =====================================================
            // MAIN LAYOUT
            // =====================================================

            this.mainLayout.Dock =
                DockStyle.Fill;

            this.mainLayout.Padding =
                new Padding(
                    45,
                    35,
                    45,
                    30);

            this.mainLayout.ColumnCount =
                2;

            this.mainLayout.RowCount =
                1;

            this.mainLayout.BackColor =
                Color.FromArgb(
                    247,
                    250,
                    252);


            // Login gets slightly more space.
            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    57F));

            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    43F));

            this.mainLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));


            // =====================================================
            // LOGIN PANEL
            // =====================================================

            this.pnlLogin.Dock =
                DockStyle.Fill;

            this.pnlLogin.Margin =
                new Padding(
                    0,
                    0,
                    30,
                    0);

            this.pnlLogin.BackColor =
                Color.White;

            this.pnlLogin.AutoScroll =
                true;


            this.mainLayout.Controls.Add(
                this.pnlLogin,
                0,
                0);


            // =====================================================
            // LOGIN OUTER LAYOUT
            //
            // Keeps the form a comfortable width instead of
            // stretching fields across the whole panel.
            // =====================================================

            this.loginOuterLayout.Dock =
                DockStyle.Top;

            this.loginOuterLayout.Height =
                575;

            this.loginOuterLayout.ColumnCount =
                3;

            this.loginOuterLayout.RowCount =
                1;


            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    8F));

            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    84F));

            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    8F));


            this.loginOuterLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));


            this.pnlLogin.Controls.Add(
                this.loginOuterLayout);


            // =====================================================
            // LOGIN FORM LAYOUT
            // =====================================================

            this.loginFormLayout.Dock =
                DockStyle.Fill;

            this.loginFormLayout.ColumnCount =
                1;

            this.loginFormLayout.RowCount =
                11;

            this.loginFormLayout.Padding =
                new Padding(
                    0,
                    45,
                    0,
                    0);


            // Explicit row heights stop the inputs from
            // appearing too high or being squeezed together.

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    55F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    30F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    52F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    32F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    30F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    52F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    32F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    42F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    65F));

            this.loginFormLayout.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    95F));


            this.loginOuterLayout.Controls.Add(
                this.loginFormLayout,
                1,
                0);


            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.Text =
                "Sign In";

            this.lblTitle.Dock =
                DockStyle.Fill;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    23F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblTitle.TextAlign =
                ContentAlignment.BottomLeft;


            this.loginFormLayout.Controls.Add(
                this.lblTitle,
                0,
                0);


            // =====================================================
            // SUBTITLE
            // =====================================================

            this.lblSubtitle.Text =
                "Welcome back! Please sign in to continue.";

            this.lblSubtitle.Dock =
                DockStyle.Fill;

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(
                    90,
                    105,
                    120);

            this.lblSubtitle.TextAlign =
                ContentAlignment.TopLeft;

            this.lblSubtitle.Padding =
                new Padding(
                    2,
                    4,
                    0,
                    0);


            this.loginFormLayout.Controls.Add(
                this.lblSubtitle,
                0,
                1);


            // =====================================================
            // EMAIL LABEL
            // =====================================================

            this.lblEmail.Text =
                "Email Address *";

            this.lblEmail.Dock =
                DockStyle.Fill;

            this.lblEmail.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblEmail.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblEmail.TextAlign =
                ContentAlignment.BottomLeft;

            this.lblEmail.Padding =
                new Padding(
                    0,
                    0,
                    0,
                    5);


            this.loginFormLayout.Controls.Add(
                this.lblEmail,
                0,
                2);


            // =====================================================
            // EMAIL INPUT CONTAINER
            //
            // The panel gives the TextBox a proper modern height.
            // =====================================================

            this.pnlEmailInput.Dock =
                DockStyle.Fill;

            this.pnlEmailInput.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    3);

            this.pnlEmailInput.Padding =
                new Padding(
                    12,
                    12,
                    12,
                    8);

            this.pnlEmailInput.BackColor =
                Color.White;

            this.pnlEmailInput.BorderStyle =
                BorderStyle.FixedSingle;


            this.txtEmail.Dock =
                DockStyle.Fill;

            this.txtEmail.BorderStyle =
                BorderStyle.None;

            this.txtEmail.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            this.txtEmail.BackColor =
                Color.White;


            this.pnlEmailInput.Controls.Add(
                this.txtEmail);


            this.loginFormLayout.Controls.Add(
                this.pnlEmailInput,
                0,
                3);


            // =====================================================
            // EMAIL ERROR
            // =====================================================

            this.lblEmailError.Text =
                "";

            this.lblEmailError.Dock =
                DockStyle.Fill;

            this.lblEmailError.ForeColor =
                Color.Firebrick;

            this.lblEmailError.Font =
                new Font(
                    "Segoe UI",
                    8F);

            this.lblEmailError.Visible =
                false;

            this.lblEmailError.TextAlign =
                ContentAlignment.TopLeft;

            this.lblEmailError.Padding =
                new Padding(
                    2,
                    3,
                    0,
                    0);


            this.loginFormLayout.Controls.Add(
                this.lblEmailError,
                0,
                4);


            // =====================================================
            // PASSWORD LABEL
            // =====================================================

            this.lblPassword.Text =
                "Password *";

            this.lblPassword.Dock =
                DockStyle.Fill;

            this.lblPassword.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblPassword.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblPassword.TextAlign =
                ContentAlignment.BottomLeft;

            this.lblPassword.Padding =
                new Padding(
                    0,
                    0,
                    0,
                    5);


            this.loginFormLayout.Controls.Add(
                this.lblPassword,
                0,
                5);


            // =====================================================
            // PASSWORD INPUT CONTAINER
            // =====================================================

            this.pnlPasswordInput.Dock =
                DockStyle.Fill;

            this.pnlPasswordInput.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    3);

            this.pnlPasswordInput.Padding =
                new Padding(
                    12,
                    12,
                    12,
                    8);

            this.pnlPasswordInput.BackColor =
                Color.White;

            this.pnlPasswordInput.BorderStyle =
                BorderStyle.FixedSingle;


            this.txtPassword.Dock =
                DockStyle.Fill;

            this.txtPassword.BorderStyle =
                BorderStyle.None;

            this.txtPassword.Font =
                new Font(
                    "Segoe UI",
                    10.5F);

            this.txtPassword.BackColor =
                Color.White;

            this.txtPassword.UseSystemPasswordChar =
                true;


            this.pnlPasswordInput.Controls.Add(
                this.txtPassword);


            this.loginFormLayout.Controls.Add(
                this.pnlPasswordInput,
                0,
                6);


            // =====================================================
            // PASSWORD ERROR
            // =====================================================

            this.lblPasswordError.Text =
                "";

            this.lblPasswordError.Dock =
                DockStyle.Fill;

            this.lblPasswordError.ForeColor =
                Color.Firebrick;

            this.lblPasswordError.Font =
                new Font(
                    "Segoe UI",
                    8F);

            this.lblPasswordError.Visible =
                false;

            this.lblPasswordError.TextAlign =
                ContentAlignment.TopLeft;

            this.lblPasswordError.Padding =
                new Padding(
                    2,
                    3,
                    0,
                    0);


            this.loginFormLayout.Controls.Add(
                this.lblPasswordError,
                0,
                7);


            // =====================================================
            // OPTIONS
            // =====================================================

            TableLayoutPanel optionsTable =
                new TableLayoutPanel();

            optionsTable.Dock =
                DockStyle.Fill;

            optionsTable.ColumnCount =
                2;

            optionsTable.RowCount =
                1;

            optionsTable.Margin =
                new Padding(0);


            optionsTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            optionsTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));


            this.chkRemember.Text =
                "Remember me";

            this.chkRemember.AutoSize =
                true;

            this.chkRemember.Anchor =
                AnchorStyles.Left;

            this.chkRemember.ForeColor =
                Color.FromArgb(
                    70,
                    85,
                    100);


            this.lnkForgotPassword.Text =
                "Forgot password?";

            this.lnkForgotPassword.AutoSize =
                true;

            this.lnkForgotPassword.Anchor =
                AnchorStyles.Right;

            this.lnkForgotPassword.LinkColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.lnkForgotPassword.ActiveLinkColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lnkForgotPassword.LinkBehavior =
                LinkBehavior.HoverUnderline;


            optionsTable.Controls.Add(
                this.chkRemember,
                0,
                0);

            optionsTable.Controls.Add(
                this.lnkForgotPassword,
                1,
                0);


            this.loginFormLayout.Controls.Add(
                optionsTable,
                0,
                8);


            // =====================================================
            // SIGN IN BUTTON
            // =====================================================

            this.btnSignIn.Text =
                "Sign In";

            this.btnSignIn.Dock =
                DockStyle.Top;

            this.btnSignIn.Height =
                48;

            this.btnSignIn.Margin =
                new Padding(
                    0,
                    6,
                    0,
                    8);

            this.btnSignIn.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnSignIn.ForeColor =
                Color.White;

            this.btnSignIn.FlatStyle =
                FlatStyle.Flat;

            this.btnSignIn.FlatAppearance.BorderSize =
                0;

            this.btnSignIn.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.btnSignIn.Cursor =
                Cursors.Hand;


            this.btnSignIn.Click +=
                new System.EventHandler(
                    this.btnSignIn_Click);


            this.loginFormLayout.Controls.Add(
                this.btnSignIn,
                0,
                9);


            // =====================================================
            // CREATE ACCOUNT AREA
            // =====================================================

            Panel accountPanel =
                new Panel();

            accountPanel.Dock =
                DockStyle.Fill;

            accountPanel.Padding =
                new Padding(
                    0,
                    5,
                    0,
                    0);


            this.lblNoAccount.Text =
                "Don't have an account?";

            this.lblNoAccount.Dock =
                DockStyle.Top;

            this.lblNoAccount.Height =
                30;

            this.lblNoAccount.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblNoAccount.ForeColor =
                Color.Gray;


            this.btnCreateAccount.Text =
                "Create an Account";

            this.btnCreateAccount.Dock =
                DockStyle.Bottom;

            this.btnCreateAccount.Height =
                45;

            this.btnCreateAccount.BackColor =
                Color.White;

            this.btnCreateAccount.ForeColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnCreateAccount.FlatStyle =
                FlatStyle.Flat;

            this.btnCreateAccount.FlatAppearance.BorderColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnCreateAccount.FlatAppearance.BorderSize =
                1;

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


            accountPanel.Controls.Add(
                this.lblNoAccount);

            accountPanel.Controls.Add(
                this.btnCreateAccount);


            this.loginFormLayout.Controls.Add(
                accountPanel,
                0,
                10);


            // =====================================================
            // RIGHT COMMUNITY PANEL
            // =====================================================

            this.pnlCommunity.Dock =
                DockStyle.Fill;

            this.pnlCommunity.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    0);

            this.pnlCommunity.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            this.mainLayout.Controls.Add(
                this.pnlCommunity,
                1,
                0);


            // =====================================================
            // COMMUNITY IMAGE
            //
            // Uses the skyline resource already in your project.
            // =====================================================

            this.picCommunity.Dock =
                DockStyle.Top;

            this.picCommunity.Height =
                210;

            this.picCommunity.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picCommunity.BackColor =
                Color.White;

            this.picCommunity.Image =
                Properties.Resources.cape_town_skyline;


            // =====================================================
            // COMMUNITY TEXT AREA
            // =====================================================

            this.pnlCommunityText.Dock =
                DockStyle.Fill;

            this.pnlCommunityText.Padding =
                new Padding(
                    35,
                    25,
                    35,
                    20);

            this.pnlCommunityText.BackColor =
                Color.FromArgb(
                    0,
                    59,
                    113);


            // TITLE

            this.lblCommunityTitle.Text =
                "Your City. Your Community.";

            this.lblCommunityTitle.Dock =
                DockStyle.Top;

            this.lblCommunityTitle.Height =
                50;

            this.lblCommunityTitle.Font =
                new Font(
                    "Segoe UI",
                    17F,
                    FontStyle.Bold);

            this.lblCommunityTitle.ForeColor =
                Color.White;

            this.lblCommunityTitle.TextAlign =
                ContentAlignment.MiddleLeft;


            // DESCRIPTION

            this.lblCommunityDescription.Text =
                "Access City of Cape Town municipal services from one convenient place.";

            this.lblCommunityDescription.Dock =
                DockStyle.Top;

            this.lblCommunityDescription.Height =
                70;

            this.lblCommunityDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.lblCommunityDescription.ForeColor =
                Color.FromArgb(
                    225,
                    238,
                    248);

            this.lblCommunityDescription.TextAlign =
                ContentAlignment.TopLeft;


            // FEATURE 1

            this.lblCommunityFeature1.Text =
                "✓   Report municipal issues";

            this.lblCommunityFeature1.Dock =
                DockStyle.Top;

            this.lblCommunityFeature1.Height =
                42;

            this.lblCommunityFeature1.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblCommunityFeature1.ForeColor =
                Color.White;

            this.lblCommunityFeature1.TextAlign =
                ContentAlignment.MiddleLeft;


            // FEATURE 2

            this.lblCommunityFeature2.Text =
                "✓   Discover local events";

            this.lblCommunityFeature2.Dock =
                DockStyle.Top;

            this.lblCommunityFeature2.Height =
                42;

            this.lblCommunityFeature2.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblCommunityFeature2.ForeColor =
                Color.White;

            this.lblCommunityFeature2.TextAlign =
                ContentAlignment.MiddleLeft;


            // FEATURE 3

            this.lblCommunityFeature3.Text =
                "✓   Stay informed about your community";

            this.lblCommunityFeature3.Dock =
                DockStyle.Top;

            this.lblCommunityFeature3.Height =
                42;

            this.lblCommunityFeature3.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblCommunityFeature3.ForeColor =
                Color.White;

            this.lblCommunityFeature3.TextAlign =
                ContentAlignment.MiddleLeft;


            // IMPORTANT:
            // Add in reverse order because DockStyle.Top
            // uses control z-order.

            this.pnlCommunityText.Controls.Add(
                this.lblCommunityFeature3);

            this.pnlCommunityText.Controls.Add(
                this.lblCommunityFeature2);

            this.pnlCommunityText.Controls.Add(
                this.lblCommunityFeature1);

            this.pnlCommunityText.Controls.Add(
                this.lblCommunityDescription);

            this.pnlCommunityText.Controls.Add(
                this.lblCommunityTitle);


            this.pnlCommunity.Controls.Add(
                this.pnlCommunityText);

            this.pnlCommunity.Controls.Add(
                this.picCommunity);


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
            // ADD MAIN CONTROLS
            // =====================================================

            this.Controls.Add(
                this.mainLayout);

            this.Controls.Add(
                this.colourStrip);

            this.Controls.Add(
                this.pnlHeader);


            this.pnlHeader.BringToFront();

            this.colourStrip.BringToFront();


            this.ResumeLayout(false);
        }


        // =====================================================
        // FOOTER COLOUR
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