using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class PlanObraSocialDTO
    {
        [Required]
        public int IdPlanObraSocial { get; set; }

        [Required]
        public string NombrePlan { get; set; }

        [Required]
        public string DescripcionPlan { get; set; }
    }
}
