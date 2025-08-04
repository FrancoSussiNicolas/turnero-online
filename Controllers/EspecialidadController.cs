using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("especialidades")]
    public class EspecialidadController
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
            if (e is null) return NotFound();

            return Ok(e);
        }


        [HttpPost]
        public ActionResult<Especialidad> CrearEspecialidad([FromBody] EspecialidadDTO especialidad)
        {
            var newEsp = especialidadService.CreateEspecialidad(especialidad);

            return Created($"https://localhost:7275/especialidades/{newEsp.IdEspecialidad}", newEsp);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEspecialidad([FromBody] EspecialidadDTO especialidad, int id)
        {
            var updatedEsp = especialidadService.UpdateEspecialidad(especialidad, id);
            if (updatedEsp is null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEspecialidad(int id)
        {
            var deletedEsp = especialidadService.DeleteEspecialidad(id);
            if (!deletedEsp) return NotFound();

            return NoContent();
        }

    }
}
