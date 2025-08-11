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
        public int IdObraSocial { get; set; }

        [Required]
        public string NombreObraSocial { get; set; }
    }
}
