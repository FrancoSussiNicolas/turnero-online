using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public  class JwtHelper
    {
        public static string? GetUserType(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            var roleClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "role" || c.Type.EndsWith("/role"));

            return roleClaim?.Value;
        }
    }
}
