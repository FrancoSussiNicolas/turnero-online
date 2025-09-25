using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("obraSocial")]
    public class ObraSocialController : ControllerBase
    {
        private readonly ObraSocialService obraSocialService;

        public ObraSocialController (ObraSocialService obraSocialService)
        {
            this.obraSocialService = obraSocialService;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<ObraSocial>> GetAll()
        {
            return Ok(obraSocialService.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<ObraSocial> GetById(int id)
        {
            var os = obraSocialService.GetByIdObraSocial(id);
            if (os is null) return NotFound(new { message = "Obra Social no encontrada" });

            return Ok(os);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public ActionResult<ObraSocial> CrearObraSocial([FromBody] ObraSocialDTO obraSocial)
        {
            try
            {
                var newOS = obraSocialService.CrearObraSocial(obraSocial);

                return Created($"https://localhost:7119/especialidades/{newOS.ObraSocialId}", newOS);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPut("{id}")]
        public ActionResult UpdateObraSocial([FromBody] ObraSocialDTO obraSocial, int id)
        {
            try
            {
                var updatedOS = obraSocialService.UpdateObraSocial(obraSocial, id);
                if (updatedOS is null) return NotFound(new { message = "Obra Social no encontrada" });

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPatch("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoObraSocial(int id)
        {
            var osDisabled = obraSocialService.CambiarEstadoObraSocial(id);
            if (!osDisabled) return NotFound(new { message = "Obra Social no encontrada" });

            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public ActionResult DeleteObraSocial(int id)
        {
            var deletedOS = obraSocialService.EliminarObraSocial(id);
            if (!deletedOS) return NotFound(new { message = "Obra Social no encontrada" });
        
            return NoContent();
        }
    }
}

