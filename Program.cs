using IS_5;
using PetsClient.Organization.View;

namespace PetsClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var authoizationView = new AuthorizationView();
            //Application.Run(authoizationView);

            //if (authoizationView.UserSuccessfullyAuthenticated)
            //{
            //    Application.Run(new MenuForm());
            //}
            Application.Run(new OrganizationView());
        }
    }
}