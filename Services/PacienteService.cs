using DTOs;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PacienteService
    {
        public List<Paciente> GetAll() {
            using (var context = new TurneroContext())
            {
                return context.Pacientes.ToList();
            }
        }

        public Paciente? GetByIdPaciente(int idPaciente)
        {
            using (var context = new TurneroContext())
            {
                return context.Pacientes.FirstOrDefault(pac => pac.PersonaId == idPaciente);
            }
        }

        public Paciente CrearPaciente(PacienteDTO paciente)
        {
            using (var context = new TurneroContext())
            {
                var newPaciente = new Paciente(
                    paciente.ApellidoNombre,
                    paciente.Mail,
                    paciente.Contrasenia,
                    paciente.DNI,
                    paciente.Sexo,
                    paciente.FechaNacimiento,
                    paciente.Telefono
                );

                context.Pacientes.Add(newPaciente);
                context.SaveChanges();
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
                pacEncontrado.Contrasenia = pac.Contrasenia;
                pacEncontrado.Dni = pac.DNI;
                pacEncontrado.Sexo = pac.Sexo;
                pacEncontrado.FechaNacimiento = pac.FechaNacimiento;
                pacEncontrado.Telefono = pac.Telefono;

                context.SaveChanges();
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
