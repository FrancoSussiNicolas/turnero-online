using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TurnoService
    {
        public List<Turno> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos.ToList();
            }
        }

        public Turno? GetById(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos.FirstOrDefault(turno => turno.TurnoId == id);
            }
        }

        public List<Turno> GetDisponibles()
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos.ToList().FindAll(turno => turno.Estado == EstadoTurno.Disponible);
            }

        }

        public Turno CreateTurno(TurnoDTO turno, Consultorio consultorio)
        {
            using (var context = new TurneroContext())
            {
                var newTurno = new Turno(
                    turno.FechaTurno,
                    turno.HoraTurno,
                    EstadoTurno.Disponible,
                    consultorio
                );

                context.Turnos.Add(newTurno);
                context.SaveChanges();
                return newTurno;
            }
        }

        public Turno? UpdateTurno(TurnoDTO turno, int id)
        {

            using (var context = new TurneroContext())
            {
                var turnoFound = context.Turnos.FirstOrDefault(t => t.TurnoId == id);
                if (turnoFound is null) return null;

                turnoFound.FechaTurno = turno.FechaTurno;
                turnoFound.HoraTurno = turno.HoraTurno;
                turnoFound.Estado = turno.Estado;

                context.SaveChanges();
                return turnoFound;
            }
        }

        public bool ConfirmarTurno(int id)
        {
            var turnoFound = GetById(id);
            if (turnoFound is null) return false;

            using (var context = new TurneroContext())
            {
                turnoFound.Estado = EstadoTurno.Ocupado;
                return true;
            }
        }

        public bool DeleteTurno(int id)
        {
            var turno = GetById(id);
            if (turno == null) return false;

            using (var context = new TurneroContext())
            {
                context.Turnos.Remove(turno);
                return true;
            }
        }
    }
}
