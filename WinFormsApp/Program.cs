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

<<<<<<< HEAD
            using (var login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    if (SessionManager.UserType == "Profesional") Application.Run(new MenuProfesional());
                    //else if (SessionManager.UserType == "Administrador") Application.Run(new MenuAdmin());
                }
            }
=======
            Application.Run(new MenuAdmin());

            //using (var login = new Login())
            //{
            //    if (login.ShowDialog() == DialogResult.OK)
            //    {
            //        if (login.TipoUsuario == TipoUsuario.Profesional) Application.Run(new MenuAdmin());
            //        else if (login.TipoUsuario == TipoUsuario.Admin) Application.Run(new MenuAdmin());
            //    }
            //}
>>>>>>> 286cef8 (Se implemento los WinForm de Profesional,listado de Paciente y Consultorio y el menu principal del administrados)
        }
    }
}