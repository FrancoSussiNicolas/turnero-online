using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Paciente : Persona
    {
        public string DNI { get; set; }
        public string Sexo { get; set; } 

        public DateOnly FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public List<PlanObraSocial>  PlanObraSocial { get; set; }

        public Turno Turno { get; set; }

        public Paciente(string apellidoNombre, string mail, string contrasenia, string dni, string sexo, DateOnly fechaNacimiento, string telefono)
            : base(apellidoNombre, mail, contrasenia)
        {
            DNI = dni;
            Sexo = sexo; 
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

    }
}
