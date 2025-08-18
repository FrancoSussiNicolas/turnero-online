using DTOs;
using Entities;
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

        [HttpGet]
        public ActionResult<IEnumerable<Consultorio>> GetAll()
        {
            return Ok(consultorioService.GetAll());
        }

        [HttpGet("{nro}")]
        public ActionResult<Consultorio> GetById(int nro)
        {

            var consultorio = consultorioService.GetById(nro);
            if (consultorio is null) return NotFound();

            return Ok(consultorio);
        }

        [HttpPost]
        public ActionResult<Consultorio> CrearConsultorio([FromBody] ConsultorioDTO consultorio)
        {
            var newConsul = consultorioService.CreateConsultorio(consultorio);

            return Created($"https://localhost:7119/consultorios/{newConsul.ConsultorioId}", newConsul);
        }

        [HttpPut("{nro}")]
        public ActionResult UpdateConsultorio([FromBody] ConsultorioDTO consultorio, int nro)
        {
            var updatedConsul = consultorioService.UpdateConsultorio(consultorio, nro);
            if (updatedConsul is null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{nro}")]
        public ActionResult DeleteConsultorio(int nro)
        {
            var deletedConsul = consultorioService.DeleteConsultorio(nro);
            if (!deletedConsul) return NotFound();

            return NoContent();
        }
    }
}
