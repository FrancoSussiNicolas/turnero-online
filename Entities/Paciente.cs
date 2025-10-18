using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [Index(nameof(Dni), IsUnique = true)]
    public class Paciente : Persona
    {
        public string Dni { get; set; }
        public string Sexo { get; set; } 

        public DateOnly FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public int? PlanObraSocialId { get; set; }

        public PlanObraSocial? PlanObraSocial { get; set; }

        [JsonIgnore]
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

        public Paciente(string apellidoNombre, string mail, string dni, string sexo, DateOnly fechaNacimiento, string telefono)
            : base(apellidoNombre, mail)
        {
            Dni = dni;
            Sexo = sexo; 
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

        public static Paciente Crear(string apellidoNombre, string mail, string contrasenia, string dni, string sexo, DateOnly fechaNacimiento, string telefono)
        {
            var p = new Paciente(apellidoNombre, mail, dni, sexo, fechaNacimiento, telefono);
            p.SetPassword(contrasenia);
            return p;
        }
    }
}
