using System;
using System.Windows.Forms;
using CityOfCapeTownMunicipalServices.Forms.Splash;

namespace CityOfCapeTownMunicipalServices
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SplashForm());
        }
    }
}