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
        public int NroPlan {  get; set; }

        public string NombrePlan { get; set; }

        public string DescripcionPlan { get; set; }

        public List<Paciente> Pacientes { get; set; }

        public static List<PlanObraSocial> listaPlanesObraSocial = new List<PlanObraSocial>();



        public PlanObraSocial(string nombrePlan, string descripcion) {

            NroPlan = ObtenerProximoId(); 
            NombrePlan = nombrePlan;
            DescripcionPlan = descripcion;

        }

        public void AddPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        private static int ObtenerProximoId()
        {
            return PlanesObraSocial.Count == 0 ? 1 : PlanesObraSocial.Max(e => e.NroPlan) + 1;
        }

    }
}
