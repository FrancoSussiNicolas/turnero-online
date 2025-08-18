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
            var pacEncontrado = GetByIdPaciente(idPac);
            if (pacEncontrado is null) return null;

            using (var context = new TurneroContext())
            {

                pacEncontrado.ApellidoNombre = pac.ApellidoNombre;
                pacEncontrado.Mail = pac.Mail;
                pacEncontrado.Contrasenia = pac.Contrasenia;
                pacEncontrado.DNI = pac.DNI;
                pacEncontrado.Sexo = pac.Sexo;
                pacEncontrado.FechaNacimiento = pac.FechaNacimiento;
                pacEncontrado.Telefono = pac.Telefono;

                context.SaveChanges();
                return pacEncontrado;
            }
        }

        public bool EliminarPaciente(int id)
        {
            var pac = GetByIdPaciente(id);
            if (pac == null) return false;

            using (var context = new TurneroContext())
            { 

                context.Pacientes.Remove(pac);
                context.SaveChanges();
                return true;
            }
        }

    }
}
