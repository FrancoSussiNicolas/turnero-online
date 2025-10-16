using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public enum EstadoEspecialidadDTO
    {
        Habilitada,
        Deshabilitada
    }
    public class EspecialidadDTO
    {
        public int EspecialidadId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public EstadoEspecialidadDTO Estado { get; set; }
    }
}
