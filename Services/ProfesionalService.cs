using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
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

        public Profesional? GetByEmail(string email)
        {
            using (var context = new TurneroContext())
            {
                return context.Profesionales.FirstOrDefault(pro => pro.Mail == email);
            }
        }

        public Profesional CrearProfesional(ProfesionalDTO profesional)
        {
            using (var context = new TurneroContext())
            {
                if (context.Profesionales.Any(p => p.Mail == profesional.Mail))
                {
                    throw new InvalidOperationException("Ya existe un profesional con el mail ingresado");
                }

                if (context.Profesionales.Any(p => p.Matricula == profesional.Matricula))
                {
                    throw new InvalidOperationException("Ya existe un profesional con la matrícula ingresada");
                }

                var newProfesional = Profesional.Crear(
                    profesional.ApellidoNombre,
                    profesional.Mail,
                    profesional.Contrasenia,
                    profesional.Matricula,
                    profesional.EspecialidadId
                );

                context.Profesionales.Add(newProfesional);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe un profesional con el mail o matricula ingresada");
                    }

                    throw;
                }

                return newProfesional;
            }
        }

        public Profesional? UpdateProfesional(ProfesionalDTO pro, int idPro)
        {

            using (var context = new TurneroContext())
            {

                var proEncontrado = context.Profesionales
                    .Include(p => p.ObraSociales)
                    .FirstOrDefault(P => P.PersonaId == idPro);
                if (proEncontrado is null) return null;

                proEncontrado.ApellidoNombre = pro.ApellidoNombre;
                proEncontrado.Mail = pro.Mail;
                proEncontrado.SetPassword(pro.Contrasenia);
                proEncontrado.Matricula = pro.Matricula;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe un profesional con el mail o matricula ingresada");
                    }

                    throw;
                }

                return proEncontrado;
            }
        }

        public Profesional? AgregarObraSocial(ObraSocial obraSocial, int profesionalId) 
        {
            using (var context = new TurneroContext()) 
            { 
                var proEncontrado = context.Profesionales
                    .Include(p => p.ObraSociales)
                    .FirstOrDefault(p => p.PersonaId == profesionalId);
                if (proEncontrado is null) return null;
                
                proEncontrado.AddObraSocial(obraSocial);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("El profesional ya tiene la obra social asignada");
                    }

                    throw;
                }

                return proEncontrado;
            }
        }

        public bool CambiarEstadoProfesional(int profesionalId)
        {
            using (var context = new TurneroContext())
            {
                var prof = context.Profesionales.FirstOrDefault(p => p.PersonaId == profesionalId);
                if (prof is null) return false;

                prof.Estado = prof.Estado == EstadoProfesional.Habilitado ? EstadoProfesional.Deshabilitado : EstadoProfesional.Habilitado;
                context.SaveChanges();
                return true;
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
