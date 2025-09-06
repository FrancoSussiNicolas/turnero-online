using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("pacientes")]
    public class PacienteController : ControllerBase
    {

        private readonly PacienteService pacienteService;
        private readonly PlanObraSocialService planObraSocialService;

        public PacienteController(PacienteService pacienteService, PlanObraSocialService planObraSocialService)
        {
            this.pacienteService = pacienteService;
            this.planObraSocialService = planObraSocialService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> GetAll()
        {
            return Ok(pacienteService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Paciente> GetById(int id)
        {

            var p = pacienteService.GetByIdPaciente(id);
            if (p is null) return NotFound("Paciente no encontrado");

            return Ok(p);
        }

        [HttpPost]
        public ActionResult<Paciente> CrearPaciente([FromBody] PacienteDTO paciente)
        {
            try
            {
                var plan = planObraSocialService.GetByNroPlan(paciente.PlanObraSocialId);
                if (plan is null) return BadRequest("El Plan de Obra Social especificado no existe.");
               
                var newPaciente = pacienteService.CrearPaciente(paciente);

                //return CreatedAtAction(nameof(GetById), new { id = newPaciente.IdPersona }, newPaciente);
                return Created($"https://localhost:7119/pacientes/{newPaciente.PersonaId}", newPaciente);
            }
            catch (Exception ex)
            {
                return BadRequest("Error al guardar: " + ex.InnerException?.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePaciente([FromBody] PacienteDTO paciente, int id)
        {
            var updatePac = pacienteService.UpdatePaciente(paciente, id);
            if (updatePac is null) return NotFound("Paciente no encontrado");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePaciente (int id) 
        {
            var eliminadoPac = pacienteService.EliminarPaciente(id);
            if(!eliminadoPac) return NotFound("Paciente no encontrado");

            return NoContent();
        }

    }
}
