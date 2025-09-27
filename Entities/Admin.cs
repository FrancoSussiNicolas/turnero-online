using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin : Persona
    {
        public Admin(string apellidoNombre, string mail, string contrasenia) : base(apellidoNombre, mail, contrasenia) {}

        public Admin(string apellidoNombre, string mail) : base(apellidoNombre, mail) { }

        public static Admin Crear(string apellidoNombre, string mail, string contrasenia)
        {
            var a = new Admin(apellidoNombre, mail);
            a.SetPassword(contrasenia);
            return a;
        }
    }
}
