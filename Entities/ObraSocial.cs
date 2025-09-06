using Microsoft.AspNetCore.JsonPatch.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ObraSocial
    {
        public int ObraSocialId {  get; set; }

        [Index(IsUnique = true)]
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
