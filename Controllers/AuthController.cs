using DTOs;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ProfesionalService profesionalService;
        private readonly PacienteService pacienteService;

        public AuthController (ProfesionalService profesionalService, PacienteService pacienteService)
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build(); ;
            this.profesionalService = profesionalService;
            this.pacienteService = pacienteService;
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Mail) || string.IsNullOrWhiteSpace(request.Password))
                return Unauthorized();

            string usertype = "Paciente";
            Persona? user = pacienteService.GetByEmail(request.Mail);
            if (user is null)
            {
                user = profesionalService.GetByEmail(request.Mail);
                usertype = "Profesional";
            }

            if (user is null || !user.ValidatePassword(request.Password))
                return Unauthorized();

            var jwtService = new JwtService(configuration);
            var token = jwtService.GenerateJwtToken(user, usertype);
            var expiresAt = DateTime.UtcNow.AddMinutes(jwtService.GetExpirationMinutes());

            return Ok(new { token, expiresAt });
        }
    }
}
