using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("planObraSocial")]
    public class PlanObraSocialController : ControllerBase
    {
        private readonly PlanObraSocialService planObraSocialService;
        private readonly ObraSocialService obraSocialService;

        public PlanObraSocialController(PlanObraSocialService planObraSocialService, ObraSocialService obraSocialService)
        {
            this.planObraSocialService = planObraSocialService;
            this.obraSocialService = obraSocialService;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<PlanObraSocial>> GetAll()
        {
            return Ok(planObraSocialService.GetAll());
        }

        [Authorize]
        [HttpGet("{nro}")]
        public ActionResult<PlanObraSocial> GetByNro(int nro)
        {
            var planOS = planObraSocialService.GetByNroPlan(nro);
            if (planOS is null) return NotFound("Plan no encontrado");

            return Ok(planOS);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public ActionResult<PlanObraSocial> CrearPlanObraSocial([FromBody] PlanObraSocialDTO planObraSocial)
        {
            var obraSocialExistente = obraSocialService.GetByIdObraSocial(planObraSocial.ObraSocialId);
            if (obraSocialExistente is null)
            {
                return BadRequest($"La Obra Social con ID {planObraSocial.ObraSocialId} no existe.");
            }

            var newPlanOS = planObraSocialService.CrearPlanObraSocial(planObraSocial);

            return Created($"https://localhost:7119/especialidades/{newPlanOS.PlanObraSocialId}", newPlanOS);
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPut("{nro}")]
        public ActionResult UpdatePlanObraSocial([FromBody] PlanObraSocialDTO planObraSocial, int nro)
        {
            var updatedPlanOS = planObraSocialService.UpdatePlanObraSocial(planObraSocial, nro);
            if (updatedPlanOS is null) return NotFound("Plan no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPatch("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoPlan(int id)
        {
            try
            {
                var planDisabled = planObraSocialService.CambiarEstadoPlan(id);
                if (!planDisabled) return NotFound("Plan no encontrado");

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict("Error al guardar: " + ex.Message);
            }
        }

        [Authorize(Roles = "Administrador")] 
        [HttpDelete("{nro}")]
        public ActionResult DeletePlanObraSocial(int nro)
        {
            var deletedPlanOS = planObraSocialService.EliminarPlanObraSocial(nro);
            if (!deletedPlanOS) return NotFound("Plan no encontrado");

            return NoContent();
        }
    }
}

