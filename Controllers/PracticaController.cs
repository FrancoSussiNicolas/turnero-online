using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [ApiController]
    [Route("practicas")]
    public class PracticaController : ControllerBase
    {
        private readonly PracticaService practicaService;
        private readonly PlanObraSocialService planObraSocialService;

        public PracticaController(PracticaService practicaService, PlanObraSocialService planObraSocialService)
        {
            this.practicaService = practicaService;
            this.planObraSocialService = planObraSocialService;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<Practica>> GetAll()
        {
            return Ok(practicaService.GetAll());
        }

        //[Authorize]
        [HttpGet("{id}")]
        public ActionResult<Practica> GetById(int id)
        {
            var practica = practicaService.GetByIdPractica(id);
            if (practica is null) return NotFound(new { message = "Practica no encontrada" });

            return Ok(practica);
        }

        //[Authorize(Roles = "Administrador")]
        [HttpPost]
        public ActionResult<Practica> CrearPractica([FromBody] PracticaDTO practica)
        {
            try
            {
                var nuevaPractica = practicaService.CrearPractica(practica);
                return Created(
                    $"https://localhost:7119/practica/{nuevaPractica.PracticaId}",
                    nuevaPractica
                );
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        //[Authorize(Roles = "Administrador")] 
        [HttpPut("{id}")]
        public ActionResult UpdatePractica([FromBody] PracticaDTO practica, int id)
        {
            try
            {
                var practicaActualizada = practicaService.UpdatePractica(practica, id);
                if (practicaActualizada is null) return NotFound(new { message = "Practica no encontrada" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        //[Authorize(Roles = "Administrador")] 
        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoPractica(int id)
        {
            var estadoCambiado = practicaService.CambiarEstadoPractica(id);
            if (!estadoCambiado) return NotFound(new { message = "Practica no encontrada" });

            return NoContent();
        }

        //[Authorize(Roles = "Administrador")]
        [HttpPut("agregarPlanOS/{practicaId}/{planObraSocialId}")]
        public ActionResult<Practica> AgregarPlanObraSocial(int practicaId, int planObraSocialId)
        {
            try
            {
                var planOs = planObraSocialService.GetByNroPlan(planObraSocialId);
                if (planOs is null) return NotFound(new { message = "Plan de Obra Social no encontrado" });

                var practicaActualizada = practicaService.AgregarPlanObraSocial(planOs, practicaId);
                if (practicaActualizada is null) return NotFound(new { message = "Practica o Plan de Obra Social no encontrado" });

                return Ok(practicaActualizada);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        //[Authorize(Roles = "Administrador")]
        [HttpPut("eliminarPlan/{practicaId}/{planId}")]
        public ActionResult RemovePlanFromPractica(int practicaId, int planId)
        {
            bool eliminado = practicaService.EliminarPlanDePractica(practicaId, planId);

            if (!eliminado)
                return NotFound(new { message = "Plan o práctica no encontrada" });

            return Ok(new { message = "Plan eliminado de la práctica exitosamente" });
        }

        [Authorize(Roles = "Administrador")] // ver si se agrega usertype Administrador
        [HttpDelete("{id}")]
        public ActionResult DeletePractica(int id)
        {
            var practicaEliminada = practicaService.EliminarPractica(id);
            if (!practicaEliminada) return NotFound(new { message = "Practica no encontrada" });

            return NoContent();
        }
    }
}
