using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DTOs;

namespace Services
{
    public class PlanObraSocialService
    {

        public IEnumerable<PlanObraSocial> GetAll()
        {
            return PlanObraSocial.listaPlanesObraSocial;
        }

        public PlanObraSocial? GetByNroPlan(int nro)
        {
            return PlanObraSocial.listaPlanesObraSocial.FirstOrDefault(p => p.NroPlan == nro);
        }

        public PlanObraSocial CrearPlanObraSocial(PlanObraSocialDTO planObraSocial)
        {
            var newPlanObraSocial = new PlanObraSocial(
                  planObraSocial.NombrePlan,
                  planObraSocial.DescripcionPlan
            );

            PlanObraSocial.listaPlanesObraSocial.Add(newPlanObraSocial);
            return newPlanObraSocial;

        }

        public PlanObraSocial? UpdatePlanObraSocial(PlanObraSocialDTO planOS, int nro)
        {
            var planObraSocialEncontrado = GetByNroPlan(nro);

            if (planObraSocialEncontrado is null) return null;

            planObraSocialEncontrado.NombrePlan = planOS.NombrePlan;
            planObraSocialEncontrado.DescripcionPlan = planOS.DescripcionPlan;

            return planObraSocialEncontrado;
        }

        public bool EliminarPlanObraSocial(int nro)
        {
            var planOS = GetByNroPlan(nro);
            if (planOS == null) return false;

            PlanObraSocial.listaPlanesObraSocial.Remove(planOS);
            return true;
        }

    }
}
}
