using Entities;
using DTOs;

namespace Services
{
    public class ProfesionalService
    {
        public IEnumerable<Profesional> GetAll()
        {
            return Profesional.listaProfesional;
        }

        public Profesional? GetByIdProfesional(int id)
        {
            return Profesional.listaProfesional.FirstOrDefault(pro => pro.IdPersona == id);
        }

        public Profesional CrearProfesional(ProfesionalDTO profesional)
        {
            var newProfesional = new Profesional(
                profesional.ApellidoNombre,
                profesional.Mail,
                profesional.Contrasenia, 
                profesional.Matricula
            );

            Profesional.listaProfesional.Add(newProfesional);
            return newProfesional;

        }

        public Profesional? UpdateProfesional(ProfesionalDTO pro, int idPro)
        {
            var proEncontrado = GetByIdProfesional(idPro);

            if (proEncontrado is null) return null;

            proEncontrado.ApellidoNombre = pro.ApellidoNombre;
            proEncontrado.Mail = pro.Mail;
            proEncontrado.Contrasenia = pro.Contrasenia;
            proEncontrado.Matricula = pro.Matricula;

            return proEncontrado;
        }

        public bool EliminarProfesional(int id)
        {
            var pro = GetByIdProfesional(id);
            if (pro == null) return false;

            Profesional.listaProfesional.Remove(pro);
            return true;
        }

    }
}
