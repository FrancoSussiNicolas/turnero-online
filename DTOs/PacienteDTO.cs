using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PacienteDTO
    {
        public int PersonaId { get; set; }

        [Required]
        public string ApellidoNombre { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public DateOnly FechaNacimiento { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public int PlanObraSocialId { get; set; }

    }
}
