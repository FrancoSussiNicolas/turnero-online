using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Profesional : Persona
    {
        public string Matricula { get; set; }

        public static List<Profesional> listaProfesional = new(); 

        public Profesional(string apellidoNombre, string mail, string contrasenia, string matricula) 
            : base (apellidoNombre, mail, contrasenia, ObtenerProximoId())
        {
            Matricula = matricula; 
        }

        private static int ObtenerProximoId()
        {
            return listaProfesional.Count == 0 ? 1 : listaProfesional.Max(a => a.IdPersona) + 1;
        }

    }
}
