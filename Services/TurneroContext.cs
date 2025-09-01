using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Services
{
    public class TurneroContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Especialidad> Especialidades {  get; set; }
        public DbSet<Consultorio> Consultorios { get; set; }
        public DbSet<ObraSocial> ObrasSociales { get; set; }
        public DbSet<PlanObraSocial> PlanesObrasSociales { get; set; }
        public DbSet<Practica> Practicas { get; set; }

        public TurneroContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=turnero_db;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                .HasKey(p => p.PersonaId);

            modelBuilder.Entity<Profesional>()
                .HasKey(p => p.PersonaId);
        }
    }
}
