using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DTOs;

namespace Services
{
    public class ObraSocialService
    {

        public IEnumerable<ObraSocial> GetAll()
        {
            return ObraSocial.ListaObraSociales;
        }

        public ObraSocial? GetByIdObraSocial(int id)
        {
            return ObraSocial.ListaObraSociales.FirstOrDefault(pro => pro.IdObraSocial == id);
        }

        public ObraSocial CrearObraSocial(ObraSocialDTO obraSocial)
        {
            var newObraSocial = new ObraSocial(
                  obraSocial.NombreObraSocial
            );

            ObraSocial.ListaObraSociales.Add(newObraSocial);
            return newObraSocial;

        }

        public ObraSocial? UpdateObraSocial(ObraSocialDTO os, int idOs)
        {
            var obraSocialEncontrado = GetByIdObraSocial(idOs);

            if (obraSocialEncontrado is null) return null;

            obraSocialEncontrado.NombreObraSocial = os.NombreObraSocial;

            return obraSocialEncontrado;
        }

        public bool EliminarObraSocial(int id)
        {
            var os = GetByIdObraSocial(id);
            if (os == null) return false;

            ObraSocial.ListaObraSociales.Remove(os);
            return true;
        }

    }
}

