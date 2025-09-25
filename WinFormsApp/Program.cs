using Shared;

namespace WinFormsApp
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

            using (var login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    if (SessionManager.UserType == "Profesional") Application.Run(new MenuProfesional());
                    //else if (SessionManager.UserType == "Administrador") Application.Run(new MenuPrincipalAdmin());
                }
            }
        }
    }
}