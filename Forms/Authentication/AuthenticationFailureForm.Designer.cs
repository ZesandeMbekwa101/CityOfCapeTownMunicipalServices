using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    partial class AuthenticationFailureForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlCard;
        private Panel pnlIcon;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblMessage;
        private Button btnTryAgain;
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
            this.components =
                new System.ComponentModel.Container();

            this.pnlCard =
                new Panel();

            this.pnlIcon =
                new Panel();

            this.lblIcon =
                new Label();

            this.lblTitle =
                new Label();

            this.lblMessage =
                new Label();

            this.btnTryAgain =
                new Button();

            this.colourStrip =
                new TableLayoutPanel();

            this.SuspendLayout();


            // =====================================================
            // FORM
            // =====================================================

            this.Text =
                "Unable to Continue";

            this.ClientSize =
                new Size(500, 400);

            this.MinimumSize =
                new Size(500, 400);

            this.MaximumSize =
                new Size(500, 400);

            this.StartPosition =
                FormStartPosition.CenterParent;

            this.FormBorderStyle =
                FormBorderStyle.FixedDialog;

            this.MaximizeBox =
                false;

            this.MinimizeBox =
                false;

            this.ShowInTaskbar =
                false;

            this.BackColor =
                Color.FromArgb(
                    245,
                    249,
                    252);

            this.Font =
                new Font(
                    "Segoe UI",
                    9F);


            // =====================================================
            // CARD
            // =====================================================

            this.pnlCard.Location =
                new Point(35, 30);

            this.pnlCard.Size =
                new Size(430, 320);

            this.pnlCard.BackColor =
                Color.White;

            this.pnlCard.BorderStyle =
                BorderStyle.FixedSingle;


            // =====================================================
            // ERROR ICON
            // =====================================================

            this.pnlIcon.Location =
                new Point(165, 30);

            this.pnlIcon.Size =
                new Size(100, 100);

            this.pnlIcon.BackColor =
                Color.FromArgb(
                    200,
                    45,
                    45);


            this.lblIcon.Text =
                "×";

            this.lblIcon.Dock =
                DockStyle.Fill;

            this.lblIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblIcon.Font =
                new Font(
                    "Segoe UI",
                    42F,
                    FontStyle.Bold);

            this.lblIcon.ForeColor =
                Color.White;

            this.pnlIcon.Controls.Add(
                this.lblIcon);


            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.Text =
                "Unable to Continue";

            this.lblTitle.Location =
                new Point(25, 150);

            this.lblTitle.Size =
                new Size(380, 40);

            this.lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    200,
                    45,
                    45);


            // =====================================================
            // MESSAGE
            // =====================================================

            this.lblMessage.Text =
                "Something went wrong. Please try again.";

            this.lblMessage.Location =
                new Point(35, 195);

            this.lblMessage.Size =
                new Size(360, 50);

            this.lblMessage.TextAlign =
                ContentAlignment.TopCenter;

            this.lblMessage.Font =
                new Font(
                    "Segoe UI",
                    10F);

            this.lblMessage.ForeColor =
                Color.FromArgb(
                    80,
                    95,
                    110);


            // =====================================================
            // TRY AGAIN
            // =====================================================

            this.btnTryAgain.Text =
                "Try Again";

            this.btnTryAgain.Location =
                new Point(115, 255);

            this.btnTryAgain.Size =
                new Size(200, 45);

            this.btnTryAgain.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnTryAgain.ForeColor =
                Color.White;

            this.btnTryAgain.FlatStyle =
                FlatStyle.Flat;

            this.btnTryAgain.FlatAppearance.BorderSize =
                0;

            this.btnTryAgain.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.btnTryAgain.Cursor =
                Cursors.Hand;

            this.btnTryAgain.Click +=
                new System.EventHandler(
                    this.btnTryAgain_Click);


            // =====================================================
            // ADD CARD CONTROLS
            // =====================================================

            this.pnlCard.Controls.Add(
                this.pnlIcon);

            this.pnlCard.Controls.Add(
                this.lblTitle);

            this.pnlCard.Controls.Add(
                this.lblMessage);

            this.pnlCard.Controls.Add(
                this.btnTryAgain);


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
                Color.FromArgb(166, 206, 57),
                0);

            AddColour(
                Color.FromArgb(255, 215, 0),
                1);

            AddColour(
                Color.FromArgb(0, 119, 200),
                2);

            AddColour(
                Color.FromArgb(230, 0, 126),
                3);


            this.Controls.Add(
                this.pnlCard);

            this.Controls.Add(
                this.colourStrip);

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