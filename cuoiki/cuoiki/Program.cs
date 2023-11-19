using cuoiki.Utils;
using cuoiki.Views;

namespace cuoiki
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.dbName = "QLX";
            DatabaseHelper.serverName = "localhost";
            DatabaseHelper.userDb = "sa";
            DatabaseHelper.password = "12345678";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDI());
        }
    }
}