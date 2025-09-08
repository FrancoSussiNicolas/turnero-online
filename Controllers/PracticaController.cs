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

        public PracticaController(PracticaService practicaService)
        {
            this.practicaService = practicaService;
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

        [HttpDelete("{id}")]
        public ActionResult DeletePractica(int id)
        {
            var practicaEliminada = practicaService.EliminarPractica(id);
            if (!practicaEliminada) return NotFound(new { message = "Practica no encontrada" });

            return NoContent();
        }
    }
}
