using DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReportesService
    {
        private readonly string connectionString;

        public ReportesService()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public ReportePacientesPorObraSocialDTO GetPacientesPorObraSocial()
        {
            var reporte = new ReportePacientesPorObraSocialDTO
            {
                FechaGeneracion = DateTime.Now,
                Datos = new List<PacientesPorObraSocialItem>()
            };

            string query = @"
                SELECT 
                    os.ObraSocialId,
                    os.NombreObraSocial,
                    COUNT(DISTINCT p.PersonaId) as CantidadPacientes
                FROM ObrasSociales os
                LEFT JOIN PlanesObrasSociales pos ON os.ObraSocialId = pos.ObraSocialId
                LEFT JOIN Pacientes p ON p.PlanObraSocialId = pos.PlanObraSocialId
                GROUP BY os.ObraSocialId, os.NombreObraSocial
                ORDER BY CantidadPacientes DESC, os.NombreObraSocial";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reporte.Datos.Add(new PacientesPorObraSocialItem
                            {
                                ObraSocialId = reader.GetInt32(0),
                                NombreObraSocial = reader.GetString(1),
                                CantidadPacientes = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }

            return reporte;
        }

        public ReporteProfesionalesPorEspecialidadDTO GetProfesionalesPorEspecialidad()
        {
            var reporte = new ReporteProfesionalesPorEspecialidadDTO
            {
                FechaGeneracion = DateTime.Now,
                Datos = new List<ProfesionalesPorEspecialidadItem>()
            };

            string query = @"
                SELECT 
                    e.EspecialidadId,
                    e.Descripcion,
                    COUNT(p.PersonaId) as CantidadProfesionales
                FROM Especialidades e
                LEFT JOIN Profesionales p ON e.EspecialidadId = p.EspecialidadId
                GROUP BY e.EspecialidadId, e.Descripcion
                ORDER BY CantidadProfesionales DESC, e.Descripcion";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reporte.Datos.Add(new ProfesionalesPorEspecialidadItem
                            {
                                EspecialidadId = reader.GetInt32(0),
                                Descripcion = reader.GetString(1),
                                CantidadProfesionales = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }

            return reporte;
        }
    }
}

