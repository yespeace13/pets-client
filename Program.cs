using PetsClient.Authentication;
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

            var authenticationView = new AuthenticationView();
            Application.Run(authenticationView);

            if (authenticationView.UserSuccessfullyAuthenticated)
            {
                Application.Run(new MenuForm());
            }
        }
    }
}