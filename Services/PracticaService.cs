using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using DTOs;

namespace Services
{
    public class PracticaService
    {
        public IEnumerable<Practica> GetAll()
        {
            return Practica.ListaPracticas;
        }

        public Practica? GetByIdPractica(int id)
        {
            return Practica.ListaPracticas.FirstOrDefault(p => p.IdPractica == id);
        }

        public Practica CrearPractica(PracticaDTO practica)
        {
            var nuevaPractica = new Practica(
                practica.Nombre,
                practica.Descripcion
            );

            Practica.ListaPracticas.Add(nuevaPractica);
            return nuevaPractica;
        }

        public Practica? UpdatePractica(PracticaDTO practica, int idPractica)
        {
            var practicaEncontrada = GetByIdPractica(idPractica);

            if (practicaEncontrada is null) return null;

            practicaEncontrada.Nombre = practica.Nombre;
            practicaEncontrada.Descripcion = practica.Descripcion;

            return practicaEncontrada;
        }

        public bool EliminarPractica(int id)
        {
            var practica = GetByIdPractica(id);
            if (practica == null) return false;

            Practica.ListaPracticas.Remove(practica);
            return true;
        }
    }
}
