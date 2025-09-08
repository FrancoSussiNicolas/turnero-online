using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PracticaService
    {
        public List<Practica> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Practicas
                    .Include(p => p.PlanObraSocial)
                    .ToList();
            }
        }

        public Practica? GetByIdPractica(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Practicas
                    .Include(p => p.PlanObraSocial)
                    .FirstOrDefault(p => p.PracticaId == id);
            }
        }

        public Practica CrearPractica(PracticaDTO practica)
        {
            using (var context = new TurneroContext())
            {
                if (context.Practicas.Any(p => p.Nombre == practica.Nombre))
                {
                    throw new InvalidOperationException("Ya existe una práctica con el nombre ingresado");
                }

                var nuevaPractica = new Practica(
                    practica.Nombre,
                    practica.Descripcion
                );

                context.Practicas.Add(nuevaPractica);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una práctica con el nombre ingresado");
                    }

                    throw;
                }

                return nuevaPractica;
            }
        }

        public Practica? UpdatePractica(PracticaDTO practica, int idPractica)
        {

            using (var context = new TurneroContext())
            {
                var practicaEncontrada = context.Practicas.FirstOrDefault(p => p.PracticaId == idPractica);

                if (practicaEncontrada is null) return null;

                practicaEncontrada.Nombre = practica.Nombre;
                practicaEncontrada.Descripcion = practica.Descripcion;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una práctica con el nombre ingresado");
                    }

                    throw;
                }

                return practicaEncontrada;
            }
        }

        public bool EliminarPractica(int id)
        {

            using (var context = new TurneroContext())
            {
                var practica = context.Practicas.FirstOrDefault(p => p.PracticaId == id);
                if (practica == null) return false;

                context.Practicas.Remove(practica);
                context.SaveChanges();
                return true;
            }
        }

        public bool CambiarEstadoPractica(int id)
        {
            using (var context = new TurneroContext())
            {
                var practica = context.Practicas.FirstOrDefault(p => p.PracticaId == id);
                if (practica is null) return false;

                practica.Estado = practica.Estado == EstadoPractica.Deshabilitada ? EstadoPractica.Habilitada : EstadoPractica.Deshabilitada;
                context.SaveChanges();
                return true;
            }
        }
    }
}
