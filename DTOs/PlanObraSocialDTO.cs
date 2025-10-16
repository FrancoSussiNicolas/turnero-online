using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoPlanObraSocialDTO
    {
        Habilitado,
        Deshabilitado
    }
    public class PlanObraSocialDTO
    {
        public int PlanObraSocialId { get; set; }

        [Required]
        public string NombrePlan { get; set; }

        [Required]
        public string DescripcionPlan { get; set; }

        [Required]
        public int ObraSocialId { get; set; }

        public EstadoPlanObraSocialDTO Estado { get; set; }
    }
}
