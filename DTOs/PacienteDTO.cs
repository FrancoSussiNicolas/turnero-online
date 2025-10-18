using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PacienteDTO
    {
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El apellido y nombre debe tener entre 3 y 100 caracteres")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage = "El apellido y nombre solo puede contener letras y espacios")]
        public string ApellidoNombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El mail es obligatorio")]
        [EmailAddress]
        public string Mail { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "La contraseña debe tener entre 6 y 50 caracteres")]
        [RegularExpression(@"^(?=.*\d).+$", ErrorMessage = "La contraseña debe contener al menos un número.")]
        public string Contrasenia { get; set; } = string.Empty;

        [Required(ErrorMessage = "El DNI es obligatorio")]
        public string DNI { get; set; } = string.Empty;

        [Required(ErrorMessage = "El sexo es obligatorio")]
        public string Sexo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateOnly FechaNacimiento { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El id del plan de obra social es obligatorio")]
        public int PlanObraSocialId { get; set; }
    }
}
