using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("practica")]
    public class PracticaController : ControllerBase
    {
        private readonly PracticaService practicaService;
        private readonly PlanObraSocialService planObraSocialService;

        public PracticaController(PracticaService practicaService, PlanObraSocialService planObraSocialService)
        {
            this.practicaService = practicaService;
            this.planObraSocialService = planObraSocialService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Practica>> GetAll()
        {
            return Ok(practicaService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Practica> GetById(int id)
        {
            var practica = practicaService.GetByIdPractica(id);
            if (practica is null) return NotFound(new { message = "Practica no encontrada" });

            return Ok(practica);
        }

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

        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoPractica(int id)
        {
            var estadoCambiado = practicaService.CambiarEstadoPractica(id);
            if (!estadoCambiado) return NotFound(new { message = "Practica no encontrada" });

            return NoContent();
        }

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

        [HttpDelete("{id}")]
        public ActionResult DeletePractica(int id)
        {
            var practicaEliminada = practicaService.EliminarPractica(id);
            if (!practicaEliminada) return NotFound(new { message = "Practica no encontrada" });

            return NoContent();
        }
    }
}
