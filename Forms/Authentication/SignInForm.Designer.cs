using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components;

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
        private TextBox txtEmail;
        private Label lblEmailError;

        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordError;

        private CheckBox chkRemember;
        private LinkLabel lnkForgotPassword;

        private Button btnSignIn;

        private Label lblNoAccount;
        private Button btnCreateAccount;

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

            this.txtEmail =
                new TextBox();

            this.lblEmailError =
                new Label();

            this.lblPassword =
                new Label();

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
                    1050,
                    700);

            this.MinimumSize =
                new Size(
                    850,
                    600);

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

            this.picLogo.Size =
                new Size(
                    70,
                    70);

            this.picLogo.Location =
                new Point(
                    30,
                    15);

            this.picLogo.SizeMode =
                PictureBoxSizeMode.Zoom;

            this.picLogo.Image =
                Properties.Resources.city_logo;

            this.pnlHeader.Controls.Add(
                this.picLogo);


            // SLOGAN

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
                    230,
                    50);

            this.lblHeaderSlogan.Location =
                new Point(
                    780,
                    25);

            this.pnlHeader.Controls.Add(
                this.lblHeaderSlogan);


            // =====================================================
            // MAIN LAYOUT
            // =====================================================

            this.mainLayout.Dock =
                DockStyle.Fill;

            this.mainLayout.Padding =
                new Padding(
                    35,
                    35,
                    35,
                    35);

            this.mainLayout.ColumnCount =
                2;

            this.mainLayout.RowCount =
                1;

            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    62F));

            this.mainLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    38F));


            // =====================================================
            // LOGIN PANEL
            // =====================================================

            this.pnlLogin.Dock =
                DockStyle.Fill;

            this.pnlLogin.AutoScroll =
                true;

            this.pnlLogin.BackColor =
                Color.White;

            this.pnlLogin.Margin =
                new Padding(
                    0,
                    0,
                    20,
                    0);

            this.mainLayout.Controls.Add(
                this.pnlLogin,
                0,
                0);


            // =====================================================
            // LOGIN OUTER LAYOUT
            //
            // Creates margins around the actual login form.
            // =====================================================

            this.loginOuterLayout.Dock =
                DockStyle.Top;

            this.loginOuterLayout.Height =
                530;

            this.loginOuterLayout.ColumnCount =
                3;

            this.loginOuterLayout.RowCount =
                1;

            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    5F));

            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    90F));

            this.loginOuterLayout.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    5F));

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
                    10,
                    0,
                    0);

            this.loginOuterLayout.Controls.Add(
                this.loginFormLayout,
                1,
                0);


            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.Text =
                "Sign In";

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    3);

            this.loginFormLayout.Controls.Add(
                this.lblTitle,
                0,
                0);


            // =====================================================
            // SUBTITLE
            // =====================================================

            this.lblSubtitle.Text =
                "Welcome back! Please sign in to continue.";

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    11F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(
                    80,
                    100,
                    120);

            this.lblSubtitle.AutoSize =
                true;

            this.lblSubtitle.Margin =
                new Padding(
                    2,
                    0,
                    0,
                    25);

            this.loginFormLayout.Controls.Add(
                this.lblSubtitle,
                0,
                1);


            // =====================================================
            // EMAIL LABEL
            // =====================================================

            this.lblEmail.Text =
                "Email Address *";

            this.lblEmail.AutoSize =
                true;

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

            this.lblEmail.Margin =
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
            // EMAIL TEXTBOX
            // =====================================================

            this.txtEmail.Dock =
                DockStyle.Top;

            this.txtEmail.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.txtEmail.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    2);

            this.loginFormLayout.Controls.Add(
                this.txtEmail,
                0,
                3);


            // EMAIL ERROR

            this.lblEmailError.Text =
                "";

            this.lblEmailError.AutoSize =
                true;

            this.lblEmailError.ForeColor =
                Color.Firebrick;

            this.lblEmailError.Font =
                new Font(
                    "Segoe UI",
                    8F);

            this.lblEmailError.Visible =
                false;

            this.lblEmailError.Margin =
                new Padding(
                    0,
                    3,
                    0,
                    15);

            this.loginFormLayout.Controls.Add(
                this.lblEmailError,
                0,
                4);


            // =====================================================
            // PASSWORD LABEL
            // =====================================================

            this.lblPassword.Text =
                "Password *";

            this.lblPassword.AutoSize =
                true;

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

            this.lblPassword.Margin =
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
            // PASSWORD TEXTBOX
            // =====================================================

            this.txtPassword.Dock =
                DockStyle.Top;

            this.txtPassword.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.txtPassword.UseSystemPasswordChar =
                true;

            this.txtPassword.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    2);

            this.loginFormLayout.Controls.Add(
                this.txtPassword,
                0,
                6);


            // PASSWORD ERROR

            this.lblPasswordError.Text =
                "";

            this.lblPasswordError.AutoSize =
                true;

            this.lblPasswordError.ForeColor =
                Color.Firebrick;

            this.lblPasswordError.Font =
                new Font(
                    "Segoe UI",
                    8F);

            this.lblPasswordError.Visible =
                false;

            this.lblPasswordError.Margin =
                new Padding(
                    0,
                    3,
                    0,
                    10);

            this.loginFormLayout.Controls.Add(
                this.lblPasswordError,
                0,
                7);


            // =====================================================
            // OPTIONS ROW
            // =====================================================

            TableLayoutPanel optionsTable =
                new TableLayoutPanel();

            optionsTable.Dock =
                DockStyle.Top;

            optionsTable.Height =
                35;

            optionsTable.ColumnCount =
                2;

            optionsTable.RowCount =
                1;

            optionsTable.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    15);

            optionsTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            optionsTable.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));


            // REMEMBER

            this.chkRemember.Text =
                "Remember me";

            this.chkRemember.AutoSize =
                true;

            this.chkRemember.Anchor =
                AnchorStyles.Left;


            // FORGOT PASSWORD

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

            this.btnSignIn.Margin =
                new Padding(
                    0,
                    0,
                    0,
                    20);

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
                DockStyle.Top;

            accountPanel.Height =
                90;


            this.lblNoAccount.Text =
                "Don't have an account?";

            this.lblNoAccount.Dock =
                DockStyle.Top;

            this.lblNoAccount.Height =
                28;

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
            // COMMUNITY PANEL
            // =====================================================

            this.pnlCommunity.Dock =
                DockStyle.Fill;

            this.pnlCommunity.BackColor =
                Color.FromArgb(
                    235,
                    247,
                    253);

            this.pnlCommunity.Margin =
                new Padding(
                    10,
                    30,
                    10,
                    60);

            this.mainLayout.Controls.Add(
                this.pnlCommunity,
                1,
                0);


            // COMMUNITY ICON

            Label communityIcon =
                new Label();

            communityIcon.Text =
                "👥";

            communityIcon.Font =
                new Font(
                    "Segoe UI Emoji",
                    35F);

            communityIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            communityIcon.Dock =
                DockStyle.Top;

            communityIcon.Height =
                110;

            this.pnlCommunity.Controls.Add(
                communityIcon);


            // COMMUNITY TITLE

            Label communityTitle =
                new Label();

            communityTitle.Text =
                "Join your community";

            communityTitle.Dock =
                DockStyle.Top;

            communityTitle.Height =
                50;

            communityTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            communityTitle.Font =
                new Font(
                    "Segoe UI",
                    13F,
                    FontStyle.Bold);

            communityTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.pnlCommunity.Controls.Add(
                communityTitle);

            communityTitle.BringToFront();


            // COMMUNITY TEXT

            Label communityText =
                new Label();

            communityText.Text =
                "Create an account to report issues,\n" +
                "track your service requests and stay\n" +
                "informed about municipal updates.";

            communityText.Dock =
                DockStyle.Fill;

            communityText.TextAlign =
                ContentAlignment.TopCenter;

            communityText.Padding =
                new Padding(
                    25,
                    20,
                    25,
                    20);

            communityText.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.pnlCommunity.Controls.Add(
                communityText);


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


            // =====================================================
            // FINISH
            // =====================================================

            this.ResumeLayout(false);
        }


        // =========================================================
        // ADD FOOTER COLOUR
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