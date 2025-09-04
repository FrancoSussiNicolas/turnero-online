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
            if (practica is null) return NotFound();

            return Ok(practica);
        }

        [HttpPost]
        public ActionResult<Practica> CrearPractica([FromBody] PracticaDTO practica)
        {
            var nuevaPractica = practicaService.CrearPractica(practica);
            return Created(
                $"https://localhost:7119/practica/{nuevaPractica.PracticaId}",
                nuevaPractica
            );
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePractica([FromBody] PracticaDTO practica, int id)
        {
            var practicaActualizada = practicaService.UpdatePractica(practica, id);
            if (practicaActualizada is null) return NotFound();

            return NoContent();
        }

        [HttpPut("deshabilitar/{id}")]
        public ActionResult DisablePractica(int id)
        {
            var disabledEsp = practicaService.DisablePractica(id);
            if (!disabledEsp) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePractica(int id)
        {
            var practicaEliminada = practicaService.EliminarPractica(id);
            if (!practicaEliminada) return NotFound();

            return NoContent();
        }
    }
}
