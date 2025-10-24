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

        [Authorize(Roles = "Profesional,Administrador")]
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
            if (!disponibles.Any()) return NotFound("No hay consultorios disponibles");
            return Ok(disponibles);
        }

        [Authorize(Roles = "Profesional")]
        [HttpGet("libres/{fechaTurno}/{horaTurno}")]
        public ActionResult<List<Consultorio>> GetFree(DateOnly fechaTurno, TimeOnly horaTurno)
        {
            var disponibles = consultorioService.GetFree(fechaTurno, horaTurno);
            if (disponibles.Count == 0) return NotFound("No hay consultorios libres");
            return Ok(disponibles);
        }

        [Authorize(Roles = "Profesional")]
        [HttpGet("{nro}")]
        public ActionResult<Consultorio> GetById(int nro)
        {
            var consultorio = consultorioService.GetById(nro);
            if (consultorio is null) return NotFound("Consultorio no encontrado");
                
            return Ok(consultorio);
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPost]
        public ActionResult<Consultorio> CrearConsultorio([FromBody] ConsultorioDTO consultorio)
        {
            var newConsul = consultorioService.CreateConsultorio(consultorio);

            return Created($"https://localhost:7119/consultorios/{newConsul.ConsultorioId}", newConsul);
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPut("{nro}")]
        public ActionResult UpdateConsultorio([FromBody] ConsultorioDTO consultorio, int nro)
        {
            var updatedConsul = consultorioService.UpdateConsultorio(consultorio, nro);
            if (updatedConsul is null) return NotFound("Consultorio no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Administrador")] 
        [HttpPut("cambiarEstado/{id}")]
        public ActionResult CambiarEstadoConsultorio(int id)
        {
            var estadoCambiado = consultorioService.CambiarEstadoConsultorio(id);
            if (!estadoCambiado) return NotFound("Consultorio no encontrado");

            return NoContent();
        }

        [Authorize(Roles = "Administrador")] 
        [HttpDelete("{nro}")]
        public ActionResult DeleteConsultorio(int nro)
        {
            var deletedConsul = consultorioService.DeleteConsultorio(nro);
            if (!deletedConsul) return NotFound("Consultorio no encontrado");

            return NoContent();
        }
    }
}
