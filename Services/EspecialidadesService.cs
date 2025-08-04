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
        public IEnumerable<Especialidad> GetAll()
        {
            return Especialidad.ListaEspecialidad;
        }

        public Especialidad? GetById(int id)
        {
            return Especialidad.ListaEspecialidad.FirstOrDefault(esp => esp.IdEspecialidad == id);
        }

        public Especialidad CreateEspecialidad(EspecialidadDTO esp)
        {
            var newEsp = new Especialidad(
                esp.Descripcion
            );

            Especialidad.ListaEspecialidad.Add(newEsp);
            return newEsp;

        }

        public Especialidad? UpdateEspecialidad(EspecialidadDTO esp, int id)
        {
            var espFound = GetById(id);

            if (espFound is null) return null;

            espFound.Descripcion = esp.Descripcion;

            return espFound;
        }

        public bool DeleteEspecialidad(int id)
        {
            var esp = GetById(id);
            if (esp == null) return false;

            Especialidad.ListaEspecialidad.Remove(esp);
            return true;
        }
    }
}
