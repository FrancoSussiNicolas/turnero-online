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

        public List<ObraSocial> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.ObrasSociales.ToList();
            }
        }

        public ObraSocial? GetByIdObraSocial(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.ObrasSociales.FirstOrDefault(pro => pro.ObraSocialId == id);
            }
        }

        public ObraSocial CrearObraSocial(ObraSocialDTO obraSocial)
        {
            using (var context = new TurneroContext())
            {
                var newObraSocial = new ObraSocial(
                  obraSocial.NombreObraSocial
                );

                context.ObrasSociales.Add(newObraSocial);
                context.SaveChanges();
                return newObraSocial;
            }

        }

        public ObraSocial? UpdateObraSocial(ObraSocialDTO os, int idOs)
        {

            using (var context = new TurneroContext())
            {

                var obraSocialEncontrado = context.ObrasSociales.FirstOrDefault(os => os.ObraSocialId == idOs);

                if (obraSocialEncontrado is null) return null;

                obraSocialEncontrado.NombreObraSocial = os.NombreObraSocial;

                context.SaveChanges();
                return obraSocialEncontrado;
            }
        }

        public bool EliminarObraSocial(int id)
        {
            var os = GetByIdObraSocial(id);
            if (os == null) return false;

            using (var context = new TurneroContext())
            {
                context.ObrasSociales.Remove(os);
                context.SaveChanges();
                return true;
            }
        }

    }
}

