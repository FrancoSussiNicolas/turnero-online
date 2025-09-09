using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Entities
{
    public enum EstadoPractica
    {
        Habilitada,
        Deshabilitada
    }

    [Index(nameof(Nombre), IsUnique = true)]
    public class Practica
    {
        public int PracticaId { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public EstadoPractica Estado { get; set; }

        public List<PlanObraSocial> PlanObraSocial { get; set; } = new();

        public Practica(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = EstadoPractica.Habilitada;
        }

        public void AddPlanOs(PlanObraSocial planOs)
        {
            this.PlanObraSocial.Add(planOs);
        }
    }
}

