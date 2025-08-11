using Microsoft.AspNetCore.JsonPatch.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ObraSocial
    {
        public int IdObraSocial {  get; set; }
        public string NombreObraSocial { get; set; }

        public static List<ObraSocial> ListaObraSociales = new List<ObraSocial>();

        public List<Profesional> Profesionales {  get; set; }
        public List<PlanObraSocial> PlanesObraSocial { get; set; }


        public ObraSocial(string nombreObraSocial) {

            IdObraSocial = ObtenerProximoId();
            NombreObraSocial = nombreObraSocial;
        }

        public void AddPlanes(PlanObraSocial planObraSocial)
        {
            PlanesObraSocial.Add(planObraSocial);
        }

        public void AddProfesionales (Profesional profesional)
        {
            Profesionales.Add(profesional);
        }

        private static int ObtenerProximoId()
        {
            return ListaObraSociales.Count == 0 ? 1 : ListaObraSociales.Max(a => a.IdObraSocial) + 1;
        }
    }
}
