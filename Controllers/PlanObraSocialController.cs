using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
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

        [HttpGet]
        public ActionResult<IEnumerable<PlanObraSocial>> GetAll()
        {
            return Ok(planObraSocialService.GetAll());
        }

        [HttpGet("{nro}")]
        public ActionResult<PlanObraSocial> GetByNro(int nro)
        {
            var planOS = planObraSocialService.GetByNroPlan(nro);
            if (planOS is null) return NotFound(new { message = "Plan no encontrado" });

            return Ok(planOS);
        }


        [HttpPost]
        public ActionResult<PlanObraSocial> CrearPlanObraSocial([FromBody] PlanObraSocialDTO planObraSocial)
        {
            var obraSocialExistente = obraSocialService.GetByIdObraSocial(planObraSocial.ObraSocialId);
            if (obraSocialExistente is null)
            {
                return BadRequest(new { message = $"La Obra Social con ID {planObraSocial.ObraSocialId} no existe." });
            }

            var newPlanOS = planObraSocialService.CrearPlanObraSocial(planObraSocial);

            return Created($"https://localhost:7119/especialidades/{newPlanOS.PlanObraSocialId}", newPlanOS);
        }

        [HttpPut("{nro}")]
        public ActionResult UpdatePlanObraSocial([FromBody] PlanObraSocialDTO planObraSocial, int nro)
        {
            var updatedPlanOS = planObraSocialService.UpdatePlanObraSocial(planObraSocial, nro);
            if (updatedPlanOS is null) return NotFound(new { message = "Plan no encontrado" });

            return NoContent();
        }

        [HttpDelete("{nro}")]
        public ActionResult DeletePlanObraSocial(int nro)
        {
            var deletedPlanOS = planObraSocialService.EliminarPlanObraSocial(nro);
            if (!deletedPlanOS) return NotFound(new { message = "Plan no encontrado" });

            return NoContent();
        }
    }
}

