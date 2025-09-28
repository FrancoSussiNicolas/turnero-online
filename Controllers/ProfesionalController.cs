using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<Profesional>> GetAll()
        {
            return Ok(profesionalService.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<Profesional> GetById(int id)
        {

            var p = profesionalService.GetByIdProfesional(id);
            if (p is null) return NotFound(new { message = "Profesional no encontrado" });

            return Ok(p);
        }

        [HttpPost]
        public ActionResult<Profesional> CrearProfesional([FromBody] ProfesionalDTO profesional)
        {
            try
            {
                var especialidad = especialidadService.GetById(profesional.EspecialidadId);
                if (especialidad is null || especialidad.Estado == EstadoEspecialidad.Deshabilitada)
                {
                    return BadRequest(new { message = "La especialidad no existe o está deshabilitada." });
                }

                var newProfesional = profesionalService.CrearProfesional(profesional);

                //return CreatedAtAction(nameof(GetById), new { id = newProfesional.IdPersona }, newProfesional);
                return Created($"https://localhost:5078/profesionales/{newProfesional.PersonaId}", newProfesional);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Profesional")]
        [HttpPut("{id}")]
        public ActionResult UpdateProfesional([FromBody] ProfesionalDTO profesional, int id)
        {
            try
            {
                var updatePro = profesionalService.UpdateProfesional(profesional, id);
                if (updatePro is null) return NotFound(new { message = "Profesional no encontrado" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpPatch("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoProfesional(int id)
        {
            var profDisabled = profesionalService.CambiarEstadoProfesional(id);
            if (!profDisabled) return NotFound(new { message = "Profesional no encontrado" });

            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public ActionResult DeleteProfesional(int id)
        {
            var deletedPro = profesionalService.EliminarProfesional(id);
            if (!deletedPro) return NotFound(new { message = "Profesional no encontrado" });

            return NoContent();
        }

        [Authorize(Roles = "Profesional")] 
        [HttpPut("agregarObraSocial/{profesionalId}/{obraSocialId}")]
        public ActionResult NuevaObraSocialProfesional(int profesionalId, int obraSocialId)
        {
            try
            {
                var obraSocial = obraSocialService.GetByIdObraSocial(obraSocialId);
                if (obraSocial is null) return NotFound(new { message = "Obra Social no encontrada" });

                var profObra = profesionalService.AgregarObraSocial(obraSocial, profesionalId);
                
                if (profObra is null) return NotFound(new { message = $"Profesional no encontrado" });

                return Ok(profObra);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [HttpPut("cambiarEspecialidad/{profesionalId}")]
        public IActionResult CambiarEspecialidadProfesional(int profesionalId, [FromBody] int nuevaEspecialidadId)
        {
            var resultado = profesionalService.CambiarEspecialidadProfesional(profesionalId, nuevaEspecialidadId);

            if (resultado)
            {
                return Ok(new { message = "Especialidad del profesional actualizada con éxito." });
            }
            else
            {
                return NotFound(new { message = "Profesional o especialidad no encontrada." });
            }
        }

        [Authorize]
        [HttpGet("obrasSociales/{id}")]
        public ActionResult<IEnumerable<ObraSocial>> GetObrasSocialesByProfesionalId(int id)
        {
            var profesional = profesionalService.GetByIdProfesional(id);
            if (profesional is null)
            {
                return NotFound(new { message = "Profesional no encontrado" });
            }

            var obrasSociales = profesionalService.GetObrasSocialesByProfesionalId(id);

            return Ok(obrasSociales);
        }

        [Authorize(Roles = "Profesional")]
        [HttpDelete("eliminarObraSocial/{profesionalId}/{obraSocialId}")]
        public ActionResult EliminarObraSocialProfesional(int profesionalId, int obraSocialId)
        {
            try
            {
                var obraSocial = obraSocialService.GetByIdObraSocial(obraSocialId);
                if (obraSocial is null) return NotFound(new { message = "Obra Social no encontrada." });

                var deleted = profesionalService.EliminarObraSocial(profesionalId, obraSocialId);

                if (!deleted)
                {
                    return NotFound(new { message = "Profesional no encontrado o la Obra Social no estaba asociada." });
                }

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al intentar eliminar la Obra Social: " + ex.Message });
            }
        }


    }
}

