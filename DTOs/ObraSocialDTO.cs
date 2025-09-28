using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ObraSocialDTO
    {
        [Required]
        public int ObraSocialId { get; set; }

        [Required]
        public string NombreObraSocial { get; set; }

        public EstadoObraSocial Estado { get; set; }

        public List<PlanObraSocialDTO> PlanesObraSocial { get; set; }
    }
}
