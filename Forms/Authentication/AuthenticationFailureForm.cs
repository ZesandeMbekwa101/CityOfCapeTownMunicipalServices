using System;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    public partial class AuthenticationFailureForm : Form
    {
        public AuthenticationFailureForm(
            string title,
            string message)
        {
            InitializeComponent();

            lblTitle.Text =
                title;

            lblMessage.Text =
                message;
        }


        private void btnTryAgain_Click(
            object sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.OK;

            this.Close();
        }
    }
}