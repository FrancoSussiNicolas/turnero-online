using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using DTOs;

namespace Services
{
    public class PracticaService
    {
        public List<Practica> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Practicas.ToList();
            }
        }

        public Practica? GetByIdPractica(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Practicas.FirstOrDefault(p => p.PracticaId == id);
            }
        }

        public Practica CrearPractica(PracticaDTO practica)
        {
            using (var context = new TurneroContext())
            {
                var nuevaPractica = new Practica(
                practica.Nombre,
                practica.Descripcion
            );

                context.Practicas.Add(nuevaPractica);
                context.SaveChanges();
                return nuevaPractica;
            }
        }

        public Practica? UpdatePractica(PracticaDTO practica, int idPractica)
        {
            var practicaEncontrada = GetByIdPractica(idPractica);

            if (practicaEncontrada is null) return null;

            using (var context = new TurneroContext())
            {
                practicaEncontrada.Nombre = practica.Nombre;
                practicaEncontrada.Descripcion = practica.Descripcion;

                context.SaveChanges();
                return practicaEncontrada;
            }
        }

        public bool EliminarPractica(int id)
        {
            var practica = GetByIdPractica(id);
            if (practica == null) return false;

            using (var context = new TurneroContext())
            {
                context.Practicas.Remove(practica);
                context.SaveChanges();
                return true;
            }
        }
    }
}
