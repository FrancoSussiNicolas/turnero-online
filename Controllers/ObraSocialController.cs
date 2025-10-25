using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("obraSocial")]
    public class ObraSocialController : ControllerBase
    {
        private readonly ObraSocialService obraSocialService;
        private readonly PlanObraSocialService planObraSocialService;

        public ObraSocialController (ObraSocialService obraSocialService, PlanObraSocialService planObraSocialService)
        {
            this.obraSocialService = obraSocialService;
            this.planObraSocialService = planObraSocialService;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<ObraSocial>> GetAll()
        {
            return Ok(obraSocialService.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<ObraSocial> GetById(int id)
        {
            var os = obraSocialService.GetByIdObraSocial(id);
            if (os is null) return NotFound(new { message = "Obra Social no encontrada" });

            return Ok(os);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public ActionResult<ObraSocial> CrearObraSocial([FromBody] ObraSocialDTO obraSocial)
        {
            try
            {
                var newOS = obraSocialService.CrearObraSocial(obraSocial);

                return Created($"https://localhost:7119/especialidades/{newOS.ObraSocialId}", newOS);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPut("{id}")]
        public ActionResult UpdateObraSocial (int id, [FromBody] ObraSocialDTO obraSocial)
        {
            try
            {
                var updatedOS = obraSocialService.UpdateObraSocial(id, obraSocial);
                if (updatedOS is null) return NotFound(new { message = "Obra Social no encontrada" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPatch("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoObraSocial(int id)
        {
            var osDisabled = obraSocialService.CambiarEstadoObraSocial(id);
            if (!osDisabled) return NotFound(new { message = "Obra Social no encontrada" });

            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public ActionResult DeleteObraSocial(int id)
        {
            var deletedOS = obraSocialService.EliminarObraSocial(id);
            if (!deletedOS) return NotFound(new { message = "Obra Social no encontrada" });
        
            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut("eliminarPlan/{obraSocialId}/{planId}")]
        public ActionResult RemovePlanFromPractica(int obraSocialId, int planId)
        {
            bool eliminado = obraSocialService.EliminarPlanDeObraSocial(obraSocialId, planId);

            if (!eliminado)
                return NotFound(new { message = "Obra Social o plan no encontrada" });

            return Ok(new { message = "Plan eliminado de la obra social exitosamente" });
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut("agregarPlanOS/{obraSocialId}/{planObraSocialId}")]
        public ActionResult<ObraSocial> AgregarPlanObraSocial(int obraSocialId, int planObraSocialId)
        {
            try
            {
                // Obtener el plan de obra social
                var planOs = planObraSocialService.GetByNroPlan(planObraSocialId);
                if (planOs is null)
                    return NotFound(new { message = "Plan de Obra Social no encontrado" });

                // Llamar al service de ObraSocial
                var obraSocialActualizada = obraSocialService.AgregarPlanAObraSocial(obraSocialId, planOs);
                if (obraSocialActualizada is null)
                    return NotFound(new { message = "Obra Social no encontrada" });

                return Ok(obraSocialActualizada);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno: " + ex.Message });
            }
        }

        [Authorize]
        [HttpGet("disponibles")]
        public ActionResult<IEnumerable<ObraSocial>> GetDisponibles()
        {
            return Ok(obraSocialService.GetObrasSocialesDisponibles());
        }
    }
}

