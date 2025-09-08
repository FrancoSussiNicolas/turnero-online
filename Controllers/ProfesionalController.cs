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
        private readonly ObraSocialService obraSocialService;   

        public ProfesionalController(ProfesionalService profesionalService, EspecialidadesService especialidadService, ObraSocialService obraSocialService)
        {
            this.profesionalService = profesionalService;
            this.especialidadService = especialidadService;
            this.obraSocialService = obraSocialService;
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

        [HttpPut("agregarObraSocial/{profesionald}/{obraSocialId}")]
        public ActionResult NuevaObraSocialProfesional(int profesionald, int obraSocialId)
        {
            var profesional = profesionalService.GetByIdProfesional(profesionald);
            if (profesional is null) return NotFound(new { message = "Profesional no encontrado" });

            var obraSocial = obraSocialService.GetByIdObraSocial(obraSocialId);
            if (obraSocial is null) return NotFound(new { message = "Obra Social no encontrada" });

            var profObra = profesionalService.AgregarObraSocial(obraSocial, profesional);

            if (profObra is null ) return NotFound(new { message = "Hubo un problema a la hora de agendar la obra social" });

            return Ok(profObra);
        }
    }
}

