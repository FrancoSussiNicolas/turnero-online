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

        public TurnoController(TurnoService turnoService)
        {
            this.turnoService = turnoService;
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
            if (turno is null) return NotFound();

            return Ok(turno);
        }

        [HttpGet("disponibles")]
        public ActionResult<IEnumerable<Turno>> GetDisponibles()
        {
            return Ok(turnoService.GetDisponibles());
        }

        [HttpPost]
        public ActionResult<Turno> CrearTurno([FromBody] TurnoDTO turno)
        {
            var newTurno = turnoService.CreateTurno(turno);

            return Created($"https://localhost:7119/turnos/{newTurno.IdTurno}", newTurno);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTurno([FromBody] TurnoDTO turno, int id)
        {
            var updatedTurno = turnoService.UpdateTurno(turno, id);
            if (updatedTurno is null) return NotFound();

            return NoContent();
        }

        [HttpPut("confirmar/{id}")]
        public ActionResult ConfirmarTurno(int id)
        {
            var turnoConfirmado = turnoService.ConfirmarTurno(id);
            if (!turnoConfirmado) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTurno(int id)
        {
            var deletedTurno = turnoService.DeleteTurno(id);
            if (!deletedTurno) return NotFound();

            return NoContent();
        }
    }
}
