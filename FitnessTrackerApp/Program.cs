using FitnessTrackerApp.Classes;
using System;
using System.Windows.Forms;

namespace FitnessTrackerApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionManager _connectionManager = new ConnectionManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionManager.HomePage = new Home();
            _connectionManager.PopulateHomePage();
            Application.Run(ConnectionManager.HomePage);


        }
    }
}
