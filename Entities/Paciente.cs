using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Paciente : Persona
    {
        [Index(IsUnique = true)]
        public string Dni { get; set; }
        public string Sexo { get; set; } 

        public DateOnly FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public int PlanObraSocialId { get; set; }

        public PlanObraSocial PlanObraSocial { get; set; }

        public List<Turno> Turno { get; set; }

        public Paciente(string apellidoNombre, string mail, string contrasenia, string dni, string sexo, DateOnly fechaNacimiento, string telefono, int planObraSocialId)
            : base(apellidoNombre, mail, contrasenia)
        {
            Dni = dni;
            Sexo = sexo; 
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            PlanObraSocialId = planObraSocialId;
        }

    }
}
