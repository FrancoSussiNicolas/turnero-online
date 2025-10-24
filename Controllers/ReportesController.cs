using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("reportes")]
    public class ReportesController : ControllerBase
    {
        private readonly ReportesService reportesService;

        public ReportesController(ReportesService reportesService)
        {
            this.reportesService = reportesService;
        }

        [Authorize(Roles = "Profesional,Administrador")]
        [HttpGet("obras-sociales")]
        public ActionResult<ReportePacientesPorObraSocialDTO> GetPacientesPorObraSocial()
        {
            try
            {
                var reporte = reportesService.GetPacientesPorObraSocial();
                return Ok(reporte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al generar el reporte: {ex.Message}");
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("especialidades")]
        public ActionResult<ReporteProfesionalesPorEspecialidadDTO> GetProfesionalesPorEspecialidad()
        {
            try
            {
                var reporte = reportesService.GetProfesionalesPorEspecialidad();
                return Ok(reporte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al generar el reporte: {ex.Message}");
            }
        }
    }
}
