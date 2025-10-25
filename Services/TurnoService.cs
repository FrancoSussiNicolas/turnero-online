using DTOs;
using Entities;
using Microsoft.EntityFrameworkCore;
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
                return context.Turnos
                    .Include(t => t.Consultorio)
                    .Include(t => t.Paciente)
                    .ThenInclude(p => p.PlanObraSocial)
                    .Include(t => t.Profesional)
                    .ThenInclude(p => p.ObraSociales)
                    .ToList();
            }
        }

        public Turno? GetById(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos
                    .Include(t => t.Consultorio)
                    .Include(t => t.Paciente)
                    .ThenInclude(p => p.PlanObraSocial)
                    .Include(t => t.Profesional)
                    .ThenInclude(p => p.ObraSociales)
                    .FirstOrDefault(turno => turno.TurnoId == id);
            }
        }

        public List<Turno> GetDisponibles()
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos
                    .Include(t => t.Consultorio)
                    .Include(t => t.Paciente)
                    .ThenInclude(p => p.PlanObraSocial)
                    .Include(t => t.Profesional)
                    .ThenInclude(p => p.ObraSociales)
                    .ToList()
                    .FindAll(turno => turno.Estado == Entities.EstadoTurno.Disponible);
            }

        }

        public List<Turno> GetByProfesional(int profesionalId)
        {
            using (var context = new TurneroContext())
            {
                return context.Turnos
                    .Include(t => t.Consultorio)
                    .Include(t => t.Paciente)
                    .ThenInclude(p => p.PlanObraSocial)
                    .Include(t => t.Profesional)
                    .ThenInclude(p => p.ObraSociales)
                    .Where(t => t.ProfesionalId == profesionalId && t.Estado == EstadoTurno.Disponible)
                    .OrderBy(t => t.FechaTurno)
                    .ThenBy(t => t.HoraTurno)
                    .ToList();
            }
        }


        public Turno CreateTurno(TurnoDTO turno, Consultorio consultorio)
        {
            using (var context = new TurneroContext())
            {
                var newTurno = new Turno(
                    turno.FechaTurno,
                    turno.HoraTurno,
                    consultorio.ConsultorioId,
                    turno.PacienteId.HasValue ? turno.PacienteId.Value : null,
                    turno.ProfesionalId
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
                turnoFound.Estado = (Entities.EstadoTurno)turno.Estado;
                turnoFound.ConsultorioId = turno.ConsultorioId;

                context.SaveChanges();
                return turnoFound;
            }
        }

        public bool CambiarEstadoTurno(int idTurno, int idPaciente)
        {
            using (var context = new TurneroContext())
            {
                var turnoFound = context.Turnos.FirstOrDefault(t => t.TurnoId == idTurno);
                if (turnoFound is null) return false;

                var pacienteFound = context.Pacientes.FirstOrDefault(p => p.PersonaId == idPaciente);
                if (pacienteFound is null) return false;

                turnoFound.Estado = turnoFound.Estado == Entities.EstadoTurno.Ocupado ? Entities.EstadoTurno.Disponible : Entities.EstadoTurno.Ocupado;
                turnoFound.PacienteId = turnoFound.Estado == Entities.EstadoTurno.Ocupado ? idPaciente : null;
                context.SaveChanges();
                return true;
            }
        }

        public List<TurnoDTO> GetByPaciente(int pacienteId)
        {
            using var context = new TurneroContext();
            return context.Turnos
                .Include(t => t.Profesional)
                .Include(t => t.Profesional.Especialidad)
                .Where(t => t.PacienteId == pacienteId)
                .Select(t => new TurnoDTO
                {
                    TurnoId = t.TurnoId,
                    FechaTurno = t.FechaTurno,
                    HoraTurno = t.HoraTurno,
                    ProfesionalId = t.ProfesionalId,
                    ProfesionalNombre = t.Profesional.ApellidoNombre,
                    EspecialidadId = t.Profesional.EspecialidadId,
                    EspecialidadNombre = t.Profesional.Especialidad.Descripcion
                })
                .ToList();
        }
        public bool DeleteTurno(int id)
        {

            using (var context = new TurneroContext())
            {
                var turno = context.Turnos.FirstOrDefault(t => t.TurnoId == id);
                if (turno == null) return false;

                context.Turnos.Remove(turno);
                context.SaveChanges();
                return true;
            }
        }


        public Turno AsignarTurno(int turnoId, int pacienteId )
        {
            using (var context = new TurneroContext())
            {

                var turno = context.Turnos.FirstOrDefault(t => t.TurnoId == turnoId);

                if (turno == null)
                    throw new Exception("El turno no existe.");


                turno.PacienteId = pacienteId;
                turno.Estado = Entities.EstadoTurno.Ocupado;

                context.SaveChanges();

                return turno;
            }
        }

    }
}
