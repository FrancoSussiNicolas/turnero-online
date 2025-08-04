using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }

        public string Descripcion { get; set; }

        public static List<Especialidad> ListaEspecialidad = new();

        public Especialidad(string desc) {
            IdEspecialidad = ObtenerProximoId();
            Descripcion = desc;
        }

        private static int ObtenerProximoId()
        {
            return ListaEspecialidad.Count == 0 ? 1 : ListaEspecialidad.Max(e => e.IdEspecialidad) + 1;
        }
    }
}
