using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public enum EstadoEspecialidad
    {
        Habilitada,
        Deshabilitada
    }
    public class Especialidad
    {
        public int EspecialidadId { get; set; }

        [Index(IsUnique = true)]
        public string Descripcion { get; set; }
        public List<Profesional> Profesionales { get; set; }

        public EstadoEspecialidad Estado { get; set; }

        public Especialidad(string descripcion) 
        {
            Descripcion = descripcion;
            Estado = EstadoEspecialidad.Habilitada;
            Profesionales = [];
        }
    }
}
