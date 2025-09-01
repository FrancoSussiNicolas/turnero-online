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
        public int ObraSocialId {  get; set; }
        public string NombreObraSocial { get; set; }
        public List<Profesional> Profesional {  get; set; }
        public List<PlanObraSocial> PlanesObraSocial { get; set; }

        public ObraSocial(string nombreObraSocial) {
            NombreObraSocial = nombreObraSocial;
        }
        public void AddProfesionales (Profesional profesional)
        {
            Profesional.Add(profesional);
        }
    }
}
