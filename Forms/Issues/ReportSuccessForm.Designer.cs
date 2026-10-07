using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    partial class ReportSuccessForm
    {
        private System.ComponentModel.IContainer components;

        private Label lblIcon;
        private Label lblTitle;
        private Label lblMessage;

        private Panel pnlReference;
        private Label lblReferenceTitle;
        private Label lblReferenceNumber;

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

            this.pnlReference =
                new Panel();

            this.lblReferenceTitle =
                new Label();

            this.lblReferenceNumber =
                new Label();

            this.btnOK =
                new Button();


            // FORM

            this.Text =
                "Report Submitted";

            this.ClientSize =
                new Size(
                    500,
                    380);

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
                "✓";

            this.lblIcon.Font =
                new Font(
                    "Segoe UI",
                    34F,
                    FontStyle.Bold);

            this.lblIcon.ForeColor =
                Color.FromArgb(
                    20,
                    170,
                    80);

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
                "Report Submitted Successfully!";

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    14F,
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
                    35);


            // MESSAGE

            this.lblMessage.Text =
                "Thank you for helping improve your community.\n" +
                "Your report has been recorded and will assist the\n" +
                "municipality in identifying service delivery issues.";

            this.lblMessage.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblMessage.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblMessage.Location =
                new Point(
                    35,
                    135);

            this.lblMessage.Size =
                new Size(
                    430,
                    70);


            // REFERENCE PANEL

            this.pnlReference.Location =
                new Point(
                    75,
                    215);

            this.pnlReference.Size =
                new Size(
                    350,
                    70);

            this.pnlReference.BackColor =
                Color.FromArgb(
                    240,
                    250,
                    242);

            this.pnlReference.BorderStyle =
                BorderStyle.FixedSingle;


            this.lblReferenceTitle.Text =
                "Reference Number:";

            this.lblReferenceTitle.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblReferenceTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblReferenceTitle.Dock =
                DockStyle.Top;

            this.lblReferenceTitle.Height =
                28;


            this.lblReferenceNumber.Text =
                "CT-2026-00001";

            this.lblReferenceNumber.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            this.lblReferenceNumber.ForeColor =
                Color.FromArgb(
                    0,
                    59,
                    113);

            this.lblReferenceNumber.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblReferenceNumber.Dock =
                DockStyle.Fill;


            this.pnlReference.Controls.Add(
                this.lblReferenceNumber);

            this.pnlReference.Controls.Add(
                this.lblReferenceTitle);


            // OK

            this.btnOK.Text =
                "OK";

            this.btnOK.Location =
                new Point(
                    175,
                    310);

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
                this.pnlReference);

            this.Controls.Add(
                this.btnOK);
        }
    }
}