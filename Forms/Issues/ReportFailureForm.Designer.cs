using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    partial class ReportFailureForm
    {
        private System.ComponentModel.IContainer components;

        private Label lblIcon;
        private Label lblTitle;
        private Label lblMessage;
        private Button btnOK;


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
            this.lblIcon =
                new Label();

            this.lblTitle =
                new Label();

            this.lblMessage =
                new Label();

            this.btnOK =
                new Button();


            // FORM

            this.Text =
                "Submission Failed";

            this.ClientSize =
                new Size(
                    500,
                    310);

            this.FormBorderStyle =
                FormBorderStyle.FixedDialog;

            this.StartPosition =
                FormStartPosition.CenterParent;

            this.MaximizeBox =
                false;

            this.MinimizeBox =
                false;

            this.BackColor =
                Color.White;


            // ICON

            this.lblIcon.Text =
                "!";

            this.lblIcon.Font =
                new Font(
                    "Segoe UI",
                    34F,
                    FontStyle.Bold);

            this.lblIcon.ForeColor =
                Color.FromArgb(
                    220,
                    45,
                    45);

            this.lblIcon.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblIcon.Location =
                new Point(
                    200,
                    20);

            this.lblIcon.Size =
                new Size(
                    100,
                    70);


            // TITLE

            this.lblTitle.Text =
                "Submission Failed";

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            this.lblTitle.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTitle.Location =
                new Point(
                    30,
                    95);

            this.lblTitle.Size =
                new Size(
                    440,
                    40);


            // MESSAGE

            this.lblMessage.Text =
                "There was a problem submitting your report.\n\n" +
                "Please check your details and try again.";

            this.lblMessage.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblMessage.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblMessage.Location =
                new Point(
                    40,
                    145);

            this.lblMessage.Size =
                new Size(
                    420,
                    75);


            // OK

            this.btnOK.Text =
                "OK";

            this.btnOK.Location =
                new Point(
                    175,
                    240);

            this.btnOK.Size =
                new Size(
                    150,
                    42);

            this.btnOK.BackColor =
                Color.FromArgb(
                    0,
                    119,
                    200);

            this.btnOK.ForeColor =
                Color.White;

            this.btnOK.FlatStyle =
                FlatStyle.Flat;

            this.btnOK.FlatAppearance.BorderSize =
                0;

            this.btnOK.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnOK.Cursor =
                Cursors.Hand;

            this.btnOK.Click +=
                this.btnOK_Click;


            // ADD

            this.Controls.Add(
                this.lblIcon);

            this.Controls.Add(
                this.lblTitle);

            this.Controls.Add(
                this.lblMessage);

            this.Controls.Add(
                this.btnOK);
        }
    }
}