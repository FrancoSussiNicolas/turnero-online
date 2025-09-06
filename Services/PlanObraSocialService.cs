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

        public List<PlanObraSocial> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.PlanesObrasSociales.ToList();
            }
        }

        public PlanObraSocial? GetByNroPlan(int nro)
        {
            using (var context = new TurneroContext())
            {
                return context.PlanesObrasSociales.FirstOrDefault(p => p.PlanObraSocialId == nro);
            }
        }

        public PlanObraSocial CrearPlanObraSocial(PlanObraSocialDTO planObraSocial)
        {
            using (var context = new TurneroContext())
            {
                var newPlanObraSocial = new PlanObraSocial(
                  planObraSocial.NombrePlan,
                  planObraSocial.DescripcionPlan,
                  planObraSocial.ObraSocialId
                );

                context.PlanesObrasSociales.Add(newPlanObraSocial);
                context.SaveChanges();
                return newPlanObraSocial;
            }

        }

        public PlanObraSocial? UpdatePlanObraSocial(PlanObraSocialDTO planOS, int nro)
        {

            using (var context = new TurneroContext())
            {
                var planObraSocialEncontrado = context.PlanesObrasSociales.FirstOrDefault(p => p.PlanObraSocialId == nro);
                if (planObraSocialEncontrado is null) return null;

                planObraSocialEncontrado.NombrePlan = planOS.NombrePlan;
                planObraSocialEncontrado.DescripcionPlan = planOS.DescripcionPlan;

                context.SaveChanges();
                return planObraSocialEncontrado;
            }
        }

        public bool EliminarPlanObraSocial(int nro)
        {

            using (var context = new TurneroContext()) 
            {
                var planOS = context.PlanesObrasSociales.FirstOrDefault(p => p.PlanObraSocialId == nro); ;
                if (planOS == null) return false;

                context.PlanesObrasSociales.Remove(planOS);
                context.SaveChanges();
                return true;
            }
        }

    }
}

