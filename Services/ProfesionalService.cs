using Entities;
using DTOs;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ProfesionalService
    {
        public List<Profesional> GetAll()
        {
            using (var context = new TurneroContext())
            {
                return context.Profesionales
                    .Include(p => p.ObraSociales)
                    .ToList();
            }
        }

        public Profesional? GetByIdProfesional(int id)
        {
            using (var context = new TurneroContext())
            {
                return context.Profesionales
                    .Include(p => p.ObraSociales)
                    .FirstOrDefault(pro => pro.PersonaId == id);
            }
        }

        public Profesional CrearProfesional(ProfesionalDTO profesional)
        {
            using (var context = new TurneroContext())
            {
                var newProfesional = new Profesional(
                    profesional.ApellidoNombre,
                    profesional.Mail,
                    profesional.Contrasenia,
                    profesional.Matricula,
                    profesional.EspecialidadId
                );

                context.Profesionales.Add(newProfesional);
                context.SaveChanges();
                return newProfesional;
            }
        }

        public Profesional? UpdateProfesional(ProfesionalDTO pro, int idPro)
        {

            using (var context = new TurneroContext())
            {

                var proEncontrado = context.Profesionales.FirstOrDefault(P => P.PersonaId == idPro);
                if (proEncontrado is null) return null;

                proEncontrado.ApellidoNombre = pro.ApellidoNombre;
                proEncontrado.Mail = pro.Mail;
                proEncontrado.Contrasenia = pro.Contrasenia;
                proEncontrado.Matricula = pro.Matricula;

                context.SaveChanges();
                return proEncontrado;
            }
        }

        public bool EliminarProfesional(int id)
        {

            using (var context = new TurneroContext())
            {
                var pro = context.Profesionales.FirstOrDefault(P => P.PersonaId == id);
                if (pro == null) return false;

                context.Profesionales.Remove(pro);
                context.SaveChanges();
                return true;
            }
        }
    }
}
