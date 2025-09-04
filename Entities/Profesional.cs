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
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Turno> Turnos { get; set; }
        public List<ObraSocial> ObraSociales { get; set; }

        public Profesional(string apellidoNombre, string mail, string contrasenia, string matricula, int especialidadId) 
            : base (apellidoNombre, mail, contrasenia)
        {
            Matricula = matricula;
            EspecialidadId = especialidadId;
            Turnos = new();
        }

        public void AddTurno(Turno turno)
        {
            Turnos.Add(turno);
        }

        public void AddObraSocial(ObraSocial obraSocial)
        {
           ObraSociales.Add(obraSocial);
        }
    }
}
