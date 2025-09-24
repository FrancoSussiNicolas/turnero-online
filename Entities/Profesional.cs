using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    public enum EstadoProfesional
    {
        Habilitado,
        Deshabilitado
    }

    [Index(nameof(Matricula), IsUnique = true)]
    public class Profesional : Persona
    {
        public string Matricula { get; set; }

        public int EspecialidadId { get; set; }

        public EstadoProfesional Estado { get; set; }

        [JsonIgnore]
        public Especialidad Especialidad { get; set; }

        [JsonIgnore]
        public List<Turno> Turnos { get; set; }

        public List<ObraSocial> ObraSociales { get; set; }

        public Profesional(string apellidoNombre, string mail, string contrasenia, string matricula, int especialidadId) 
            : base (apellidoNombre, mail, contrasenia)
        {
            Matricula = matricula;
            EspecialidadId = especialidadId;
            Turnos = new();
            ObraSociales = new();
            Estado = EstadoProfesional.Habilitado;
        }

        public Profesional(string apellidoNombre, string mail, string matricula, int especialidadId) 
            : base (apellidoNombre, mail)
        {
            Matricula = matricula;
            EspecialidadId = especialidadId;
            Turnos = new();
            ObraSociales = new();
            Estado = EstadoProfesional.Habilitado;
        }

        public static Profesional Crear(string apellidoNombre, string mail, string contrasenia, string matricula, int especialidadId)
        {
            var p = new Profesional(apellidoNombre, mail, matricula, especialidadId);
            p.SetPassword(contrasenia);
            return p;
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
