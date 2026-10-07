using System.Drawing;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Helpers
{
    public static class ThemeHelper
    {
        // City branding colours
        public static readonly Color PrimaryBlue =
            Color.FromArgb(0, 59, 113);

        public static readonly Color SecondaryBlue =
            Color.FromArgb(0, 119, 200);

        public static readonly Color LightBlue =
            Color.FromArgb(235, 247, 253);

        public static readonly Color Green =
            Color.FromArgb(166, 206, 57);

        public static readonly Color Yellow =
            Color.FromArgb(255, 215, 0);

        public static readonly Color Pink =
            Color.FromArgb(230, 0, 126);

        public static readonly Color DarkText =
            Color.FromArgb(0, 55, 105);

        public static readonly Color GrayText =
            Color.FromArgb(100, 115, 130);

        public static readonly Color Error =
            Color.FromArgb(200, 45, 45);

        public static void ConfigureForm(Form form)
        {
            form.BackColor = Color.White;

            form.Font = new Font(
                "Segoe UI",
                10F);

            form.StartPosition =
                FormStartPosition.CenterScreen;

            form.MinimumSize =
                new Size(900, 600);

            form.AutoScaleMode =
                AutoScaleMode.Dpi;

            form.FormBorderStyle =
                FormBorderStyle.Sizable;
        }

        public static void PrimaryButton(Button button)
        {
            button.BackColor = SecondaryBlue;
            button.ForeColor = Color.White;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.Cursor = Cursors.Hand;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            button.Height = 45;
        }

        public static void SecondaryButton(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = SecondaryBlue;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderColor =
                SecondaryBlue;

            button.FlatAppearance.BorderSize = 1;

            button.Cursor = Cursors.Hand;

            button.Height = 45;
        }

        public static void ErrorLabel(Label label)
        {
            label.ForeColor = Error;

            label.Font = new Font(
                "Segoe UI",
                8F);

            label.AutoSize = true;
            label.Visible = false;
        }
    }
}