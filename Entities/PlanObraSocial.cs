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

        public Paciente Paciente { get; set; }

        public List<ObraSocial> ObraSocial { get; set; }

        public List<Practica> Practica { get; set; }


        public PlanObraSocial(string nombrePlan, string descripcion) {

            NombrePlan = nombrePlan;
            DescripcionPlan = descripcion;

        }
    }
}
