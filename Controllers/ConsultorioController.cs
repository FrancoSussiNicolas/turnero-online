using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("consultorios")]
    public class ConsultorioController : ControllerBase
    {
        private readonly ConsultorioService consultorioService;

        public ConsultorioController(ConsultorioService consultorioService)
        {
            this.consultorioService = consultorioService;
        }

        [Authorize(Roles = "Profesional")]
        [HttpGet]
        public ActionResult<IEnumerable<Consultorio>> GetAll()
        {
            return Ok(consultorioService.GetAll());
        }

        [Authorize(Roles = "Profesional")]
        [HttpGet("disponibles")]
        public ActionResult<IEnumerable<Consultorio>> GetAvailable()
        {
            var disponibles = consultorioService.GetAvailable();
            if (!disponibles.Any()) return NotFound(new { message = "No hay consultorios disponibles" });
            return Ok(disponibles);
        }

        [Authorize(Roles = "Profesional")]
        [HttpGet("{nro}")]
        public ActionResult<Consultorio> GetById(int nro)
        {
            var consultorio = consultorioService.GetById(nro);
            if (consultorio is null) return NotFound(new { message = "Consultorio no encontrado" });
                
            return Ok(consultorio);
        }

        [Authorize(Roles = "Administrador")] // ver si se agrega usertype Administrador
        [HttpPost]
        public ActionResult<Consultorio> CrearConsultorio([FromBody] ConsultorioDTO consultorio)
        {
            var newConsul = consultorioService.CreateConsultorio(consultorio);

            return Created($"https://localhost:7119/consultorios/{newConsul.ConsultorioId}", newConsul);
        }

        [Authorize(Roles = "Administrador")] // ver si se agrega usertype Administrador
        [HttpPut("{nro}")]
        public ActionResult UpdateConsultorio([FromBody] ConsultorioDTO consultorio, int nro)
        {
            var updatedConsul = consultorioService.UpdateConsultorio(consultorio, nro);
            if (updatedConsul is null) return NotFound(new { message = "Consultorio no encontrado" });

            return NoContent();
        }

        [Authorize(Roles = "Administrador")] // ver si se agrega usertype Administrador
        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoConsultorio(int id)
        {
            var estadoCambiado = consultorioService.CambiarEstadoConsultorio(id);
            if (!estadoCambiado) return NotFound(new { message = "Consultorio no encontrado" });

            return NoContent();
        }

        [Authorize(Roles = "Administrador")] // ver si se agrega usertype Administrador
        [HttpDelete("{nro}")]
        public ActionResult DeleteConsultorio(int nro)
        {
            var deletedConsul = consultorioService.DeleteConsultorio(nro);
            if (!deletedConsul) return NotFound(new { message = "Consultorio no encontrado" });

            return NoContent();
        }
    }
}
