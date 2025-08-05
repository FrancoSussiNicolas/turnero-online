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
        public IEnumerable<Turno> GetAll()
        {
            return Turno.ListaTurno;
        }

        public Turno? GetById(int id)
        {
            return Turno.ListaTurno.FirstOrDefault(turno => turno.IdTurno == id);
        }

        public IEnumerable<Turno> GetDisponibles()
        {
            return Turno.ListaTurno.FindAll(turno => turno.Estado == EstadoTurno.Disponible);
        }

        public Turno CreateTurno(TurnoDTO turno, Consultorio consultorio)
        {
            var newTurno= new Turno(
                turno.FechaTurno,
                turno.HoraTurno,
                EstadoTurno.Disponible,
                consultorio
            );

            Turno.ListaTurno.Add(newTurno);
            return newTurno;

        }

        public Turno? UpdateTurno(TurnoDTO turno, int id)
        {
            var turnoFound = GetById(id);

            if (turnoFound is null) return null;

            turnoFound.IdTurno = turno.IdTurno;
            turnoFound.FechaTurno = turno.FechaTurno;
            turnoFound.HoraTurno = turno.HoraTurno;
            turnoFound.Estado = turno.Estado;

            return turnoFound;
        }

        public bool ConfirmarTurno(int id)
        {
            var turnoFound = GetById(id);
            if (turnoFound is null) return false;

            turnoFound.Estado = EstadoTurno.Ocupado;
            return true;
        }

        public bool DeleteTurno(int id)
        {
            var turno = GetById(id);
            if (turno == null) return false;

            Turno.ListaTurno.Remove(turno);
            return true;
        }
    }
}
