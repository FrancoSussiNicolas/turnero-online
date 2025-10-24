using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace Services
{
    public class TurneroContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Admin> Admin { get; set; }
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
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                .HasKey(p => p.PersonaId);

            modelBuilder.Entity<Profesional>()
                .HasKey(p => p.PersonaId);

            modelBuilder.Entity<Admin>()
                .HasKey(p => p.PersonaId);

            // Relación Paciente <-> Turno (Uno a Muchos)
            modelBuilder.Entity<Paciente>()
                .HasMany(paciente => paciente.Turno)
                .WithOne(turno => turno.Paciente)
                .HasForeignKey("PacienteId")
                .IsRequired(false); // Un turno puede no tener un paciente asignado

            // Relación Paciente <-> PlanObraSocial (Uno a Muchos)
            modelBuilder.Entity<Paciente>()
                .HasOne(paciente => paciente.PlanObraSocial)
                .WithMany(plan => plan.Paciente)
                .HasForeignKey("PlanObraSocialId")
                .IsRequired(false);

            // Relación ObraSocial <-> PlanObraSocial (Uno a Muchos)
            modelBuilder.Entity<PlanObraSocial>()
                .HasOne(plan => plan.ObraSocial)
                .WithMany(obraSocial => obraSocial.PlanesObraSocial)
                .HasForeignKey("ObraSocialId")
                .IsRequired();

            // Relación Profesional <-> Turno (Uno a Muchos)
            modelBuilder.Entity<Profesional>()
                .HasMany(profesional => profesional.Turnos)
                .WithOne(turno => turno.Profesional)
                .HasForeignKey("ProfesionalId")
                .IsRequired();

            // Relación Consultorio <-> Turno (Uno a Muchos)
            modelBuilder.Entity<Consultorio>()
                .HasMany(consultorio => consultorio.Turnos)
                .WithOne(turno => turno.Consultorio)
                .HasForeignKey("ConsultorioId")
                .IsRequired();

            // Relación Especialidad <-> Profesional (Uno a Muchos)
            modelBuilder.Entity<Profesional>()
                .HasOne(profesional => profesional.Especialidad)
                .WithMany(especialidad => especialidad.Profesionales)
                .HasForeignKey("EspecialidadId")
                .IsRequired();

            // Relación Profesional <-> ObraSocial (Muchos a Muchos)
            modelBuilder.Entity<Profesional>()
                .HasMany(profesional => profesional.ObraSociales)
                .WithMany(obraSocial => obraSocial.Profesional)
                .UsingEntity(j => j.ToTable("ProfesionalObraSocial")); // Tabla intermedia

            // Relación PlanObraSocial <-> Practica (Muchos a Muchos)
            modelBuilder.Entity<PlanObraSocial>()
                .HasMany(plan => plan.Practica)
                .WithMany(practica => practica.PlanObraSocial)
                .UsingEntity(j => j.ToTable("PlanPractica")); // Tabla intermedia
        }
    }
}
