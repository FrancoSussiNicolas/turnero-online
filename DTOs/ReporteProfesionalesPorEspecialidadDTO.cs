using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ReporteProfesionalesPorEspecialidadDTO
    {
        public DateTime FechaGeneracion { get; set; }
        public List<ProfesionalesPorEspecialidadItem> Datos { get; set; }
    }
}
