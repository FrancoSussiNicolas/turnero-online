using DTOs;
using Entities;
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
                return context.Especialidades.ToList();
            }
        }

        public Especialidad? GetById(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Especialidades.FirstOrDefault(esp => esp.IdEspecialidad == id);
            }
        }

        public Especialidad CreateEspecialidad(EspecialidadDTO esp)
        {
            using (var context = new TurneroContext())
            {
                var newEsp = new Especialidad(
                    esp.Descripcion
                );

                context.Especialidades.Add(newEsp);
                context.SaveChanges();
                return newEsp;
            }
        }

        public Especialidad? UpdateEspecialidad(EspecialidadDTO esp, int id)
        {
            var espFound = GetById(id);
            if (espFound is null) return null;

            using (var context = new TurneroContext())
            {
                espFound.EspecialidadId = esp.EspecialidadId;
                espFound.Descripcion = esp.Descripcion;

                context.SaveChanges();
                return espFound;
            }
        }

        public bool DeleteEspecialidad(int id)
        {
            var esp = GetById(id);
            if (esp == null) return false;

            using (var context = new TurneroContext())
            {
                context.Especialidades.Remove(esp);
                context.SaveChanges();
                return true;
            }
        }
    }
}
