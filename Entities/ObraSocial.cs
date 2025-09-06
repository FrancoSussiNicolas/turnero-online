using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [Index(nameof(NombreObraSocial), IsUnique = true)]
    public class ObraSocial
    {
        public int ObraSocialId {  get; set; }

        public string NombreObraSocial { get; set; }

        [JsonIgnore]
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
