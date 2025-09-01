using Microsoft.AspNetCore.JsonPatch.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PlanObraSocial
    {
        public int PlanObraSocialId {  get; set; }

        public string NombrePlan { get; set; }

        public string DescripcionPlan { get; set; }

        public List<Paciente> Paciente { get; set; }

        public ObraSocial ObraSocial { get; set; }

        public List<Practica> Practica { get; set; }


        public PlanObraSocial(string nombrePlan, string descripcionPlan) {

            NombrePlan = nombrePlan;
            DescripcionPlan = descripcionPlan;

        }
    }
}
