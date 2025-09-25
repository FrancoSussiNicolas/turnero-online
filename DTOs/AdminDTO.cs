using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
