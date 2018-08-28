using CrossRealmPriceCheck.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoUpdaterDotNET;


namespace CrossRealmPriceCheck
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckForUpdates();

            InformationManager.StartInstance();
            AuctionManager.StartInstance();
            LoadManager.StartInstance();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connect());
        }

        private static void CheckForUpdates()
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/Celisuis/CrossRealmPriceCheck/master/Versioning.xml");
        }
    }
}
