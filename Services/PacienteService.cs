using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PacienteService
    {
        public List<Paciente> GetAll() 
        {
            using (var context = new TurneroContext())
            {
                return context.Pacientes
                    .Include(p => p.PlanObraSocial)
                    .ToList();
            }
        }

        public Paciente? GetByIdPaciente(int idPaciente)
        {
            using (var context = new TurneroContext())
            {
                return context.Pacientes
                    .Include(p => p.PlanObraSocial)
                    .FirstOrDefault(pac => pac.PersonaId == idPaciente);
            }
        }

        public Paciente? GetByEmail(string email)
        {
            using (var context = new TurneroContext())
            {
                return context.Pacientes.FirstOrDefault(pac => pac.Mail == email);
            }
        }

        public Paciente CrearPaciente(PacienteDTO paciente)
        {
            using (var context = new TurneroContext())
            {
                if (context.Pacientes.Any(p => p.Mail == paciente.Mail))
                {
                    throw new InvalidOperationException("Ya existe un paciente con el mail ingresado");
                }

                if (context.Pacientes.Any(p => p.Dni == paciente.DNI))
                {
                    throw new InvalidOperationException("Ya existe un paciente con el DNI ingresado");
                }

                var newPaciente = Paciente.Crear(
                    paciente.ApellidoNombre,
                    paciente.Mail,
                    paciente.Contrasenia,
                    paciente.DNI,
                    paciente.Sexo,
                    paciente.FechaNacimiento,
                    paciente.Telefono,
                    paciente.PlanObraSocialId
                );

                context.Pacientes.Add(newPaciente);
                
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe un paciente con el dni o mail ingresados");
                    }

                    throw;
                }

                return newPaciente;
            }
        }

        public Paciente? UpdatePaciente(PacienteDTO pac, int idPac)
        {
            using (var context = new TurneroContext())
            {
                var pacEncontrado = context.Pacientes.FirstOrDefault(p => p.PersonaId == idPac);
                if (pacEncontrado is null) return null;

                pacEncontrado.ApellidoNombre = pac.ApellidoNombre;
                pacEncontrado.Mail = pac.Mail;
                pacEncontrado.Dni = pac.DNI;
                pacEncontrado.Sexo = pac.Sexo;
                pacEncontrado.FechaNacimiento = pac.FechaNacimiento;
                pacEncontrado.Telefono = pac.Telefono;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe una paciente con el dni o mail ingresados.");
                    }

                    throw;
                }

                return pacEncontrado;
            }
        }

        public bool EliminarPaciente(int id)
        {
            using (var context = new TurneroContext())
            {
                var pac = context.Pacientes.FirstOrDefault(p => p.PersonaId == id);
                if (pac == null) return false;

                context.Pacientes.Remove(pac);
                context.SaveChanges();
                return true;
            }
        }
    }
}
