using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ProfesionalDTO
    {
        [Required]
        public int IdPersona { get; set; }

        [Required]
        public string ApellidoNombre { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public string Matricula { get; set; }
    }
}
