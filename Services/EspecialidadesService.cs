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
                return context.Especialidades.FirstOrDefault(esp => esp.EspecialidadId == id);
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

            using (var context = new TurneroContext())
            {
                var espFound = context.Especialidades.FirstOrDefault(e => e.EspecialidadId == id);
                if (espFound is null) return null;

                espFound.Descripcion = esp.Descripcion;

                context.SaveChanges();
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
    }
}
