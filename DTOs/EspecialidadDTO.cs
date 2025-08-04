using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EspecialidadDTO
    {
        [Required]
        public int IdEspecialidad { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}
