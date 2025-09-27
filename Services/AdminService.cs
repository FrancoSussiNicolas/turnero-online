using DTOs;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminService
    {
        public Admin GetAdmin()
        {
            using (var context = new TurneroContext())
            {
                return context.Admin.First();
            }
        }

        public Admin? GetByEmail(string email)
        {
            using (var context = new TurneroContext())
            {
                return context.Admin.FirstOrDefault(a => a.Mail == email);
            }
        }

        // ----------------- BORRAR -----------------
        public Admin Create(AdminDTO adminData)
        {
            using (var context = new TurneroContext())
            {
                if (context.Admin.Any(a => a.Mail == adminData.Mail))
                {
                    throw new InvalidOperationException("Ya existe un Administrador con el mail ingresado");
                }

                var newAdmin = Admin.Crear(
                    adminData.ApellidoNombre,
                    adminData.Mail,
                    adminData.Contrasenia
                );

                context.Admin.Add(newAdmin);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe un Administrador con el mail ingresado");
                    }

                    throw;
                }

                return newAdmin;
            }
        }

        public Admin? UpdateAdmin(AdminDTO adminData)
        {
            using (var context = new TurneroContext())
            {
                var admin = context.Admin.First();
                if (admin is null) return null;

                admin.ApellidoNombre = adminData.ApellidoNombre;
                admin.Mail = adminData.Mail;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                    {
                        throw new InvalidOperationException("Ya existe un Administrador con el mail ingresado.");
                    }

                    throw;
                }

                return admin;
            }
        }
    }
}
