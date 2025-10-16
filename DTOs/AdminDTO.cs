using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class AdminDTO
    {
        public int PersonaId { get; set; }

        [Required]
        public string ApellidoNombre { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        public AdminDTO(string apellidoNombre, string mail, string contrasenia)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
        }
    }
}
