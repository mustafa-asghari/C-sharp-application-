using System.Configuration;
using System.Data;
using System.Windows;
using DataMangment;

namespace E_sport_application
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            try
            {
                Helper.EnsureDatabaseAndSchema("DefaultConnection");
            }
            catch
            {
                // Suppress error message as requested. 
                // If this fails, MainWindow will try again (and usually succeed if it was a timing issue).
            }
        }
    }

}
