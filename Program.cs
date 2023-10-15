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
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationForm());

            //var authoizationView = new AuthorizationView();
            //Application.Run(authoizationView);

            //if (authoizationView.UserSuccessfullyAuthenticated)
            //{
            //    Application.Run(new MenuForm());
            //}
        }
    }
}