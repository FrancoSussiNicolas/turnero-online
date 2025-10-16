using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ProfesionalDTO
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
        public string Matricula { get; set; }

        [Required]
        public int EspecialidadId { get; set; }

        public ProfesionalDTO(string apellidoNombre, string mail, string contrasenia, string matricula)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
            Matricula = matricula;
        }
        public EstadoConsultorioDTO Estado { get; set; }
    }
}
