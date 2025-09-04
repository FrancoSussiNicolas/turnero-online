using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum EstadoTurno
    {
        Disponible,
        Ocupado
    }

    public class Turno
    {
        public int TurnoId { get; set; }
        public DateOnly FechaTurno { get; set; }
        public TimeOnly HoraTurno { get; set; }
        public EstadoTurno Estado { get; set; }
        public int ConsultorioId { get; set; }
        public Consultorio Consultorio { get; set; }

        public int? PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        public int ProfesionalId { get; set; }

        public Profesional? Profesional { get; set; }

        public Turno() { }
           
        public Turno(DateOnly fechaTurno, TimeOnly horaTurno, Consultorio consultorio, int profesionalId) 
        {
            FechaTurno = fechaTurno;
            HoraTurno = horaTurno;
            Estado = EstadoTurno.Disponible;
            Consultorio = consultorio;
            ProfesionalId = profesionalId;
        }
    }
}
