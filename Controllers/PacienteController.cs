using Microsoft.AspNetCore.Mvc;
using Entities;
using DTOs;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("pacientes")]
    public class PacienteController : ControllerBase
    {

        private readonly PacienteService pacienteService;

        public PacienteController(PacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> GetAll()
        {
            return Ok(pacienteService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Paciente> GetById(int id)
        {

            var p = pacienteService.GetByIdPaciente(id);
            if (p is null) return NotFound();

            return Ok(p);
        }


        [HttpPost]
        public ActionResult<Paciente> CrearPaciente([FromBody] PacienteDTO paciente)
        {
            var newPaciente = pacienteService.CrearPaciente(paciente);

            //return CreatedAtAction(nameof(GetById), new { id = newPaciente.IdPersona }, newPaciente);
            return Created($"https://localhost:7275/pacientes/{newPaciente.IdPersona}", newPaciente); 
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePaciente([FromBody] PacienteDTO paciente, int id)
        {
            var updatePac = pacienteService.UpdatePaciente(paciente, id); 
            if(updatePac is null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePaciente (int id) 
        {
            var eliminadoPac = pacienteService.EliminarPaciente(id);
            if(!eliminadoPac) return NotFound();

            return NoContent();
        }

    }
}
