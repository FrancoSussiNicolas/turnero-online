using Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PracticaDTO
    {
        public int PracticaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public EstadoPractica Estado { get; set; }
    }
}
