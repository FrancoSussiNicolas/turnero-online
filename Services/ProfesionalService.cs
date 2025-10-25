using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static DTOs.ProfesionalDTO;

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

                if (proEncontrado is null)
                {
                    return null;
                }

                if (proEncontrado.ObraSociales.Any(os => os.ObraSocialId == obraSocial.ObraSocialId))
                {
                    throw new InvalidOperationException("El profesional ya atiende por esta obra social.");
                }

                proEncontrado.AddObraSocial(obraSocial);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is Microsoft.Data.SqlClient.SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("El profesional ya atiende por esta obra social.");
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
        public bool CambiarEspecialidadProfesional(int profesionalId, int nuevaEspecialidadId)
        {
            using (var context = new TurneroContext())
            {
                var profesional = context.Profesionales.FirstOrDefault(p => p.PersonaId == profesionalId);

                if (profesional == null)
                {
                    return false;
                }

                var nuevaEspecialidad = context.Especialidades.FirstOrDefault(e => e.EspecialidadId == nuevaEspecialidadId);

                if (nuevaEspecialidad == null)
                {
                    return false;
                }

                profesional.EspecialidadId = nuevaEspecialidadId;
                context.SaveChanges();
                return true;
            }
        }

        public IEnumerable<ObraSocial> GetObrasSocialesByProfesionalId(int profesionalId)
        {
            using (var context = new TurneroContext())
            {
                var obrasSociales = context.Profesionales
                    .Where(p => p.PersonaId == profesionalId)
                    .SelectMany(p => p.ObraSociales) 
                    .ToList();

                return obrasSociales;
            }
        }
       
        public bool EliminarObraSocial(int profesionalId, int obraSocialId)
        {
            using (var context = new TurneroContext())
            {
                var profesional = context.Profesionales
                    .Include(p => p.ObraSociales)
                    .FirstOrDefault(p => p.PersonaId == profesionalId);

                if (profesional == null)
                {
                    return false;
                }

                var obraSocialToRemove = profesional.ObraSociales
                    .FirstOrDefault(os => os.ObraSocialId == obraSocialId);

                if (obraSocialToRemove == null)
                {
                    return false;
                }

                profesional.ObraSociales.Remove(obraSocialToRemove);
                context.SaveChanges();
                return true;
            }
        }

        public IEnumerable<Profesional> GetProfesionalByEspecialidad(int especialidadId)
        {
            using (var context = new TurneroContext())
            {
                var profesionales = context.Profesionales
                    .Include(p => p.Especialidad)
                    .Include(p => p.ObraSociales) 
                    .Where(p => p.EspecialidadId == especialidadId && p.Estado == EstadoProfesional.Habilitado)
                    .ToList();

                return profesionales;
            }
        }

        public IEnumerable<ProfesionalDTO> GetProfesionalByEspecialidadAndObra(int especialidadId, int planId)
        {
            using (var context = new TurneroContext())
            {

                var profesionales = context.Profesionales
                    .Include(p => p.ObraSociales)
                        .ThenInclude(o => o.PlanesObraSocial)
                    .Where(p => p.EspecialidadId == especialidadId &&
                        (
                            p.ObraSociales.Any(o => o.PlanesObraSocial.Any(pl => pl.PlanObraSocialId == planId))
                            ||
                            !p.ObraSociales.Any()
                        ) && p.Estado == EstadoProfesional.Habilitado
                    )
                    .ToList();

                // Mapear a DTO
                var profesionalesDTO = profesionales.Select(p => new ProfesionalDTO
                {
                    PersonaId = p.PersonaId,
                    ApellidoNombre = p.ApellidoNombre,
                    Mail = p.Mail,
                    Contrasenia = p.Contrasenia ?? "", 
                    Matricula = p.Matricula,
                    EspecialidadId = p.EspecialidadId,
                    Estado = (EstadoProfesionalDTO)p.Estado,
                    ObraSociales = p.ObraSociales?.Select(os => new ObraSocialDTO
                    {
                        ObraSocialId = os.ObraSocialId,
                        NombreObraSocial = os.NombreObraSocial,
                        Estado = (EstadoObraSocialDTO)os.Estado
                    }).ToList() ?? new List<ObraSocialDTO>()
                }).ToList();

                return profesionalesDTO;
            }
        }
    }
}
