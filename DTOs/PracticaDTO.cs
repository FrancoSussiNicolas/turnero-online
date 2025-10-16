using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoPracticaDTO
    {
        Habilitada,
        Deshabilitada
    }

    public class PracticaDTO
    {
        public int PracticaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public EstadoPracticaDTO Estado { get; set; }

        public List<PlanObraSocialDTO> PlanObraSocial { get; set; }
    }
}
