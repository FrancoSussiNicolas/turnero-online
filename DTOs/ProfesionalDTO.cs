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

        public ProfesionalDTO(string apellidoNombre, string mail, string contrasenia, string matricula, int especialidadId)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
            Matricula = matricula;
            EspecialidadId = especialidadId;
        }
        public EstadoConsultorioDTO Estado { get; set; }

        public List<ObraSocialDTO> ObraSociales { get; set; }

        public bool AtiendePorObraSocial => ObraSociales != null && ObraSociales.Any();
    }
}
