using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoObraSocialDTO
    {
        Habilitada,
        Deshabilitada
    }

    public class ObraSocialDTO
    {
        [Required]
        public int ObraSocialId { get; set; }

        [Required]
        public string NombreObraSocial { get; set; }

        public EstadoObraSocialDTO Estado { get; set; }

        public List<PlanObraSocialDTO> PlanesObraSocial { get; set; }
    }
}
