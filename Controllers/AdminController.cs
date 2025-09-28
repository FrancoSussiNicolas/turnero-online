using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("admin")]
    public class AdminController : ControllerBase
    {
        private readonly AdminService adminService;

        public AdminController(AdminService adminService)
        {
            this.adminService = adminService;
        }

        //[Authorize(Roles = "Administrador")]
        [HttpGet]
        public ActionResult<Admin> GetAdmin()
        {
            return Ok(adminService.GetAdmin());
        }

        [HttpPost] // ----------------- BORRAR -----------------
        public ActionResult<Admin> Create([FromBody] AdminDTO admin)
        {
            try
            {
                var newAdmin = adminService.Create(admin);

                //return CreatedAtAction(nameof(GetById), new { id = newPaciente.IdPersona }, newPaciente);
                return Created($"https://localhost:7119/admin/{newAdmin.PersonaId}", newAdmin);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut]
        public ActionResult<Admin> UpdateAdmin([FromBody] AdminDTO admin)
        {
            try
            {
                var adminUpdated = adminService.UpdateAdmin(admin);

                if (adminUpdated is null) return NotFound(new { message = "Administrador no encontrado" });

                return NoContent();
            }
            catch (InvalidOperationException ex) {
                return Conflict(new { message = "Error al guardar: " + ex.Message });
            }
        }
    }
}
