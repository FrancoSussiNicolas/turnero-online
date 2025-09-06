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
        private readonly EspecialidadesService especialidadService;

        public ProfesionalController(ProfesionalService profesionalService, EspecialidadesService especialidadService)
        {
            this.profesionalService = profesionalService;
            this.especialidadService = especialidadService;
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
            if (p is null) return NotFound("Profesional no encontrado");

            return Ok(p);
        }


        [HttpPost]
        public ActionResult<Profesional> CrearProfesional([FromBody] ProfesionalDTO profesional)
        {
            var especialidad = especialidadService.GetById(profesional.EspecialidadId);
            if (especialidad is null || especialidad.Estado == EstadoEspecialidad.Deshabilitada)
            {
                return BadRequest("La especialidad no existe o está deshabilitada.");
            }

            var newProfesional = profesionalService.CrearProfesional(profesional);

            //return CreatedAtAction(nameof(GetById), new { id = newProfesional.IdPersona }, newProfesional);
            return Created($"https://localhost:5078/profesionales/{newProfesional.PersonaId}", newProfesional);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProfesional([FromBody] ProfesionalDTO profesional, int id)
        {
            var updatePro = profesionalService.UpdateProfesional(profesional, id);
            if (updatePro is null) return NotFound("Profesional no encontrado");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProfesional(int id)
        {
            var deletedPro = profesionalService.EliminarProfesional(id);
            if (!deletedPro) return NotFound("Profesional no encontrado");

            return NoContent();
        }

    }
}

