using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TurnoDTO
    {
        public int TurnoId { get; set; }

        [Required]
        public DateOnly FechaTurno { get; set; }

        [Required]
        public TimeOnly HoraTurno { get; set; }

        public EstadoTurno Estado { get; set; }

        [Required]
        public int NroConsultorio { get; set; }

        public int? PacienteId { get; set; }

        [Required]

        public int ProfesionalId { get; set; }
    }
}
