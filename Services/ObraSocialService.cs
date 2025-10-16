using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ObraSocialService
    {
        public List<ObraSocial> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.ObrasSociales
                    .Include(o => o.PlanesObraSocial)
                    .ToList();
            }
        }

        public ObraSocial? GetByIdObraSocial(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.ObrasSociales
                    .Include(o => o.PlanesObraSocial)
                    .FirstOrDefault(pro => pro.ObraSocialId == id);
            }
        }

        public ObraSocial CrearObraSocial(ObraSocialDTO obraSocial)
        {
            using (var context = new TurneroContext())
            {
                if (context.ObrasSociales.Any(o => o.NombreObraSocial == obraSocial.NombreObraSocial)) 
                {
                    throw new InvalidOperationException("Ya existe una obra social con el nombre ingresado");
                }

                var newObraSocial = new ObraSocial(
                  obraSocial.NombreObraSocial
                );

                context.ObrasSociales.Add(newObraSocial);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una obra social con el nombre ingresado");
                    }

                    throw;
                }

                return newObraSocial;
            }

        }

        public bool EliminarPlanDeObraSocial(int obraSocialId, int planId)
        {
            using (var context = new TurneroContext())
            {
                var plan = context.PlanesObrasSociales
                                  .FirstOrDefault(p => p.PlanObraSocialId == planId && p.ObraSocialId == obraSocialId);

                if (plan == null) return false;

                context.PlanesObrasSociales.Remove(plan);
                context.SaveChanges();
                return true;
            }
        }


        public ObraSocial? UpdateObraSocial(ObraSocialDTO os, int idOs)
        {
            using (var context = new TurneroContext())
            {

                var obraSocialEncontrado = context.ObrasSociales.FirstOrDefault(os => os.ObraSocialId == idOs);

                if (obraSocialEncontrado is null) return null;

                obraSocialEncontrado.NombreObraSocial = os.NombreObraSocial;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una obra social con el nombre ingresado");
                    }

                    throw;
                }

                return obraSocialEncontrado;
            }
        }

        public bool CambiarEstadoObraSocial(int id)
        {
            using (var context = new TurneroContext())
            {
                var os = context.ObrasSociales
                    .Include(o => o.PlanesObraSocial)
                    .FirstOrDefault(os => os.ObraSocialId == id);

                if (os is null) return false;

                os.Estado = os.Estado == Entities.EstadoObraSocial.Habilitada ? Entities.EstadoObraSocial.Deshabilitada : Entities.EstadoObraSocial.Habilitada;

                foreach (var plan in os.PlanesObraSocial)
                {
                    plan.Estado = os.Estado == Entities.EstadoObraSocial.Habilitada ? Entities.EstadoPlanObraSocial.Habilitado : Entities.EstadoPlanObraSocial.Deshabilitado;
                }

                context.SaveChanges();
                return true;
            }
        }

        public bool EliminarObraSocial(int id)
        {
            using (var context = new TurneroContext())
            {
                var os = context.ObrasSociales
                    .Include(o => o.PlanesObraSocial)
                    .FirstOrDefault(os => os.ObraSocialId == id);

                if (os == null) return false;

                context.ObrasSociales.Remove(os);
                context.SaveChanges();
                return true;
            }
        }

        public ObraSocial? AgregarPlanAObraSocial(int obraSocialId, PlanObraSocial planOs)
        {
            using (var context = new TurneroContext())
            {
                var obraSocial = context.ObrasSociales
                                        .Include(o => o.PlanesObraSocial)
                                        .FirstOrDefault(o => o.ObraSocialId == obraSocialId);

                if (obraSocial == null) return null;

                if (obraSocial.PlanesObraSocial.Any(p => p.PlanObraSocialId == planOs.PlanObraSocialId))
                {
                    throw new InvalidOperationException("El plan ya está asociado a esta obra social.");
                }

                obraSocial.PlanesObraSocial.Add(planOs);

                context.SaveChanges();

                return obraSocial;
            }
        }

        public List<ObraSocial> GetObrasSocialesDisponibles()
        {
            using (var context = new TurneroContext())
            {
                return context.ObrasSociales
                    .Include(o => o.PlanesObraSocial)
                    .Where(os => os.Estado == Entities.EstadoObraSocial.Habilitada)
                    .ToList();
            }
        }
    }
}