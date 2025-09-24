using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Shared
{
    public static class SessionManager
    {
        public static string? Token { get; private set; }
        public static string? UserType { get; private set; }
        public static string? Mail { get; private set; }
        public static int? PersonaId { get; private set; }
        public static string? ApellidoNombre { get; private set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(Token);

        public static void SetSession(string jwtToken)
        {
            Token = jwtToken;

            var handler = new JwtSecurityTokenHandler();
            var tokenObj = handler.ReadJwtToken(jwtToken);

            UserType = tokenObj.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role || c.Type.EndsWith("/role"))?.Value;
            Mail = tokenObj.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email || c.Type == "unique_name")?.Value;
            ApellidoNombre = tokenObj.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name || c.Type.EndsWith("/name"))?.Value;
            var userIdClaim = tokenObj.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier || c.Type.EndsWith("/nameidentifier"))?.Value;

            if (int.TryParse(userIdClaim, out int parsedId))
            {
                PersonaId = parsedId;
            }
            else
            {
                PersonaId = null;
            }
        }

        public static void ClearSession()
        {
            Token = null;
            UserType = null;
            Mail = null;
            PersonaId = null;
            ApellidoNombre = null;
        }
    }
}
