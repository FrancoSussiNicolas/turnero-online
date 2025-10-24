namespace DTOs
{
    public class ReportePacientesPorObraSocialDTO
    {
        public DateTime FechaGeneracion { get; set; }
        public List<PacientesPorObraSocialItem> Datos { get; set; } = [];
    }
}
