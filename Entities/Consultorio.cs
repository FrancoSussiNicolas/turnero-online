using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum EstadoConsultorio
    {
        Habilitado,
        Deshabilitado
    }
    public class Consultorio
    {
        public int ConsultorioId { get; set; }
        public string Ubicacion { get; set; }

        public EstadoConsultorio Estado { get; set; }
        public List<Turno> Turnos { get; set; }
        public Consultorio(string ubicacion)
        {
            Ubicacion = ubicacion;
            Estado = EstadoConsultorio.Habilitado;
            Turnos = [];
        }

        public bool EstaLibre(DateOnly fechaTurno, TimeOnly horaTurno)
        {
            return !this.Turnos.Exists(turno => turno.FechaTurno == fechaTurno && turno.HoraTurno == horaTurno);
        }
    }
}
