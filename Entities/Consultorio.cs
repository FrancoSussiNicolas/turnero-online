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
        public int ConsultorioId { get; set; }
        public string Ubicacion { get; set; }
        public List<Turno> Turnos { get; set; }

        public Consultorio(string ubicacion)
        {
            Ubicacion = ubicacion;
            Turnos = [];
        }

        public bool EstaLibre(DateOnly fechaTurno, TimeOnly horaTurno)
        {
            return !this.Turnos.Exists(turno => turno.FechaTurno == fechaTurno && turno.HoraTurno == horaTurno);
        }
    }
}
