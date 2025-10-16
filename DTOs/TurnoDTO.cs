using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoTurnoDTO
    {
        Disponible,
        Ocupado
    }

    public class TurnoDTO
    {
        public int TurnoId { get; set; }

        [Required]
        public DateOnly FechaTurno { get; set; }

        [Required]
        public TimeOnly HoraTurno { get; set; }

        public EstadoTurnoDTO Estado { get; set; }

        [Required]
        public int ConsultorioId { get; set; }

        public int? PacienteId { get; set; }

        [Required]
        public int ProfesionalId { get; set; }
    }
}
