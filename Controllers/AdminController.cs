using DTOs;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

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

        [Authorize(Roles = "Administrador")]
        [HttpGet]
        public ActionResult<Admin> GetAdmin()
        {
            return Ok(adminService.GetAdmin());
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut]
        public ActionResult<Admin> UpdateAdmin([FromBody] AdminDTO admin)
        {
            try
            {
                var adminUpdated = adminService.UpdateAdmin(admin);

                if (adminUpdated is null) return NotFound("Administrador no encontrado");

                return NoContent();
            }
            catch (InvalidOperationException ex) {
                return Conflict("Error al guardar: " + ex.Message);
            }
        }
    }
}
