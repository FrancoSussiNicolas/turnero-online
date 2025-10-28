using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<Turno>> GetAll()
        {
            return Ok(turnoService.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<Turno> GetById(int id)
        {

            var turno = turnoService.GetById(id);
            if (turno is null) return NotFound("Turno no encontrado");

            return Ok(turno);
        }

        [Authorize]
        [HttpGet("disponibles/{profesionalId}")]
        public ActionResult<IEnumerable<Turno>> GetDisponibles(int profesionalId)
        {
            var profesional = profesionalService.GetByIdProfesional(profesionalId);
            if (profesional is null) return NotFound("Profesional no encontrado");

            var turnosDisponibles = turnoService.GetDisponibles(profesionalId);

            return Ok(turnosDisponibles ?? new List<Turno>());
        }

        [Authorize]
        [HttpGet("paciente/{pacienteId}")]
        public ActionResult<List<Turno>> GetTurnoByPacienteId(int pacienteId)
        {
            var paciente = pacienteService.GetByIdPaciente(pacienteId);
            if (paciente is null) return NotFound("Paciente no encontrado");
            
            var turnos = turnoService.GetByPaciente(pacienteId); 

            return Ok(turnos);
        }

        [Authorize]
        [HttpGet("profesional/{id}")] 
        public ActionResult<IEnumerable<Turno>> GetByProfesional(int id)
        {
            var profesional = profesionalService.GetByIdProfesional(id);
            if (profesional is null) return NotFound("Profesional no encontrado");
            var turnos = turnoService.GetByProfesional(id);
            return Ok(turnos);
        }

        [Authorize(Roles = "Profesional")] 
        [HttpPost]
        public ActionResult<Turno> CrearTurno([FromBody] TurnoDTO turno)
        {
            var consultorio = consultorioService.GetById(turno.ConsultorioId);
            if (consultorio is null) return NotFound("Consultorio no encontrado");
            if (!consultorio.EstaLibre(turno.FechaTurno, turno.HoraTurno)) return UnprocessableEntity("El Consultorio no está libre para esa fecha y hora");
            if (consultorio.Estado == Entities.EstadoConsultorio.Deshabilitado) return UnprocessableEntity("El Consultorio está deshabilitado");
            if (turno.FechaTurno < DateOnly.FromDateTime(DateTime.Now)) return UnprocessableEntity("La fecha debe ser mayor o igual a hoy");
            if (turno.HoraTurno < TimeOnly.FromDateTime(DateTime.Now) && turno.FechaTurno == DateOnly.FromDateTime(DateTime.Now)) 
                return UnprocessableEntity("La hora debe ser mayor o igual a la hora actual");

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

        [Authorize(Roles = "Profesional")]
        [HttpPut("{id}")]
        public ActionResult UpdateTurno([FromBody] TurnoDTO turno, int id)
        {
            var updatedTurno = turnoService.UpdateTurno(turno, id);
            if (updatedTurno is null) return NotFound("Turno no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Paciente")]
        [HttpPut("cambiarEstado/{idTurno}")]
        public ActionResult CambiarEstadoTurno([FromBody] int idPaciente, int idTurno)
        {
            var turnoConfirmado = turnoService.CambiarEstadoTurno(idTurno, idPaciente);
            if (!turnoConfirmado) return NotFound("Turno no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Profesional")]
        [HttpDelete("{id}")]
        public ActionResult DeleteTurno(int id)
        {
            var deletedTurno = turnoService.DeleteTurno(id);
            if (!deletedTurno) return NotFound("Turno no encontrado");

            return NoContent();
        }

        [Authorize]
        [HttpPatch("asignarTurno/{turnoId}/{pacienteId}")]

        public ActionResult AsignarTurno(int turnoId, int pacienteId)
        {
            var asignarTurno = turnoService.AsignarTurno(turnoId, pacienteId);
            if (asignarTurno == null) return NotFound("Error al asignar el turno"); 
            
            return NoContent();
        }
    }
}
