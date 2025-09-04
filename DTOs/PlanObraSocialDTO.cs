using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PlanObraSocialDTO
    {
        public int PlanObraSocialId { get; set; }

        [Required]
        public string NombrePlan { get; set; }

        [Required]
        public string DescripcionPlan { get; set; }

        [Required]

        public int ObraSocialId { get; set; }
    }
}
