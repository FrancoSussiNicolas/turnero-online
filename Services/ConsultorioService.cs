using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConsultorioService
    {
        public List<Consultorio> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Consultorios.ToList();
            }
        }

        public List<Consultorio> GetAvailable()
        {
            using (var context = new TurneroContext())
            {
                return context.Consultorios.Where(c => c.Estado == EstadoConsultorio.Habilitado).ToList();
            }
        }

        public Consultorio? GetById(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Consultorios.FirstOrDefault(consul => consul.ConsultorioId == id);
            }
        }

        public Consultorio CreateConsultorio(ConsultorioDTO consultorio)
        {
            using (var context = new TurneroContext())
            {
                var newConsul = new Consultorio(consultorio.Ubicacion);

                context.Consultorios.Add(newConsul);
                context.SaveChanges();
                return newConsul;
            }
        }

        public Consultorio? UpdateConsultorio(ConsultorioDTO consultorio, int id)
        {

            using (var context = new TurneroContext())
            {
                var consulFound = context.Consultorios.FirstOrDefault(c => c.ConsultorioId == id);
                if (consulFound is null) return null;

                consulFound.Ubicacion = consultorio.Ubicacion;

                context.SaveChanges();
                return consulFound;
            }
        }

        public bool DeleteConsultorio(int id)
        {
            var consul = GetById(id);
            if (consul == null) return false;

            using (var context = new TurneroContext())
            {
                context.Consultorios.Remove(consul);
                context.SaveChanges();
                return true;
            }
        }

        public bool DisableConsultorio(int id)
        {
            using (var context = new TurneroContext())
            {
                var consulFound = context.Consultorios.FirstOrDefault(c => c.ConsultorioId == id);
                if (consulFound is null) return false;

                consulFound.Estado = EstadoConsultorio.Deshabilitado;
                context.SaveChanges();
                return true;
            }
        }
    }
}
