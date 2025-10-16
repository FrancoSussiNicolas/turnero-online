using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 

namespace Entities
{
    public enum EstadoEspecialidad
    {
        Habilitada,
        Deshabilitada
    }

    [Index(nameof(Descripcion), IsUnique = true)]
    public class Especialidad
    {
        public int EspecialidadId { get; set; }

        public string Descripcion { get; set; }

        public List<Profesional> Profesionales { get; set; } = new();

        public EstadoEspecialidad Estado { get; set; }

        public Especialidad(string descripcion) 
        {
            Descripcion = descripcion;
            Estado = EstadoEspecialidad.Habilitada;
            Profesionales = [];
        }
    }
}
