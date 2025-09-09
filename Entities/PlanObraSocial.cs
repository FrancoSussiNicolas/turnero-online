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
    public enum EstadoPlanObraSocial
    {
        Habilitado,
        Deshabilitado
    }

    public class PlanObraSocial
    {
        public int PlanObraSocialId {  get; set; }

        public string NombrePlan { get; set; }

        public string DescripcionPlan { get; set; }

        public EstadoPlanObraSocial Estado { get; set; }

        [JsonIgnore]
        public List<Paciente> Paciente { get; set; }

        public int ObraSocialId { get; set; }

        [JsonIgnore]
        public ObraSocial ObraSocial { get; set; }

        [JsonIgnore]
        public List<Practica> Practica { get; set; }

        public PlanObraSocial(string nombrePlan, string descripcionPlan, int obraSocialId) {
            NombrePlan = nombrePlan;
            DescripcionPlan = descripcionPlan;
            ObraSocialId = obraSocialId;
            Estado = EstadoPlanObraSocial.Habilitado;
        }
    }
}
