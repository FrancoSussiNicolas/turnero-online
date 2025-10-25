using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

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

        [Authorize(Roles = "Profesional,Administrador")] 
        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> GetAll()
        {
            return Ok(pacienteService.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<Paciente> GetById(int id)
        {
            var p = pacienteService.GetByIdPaciente(id);
            if (p is null) return NotFound(new { message = "Paciente no encontrado" });

            return Ok(p);
        }

        [HttpPost]
        public ActionResult<Paciente> CrearPaciente([FromBody] PacienteDTO paciente)
        {
            try
            {               
                var newPaciente = pacienteService.CrearPaciente(paciente);

                //return CreatedAtAction(nameof(GetById), new { id = newPaciente.IdPersona }, newPaciente);
                return Created($"https://localhost:7119/pacientes/{newPaciente.PersonaId}", newPaciente);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Paciente")]
        [HttpPut("{id}")]
        public ActionResult UpdatePaciente([FromBody] PacienteDTO paciente, int id)
        {
            try
            {
                var updatePac = pacienteService.UpdatePaciente(paciente, id);
                if (updatePac is null) return NotFound(new { message = "Paciente no encontrado" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Paciente")]
        [HttpPatch("{idPac}/plan/{idPlan}")]
        public ActionResult AsignarPlan(int idPlan, int idPac)
        {
            var result = pacienteService.AsignarPlanOs(idPlan, idPac);
            if (!result) return NotFound("Paciente o Plan no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public ActionResult DeletePaciente (int id) 
        {
            var eliminadoPac = pacienteService.EliminarPaciente(id);
            if(!eliminadoPac) return NotFound(new { message = "Paciente no encontrado" });

            return NoContent();
        }

        [Authorize(Roles = "Paciente")]
        [HttpGet("{id}/plan-obra-social")]
        public ActionResult<object> GetPlanObraSocial(int id)
        {
            var paciente = pacienteService.GetPlanObraSocialDePaciente(id);
            if (paciente is null) return NotFound(new { message = "Paciente no encontrado" });

            return Ok(paciente);
        }

    }
}
