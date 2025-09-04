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

            using (var context = new TurneroContext())
            {
                var practicaEncontrada = context.Practicas.FirstOrDefault(p => p.PracticaId == idPractica);

                if (practicaEncontrada is null) return null;

                practicaEncontrada.Nombre = practica.Nombre;
                practicaEncontrada.Descripcion = practica.Descripcion;

                context.SaveChanges();
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

        public bool DisablePractica(int id)
        {
            using (var context = new TurneroContext())
            {
                var practica = context.Practicas.FirstOrDefault(p => p.PracticaId == id);
                if (practica is null) return false;

                practica.Estado = EstadoPractica.Deshabilitado;
                context.SaveChanges();
                return true;
            }
        }
    }
}
