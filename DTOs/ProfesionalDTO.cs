using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ProfesionalDTO
    {

        public enum EstadoProfesionalDTO
        {
            Habilitado,
            Deshabilitado
        }

        public int PersonaId { get; set; }

        [Required]
        public string ApellidoNombre { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public string Matricula { get; set; }

        [Required]
        public int EspecialidadId { get; set; } 

        public EstadoProfesionalDTO Estado { get; set; }

        public List<ObraSocialDTO>? ObraSociales { get; set; } = new List<ObraSocialDTO>();

        public bool AtiendePorObraSocial => ObraSociales != null && ObraSociales.Any();
    }
}
