using Entities;
using DTOs;

namespace Services
{
    public class PacienteService
    {
        public IEnumerable<Paciente> GetAll() {
            return Paciente.listaPaciente;
        }

        public Paciente? GetByIdPaciente(int idPaciente)
        {
            return Paciente.listaPaciente.FirstOrDefault(pac => pac.IdPersona == idPaciente);
        }

        public Paciente CrearPaciente(PacienteDTO paciente)
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

            Paciente.listaPaciente.Add( newPaciente );
            return newPaciente;

        }

        public Paciente? UpdatePaciente(PacienteDTO pac, int idPac)
        {
            var pacEncontrado = GetByIdPaciente(idPac);

            if (pacEncontrado is null) return null;

            pacEncontrado.ApellidoNombre = pac.ApellidoNombre;
            pacEncontrado.Mail = pac.Mail;
            pacEncontrado.Contrasenia = pac.Contrasenia;
            pacEncontrado.DNI = pac.DNI;
            pacEncontrado.Sexo = pac.Sexo;
            pacEncontrado.FechaNacimiento = pac.FechaNacimiento;
            pacEncontrado.Telefono = pac.Telefono;

            return pacEncontrado;
        }

        public bool EliminarPaciente (int id)
        {
            var pac = GetByIdPaciente(id);
            if (pac == null) return false;

            Paciente.listaPaciente.Remove(pac); 
            return true;
        }

    }
}
