using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public  class ConsultorioDTO
    {
        public int NroConsultorio { get; set; }

        [Required]
        public string Ubicacion { get; set; }
    }
}
