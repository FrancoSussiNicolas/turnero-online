using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Consultorio
    {
        public int NroConsultorio { get; set; }
        public string Ubicacion { get; set; }
        public List<Turno> TurnosConsultorio { get; set; }

        static public List<Consultorio> ListaConsultorio = new();

        public Consultorio(string ubicacion)
        {
            NroConsultorio = ObtenerProximoNro();
            Ubicacion = ubicacion;
            TurnosConsultorio = new();
        }

        private static int ObtenerProximoNro()
        {
            return ListaConsultorio.Count == 0 ? 1 : ListaConsultorio.Max(c => c.NroConsultorio) + 1;
        }

        public bool EstaLibre(DateOnly fechaTurno, TimeOnly horaTurno)
        {
            return !this.TurnosConsultorio.Exists(turno => turno.FechaTurno == fechaTurno && turno.HoraTurno == horaTurno);
        }
    }
}
