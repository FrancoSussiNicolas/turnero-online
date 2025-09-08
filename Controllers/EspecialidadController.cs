using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("especialidades")]
    public class EspecialidadController : ControllerBase
    {

        private readonly EspecialidadesService especialidadService;

        public EspecialidadController(EspecialidadesService especialidadService)
        {
            this.especialidadService = especialidadService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Especialidad>> GetAll()
        {
            return Ok(especialidadService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Especialidad> GetById(int id)
        {
            var e = especialidadService.GetById(id);
            if (e is null) return NotFound(new { message = "Especialidad no encontrada" });

            return Ok(e);
        }


        [HttpPost]
        public ActionResult<Especialidad> CrearEspecialidad([FromBody] EspecialidadDTO especialidad)
        {
            try
            {
                var newEsp = especialidadService.CreateEspecialidad(especialidad);

                return Created($"https://localhost:7119/especialidades/{newEsp.EspecialidadId}", newEsp);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEspecialidad([FromBody] EspecialidadDTO especialidad, int id)
        {
            try
            {
                var updatedEsp = especialidadService.UpdateEspecialidad(especialidad, id);
                if (updatedEsp is null) return NotFound(new { message = "Especialidad no encontrada" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoEspecialidad(int id)
        {
            var estadoCambiado = especialidadService.CambiarEstadoEspecialidad(id);
            if (!estadoCambiado) return NotFound(new { message = "Especialidad no encontrada" });

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEspecialidad(int id)
        {
            var deletedEsp = especialidadService.DeleteEspecialidad(id);
            if (!deletedEsp) return NotFound(new { message = "Especialidad no encontrada" });

            return NoContent();
        }
    }
}
