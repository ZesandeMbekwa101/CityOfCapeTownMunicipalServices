using System;
using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Authentication
{
    public partial class AuthenticationSuccessForm : Form
    {
        public AuthenticationSuccessForm(
            string title,
            string message)
        {
            InitializeComponent();

            lblTitle.Text =
                title;

            lblMessage.Text =
                message;
        }


        private void btnContinue_Click(
            object sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.OK;

            this.Close();
        }
    }
}