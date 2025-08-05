using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum EstadoTurno
    {
        Disponible,
        Ocupado
    }

    public class Turno
    {
        public int IdTurno { get; set; }
        public DateOnly FechaTurno { get; set; }
        public TimeOnly HoraTurno { get; set; }
        public EstadoTurno Estado { get; set; }

        static public List<Turno> ListaTurno = new();

        public Turno(DateOnly fecha, TimeOnly hora, EstadoTurno estado) 
        {
            IdTurno = ObtenerProximoId();
            FechaTurno = fecha;
            HoraTurno = hora;
            Estado = estado;
        }

        private static int ObtenerProximoId()
        {
            return ListaTurno.Count == 0 ? 1 : ListaTurno.Max(t => t.IdTurno) + 1;
        }
    }
}
