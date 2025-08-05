using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConsultorioService
    {
        public IEnumerable<Consultorio> GetAll()
        {
            return Consultorio.ListaConsultorio;
        }

        public Consultorio? GetByNro(int nro)
        {
            return Consultorio.ListaConsultorio.FirstOrDefault(consul => consul.NroConsultorio == nro);
        }

        public Consultorio CreateConsultorio(ConsultorioDTO consultorio)
        {
            var newConsul = new Consultorio(consultorio.Ubicacion);

            Consultorio.ListaConsultorio.Add(newConsul);
            return newConsul;
        }

        public Consultorio? UpdateConsultorio(ConsultorioDTO consultorio, int nro)
        {
            var consulFound = GetByNro(nro);

            if (consulFound is null) return null;

            consulFound.NroConsultorio = consultorio.NroConsultorio;
            consulFound.Ubicacion = consultorio.Ubicacion;

            return consulFound;
        }

        public bool DeleteConsultorio(int nro)
        {
            var consul = GetByNro(nro);
            if (consul == null) return false;

            Consultorio.ListaConsultorio.Remove(consul);
            return true;
        }
    }
}
