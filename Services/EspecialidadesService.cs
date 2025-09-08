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
    public class EspecialidadesService
    {
        public List<Especialidad> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Especialidades
                    .Include(e => e.Profesionales)
                    .ToList();
            }
        }

        public Especialidad? GetById(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Especialidades
                    .Include(e => e.Profesionales)
                    .FirstOrDefault(esp => esp.EspecialidadId == id);
            }
        }

        public Especialidad CreateEspecialidad(EspecialidadDTO esp)
        {
            using (var context = new TurneroContext())
            {
                if (context.Especialidades.Any(e => e.Descripcion == esp.Descripcion))
                {
                    throw new InvalidOperationException("Ya existe una especialidad con la descripcion ingresada");
                }

                var newEsp = new Especialidad(
                    esp.Descripcion
                );

                context.Especialidades.Add(newEsp);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una especialidad con la descripción ingresada");
                    }

                    throw;
                }

                return newEsp;
            }
        }

        public Especialidad? UpdateEspecialidad(EspecialidadDTO esp, int id)
        {
            using (var context = new TurneroContext())
            {
                var espFound = context.Especialidades.FirstOrDefault(e => e.EspecialidadId == id);
                if (espFound is null) return null;

                espFound.Descripcion = esp.Descripcion;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una especialidad con la descripción ingresada");
                    }

                    throw;
                }
                return espFound;
            }
        }

        public bool DeleteEspecialidad(int id)
        {

            using (var context = new TurneroContext())
            {
                var esp = context.Especialidades.FirstOrDefault(e => e.EspecialidadId == id);
                if (esp == null) return false;

                context.Especialidades.Remove(esp);
                context.SaveChanges();
                return true;
            }
        }

        public bool CambiarEstadoEspecialidad(int id)
        {
            using (var context = new TurneroContext())
            {
                var espFound = context.Especialidades.FirstOrDefault(e => e.EspecialidadId == id);
                if (espFound is null) return false;

                espFound.Estado = espFound.Estado == EstadoEspecialidad.Habilitada ? EstadoEspecialidad.Deshabilitada : EstadoEspecialidad.Habilitada;
                context.SaveChanges();
                return true;
            }
        }
    }
}
