using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum EstadoPractica
    {
        Habilitada,
        Deshabilitada
    }
    public class Practica
    {
        public int PracticaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public EstadoPractica Estado { get; set; }

        public static List<PlanObraSocial> PlanObraSocial {  get; set; }

        public Practica(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = EstadoPractica.Habilitada;
        }
    }
}

