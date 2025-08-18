using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Descripcion { get; set; }
        public List<Profesional> Profesionales { get; set; }

        public Especialidad(string desc) 
        {
            Descripcion = desc;
            Profesionales = [];
        }
    }
}
