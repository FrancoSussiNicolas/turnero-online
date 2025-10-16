using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoConsultorioDTO
    {
        Habilitado,
        Deshabilitado
    }

    public  class ConsultorioDTO
    {
        public int ConsultorioId { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        public EstadoConsultorioDTO Estado { get; set; }
    }
}
