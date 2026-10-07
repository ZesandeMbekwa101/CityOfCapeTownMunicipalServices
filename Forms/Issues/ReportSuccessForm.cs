using System.Windows.Forms;

namespace CityOfCapeTownMunicipalServices.Forms.Issues
{
    public partial class ReportSuccessForm : Form
    {
        public ReportSuccessForm(
            string referenceNumber)
        {
            InitializeComponent();

            lblReferenceNumber.Text =
                referenceNumber;
        }


        private void btnOK_Click(
            object sender,
            System.EventArgs e)
        {
            this.Close();
        }
    }
}