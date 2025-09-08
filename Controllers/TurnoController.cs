using DTOs;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("turnos")]
    public class TurnoController : ControllerBase
    {
        private readonly TurnoService turnoService;
        private readonly ConsultorioService consultorioService;
        private readonly ProfesionalService profesionalService;
        private readonly PacienteService pacienteService;

        public TurnoController(TurnoService turnoService, ConsultorioService consultorioService, ProfesionalService profesionalService, PacienteService pacienteService)
        {
            this.turnoService = turnoService;
            this.consultorioService = consultorioService;
            this.profesionalService = profesionalService;
            this.pacienteService = pacienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Turno>> GetAll()
        {
            return Ok(turnoService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Turno> GetById(int id)
        {

            var turno = turnoService.GetById(id);
            if (turno is null) return NotFound("Turno no encontrado");

            return Ok(turno);
        }

        [HttpGet("disponibles")]
        public ActionResult<IEnumerable<Turno>> GetDisponibles()
        {
            return Ok(turnoService.GetDisponibles());
        }

        [HttpGet("paciente/{pacienteId}")]
        public ActionResult<Turno> GetTurnoByPacienteId(int pacienteId)
        {
            var paciente = pacienteService.GetByIdPaciente(pacienteId);
            if (paciente is null) return NotFound("Paciente no encontrado");
            
            var turnos = turnoService.GetTurnsByPacient(paciente); 

            if(turnos.Count == 0) return NotFound("El paciente no tiene turnos asignados");

            return Ok(turnos);
        }

        [HttpPost]
        public ActionResult<Turno> CrearTurno([FromBody] TurnoDTO turno)
        {
            var consultorio = consultorioService.GetById(turno.NroConsultorio);
            if (consultorio is null) return NotFound("Consultorio no encontrado");
            if (!consultorio.EstaLibre(turno.FechaTurno, turno.HoraTurno)) return UnprocessableEntity("El Consultorio no está libre para esa fecha y hora");
            if (consultorio.Estado == EstadoConsultorio.Deshabilitado) return UnprocessableEntity("El Consultorio está deshabilitado");
            if (turno.FechaTurno < DateOnly.FromDateTime(DateTime.Now)) return UnprocessableEntity("La fecha debe ser mayor o igual a hoy");
            if (turno.HoraTurno < TimeOnly.FromDateTime(DateTime.Now) && turno.FechaTurno == DateOnly.FromDateTime(DateTime.Now)) return UnprocessableEntity("La hora debe ser mayor o igual a la hora actual");

            if (turno.PacienteId.HasValue)
            {
                var paciente = pacienteService.GetByIdPaciente(turno.PacienteId.Value);
                if (paciente is null) return NotFound("Paciente no encontrado");
            }

            var profesional = profesionalService.GetByIdProfesional(turno.ProfesionalId);
            if (profesional is null) return NotFound("Profesional no encontrado");

            var newTurno = turnoService.CreateTurno(turno, consultorio);

            return Created($"https://localhost:7119/turnos/{newTurno.TurnoId}", newTurno);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTurno([FromBody] TurnoDTO turno, int id)
        {
            var updatedTurno = turnoService.UpdateTurno(turno, id);
            if (updatedTurno is null) return NotFound("Turno no encontrado");

            return NoContent();
        }

        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoTurno(int id)
        {
            var turnoConfirmado = turnoService.CambiarEstadoTurno(id);
            if (!turnoConfirmado) return NotFound("Turno no encontrado");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTurno(int id)
        {
            var deletedTurno = turnoService.DeleteTurno(id);
            if (!deletedTurno) return NotFound("Turno no encontrado");

            return NoContent();
        }
    }
}
