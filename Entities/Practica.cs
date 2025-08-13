using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{ 
    public class Practica
    {
        public int IdPractica { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public static List<Practica> ListaPracticas  = new();

        public static List<PlanObraSocial> listaPlanesObraSocial = new();

        public Practica(string nombre, string descripcion)
        {
            IdPractica = ObtenerProximoId();
            Nombre = nombre;
            Descripcion = descripcion;
        }

        private static int ObtenerProximoId()
        {
            return ListaPracticas.Count == 0 ? 1 : ListaPracticas.Max(a => a.IdPractica) + 1;
        }
    }
}

