using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("profesionales")]
    public class ProfesionalController : ControllerBase
    {

        private readonly ProfesionalService profesionalService;

        public ProfesionalController(ProfesionalService profesionalService)
        {
            this.profesionalService = profesionalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Profesional>> GetAll()
        {
            return Ok(profesionalService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Profesional> GetById(int id)
        {

            var p = profesionalService.GetByIdProfesional(id);
            if (p is null) return NotFound();

            return Ok(p);
        }


        [HttpPost]
        public ActionResult<Profesional> CrearProfesional([FromBody] ProfesionalDTO profesional)
        {
            var newProfesional = profesionalService.CrearProfesional(profesional);

            //return CreatedAtAction(nameof(GetById), new { id = newProfesional.IdPersona }, newProfesional);
            return Created($"https://localhost:5078/profesionales/{newProfesional.PersonaId}", newProfesional);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProfesional([FromBody] ProfesionalDTO profesional, int id)
        {
            var updatePro = profesionalService.UpdateProfesional(profesional, id);
            if (updatePro is null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProfesional(int id)
        {
            var deletedPro = profesionalService.EliminarProfesional(id);
            if (!deletedPro) return NotFound();

            return NoContent();
        }

    }
}

