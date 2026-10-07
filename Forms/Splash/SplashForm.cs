using System;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Forms.Authentication;

namespace CityOfCapeTownMunicipalServices.Forms.Splash
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            splashTimer.Start();
        }

        private void splashTimer_Tick(
            object sender,
            EventArgs e)
        {
            splashTimer.Stop();

            SignInForm signIn =
                new SignInForm();

            signIn.FormClosed +=
                (s, args) => Close();

            signIn.Show();

            Hide();
        }
    }
}