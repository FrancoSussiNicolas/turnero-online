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
        public List<Especialidad> especialidades { get; set; }

        public static List<Profesional> listaProfesional = new(); 

        public Profesional(string apellidoNombre, string mail, string contrasenia, string matricula) 
            : base (apellidoNombre, mail, contrasenia, ObtenerProximoId())
        {
            Matricula = matricula; 
        }

        public void AddEspecialidad(Especialidad esp)
        {
            this.especialidades.Add(esp);
        }

        private static int ObtenerProximoId()
        {
            return listaProfesional.Count == 0 ? 1 : listaProfesional.Max(a => a.IdPersona) + 1;
        }
    }
}
