using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    public partial class ReportFailureForm : Form
    {
        public ReportFailureForm(
            string message)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(
                message))
            {
                lblMessage.Text =
                    message +
                    "\n\nPlease check your details and try again.";
            }
        }


        private void btnOK_Click(
            object sender,
            System.EventArgs e)
        {
            this.Close();
        }
    }
}