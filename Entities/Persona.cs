using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Entities
{
    [Index(nameof(Mail), IsUnique = true)]
    public abstract class Persona

    {
        public int PersonaId { get; set; }
        public string ApellidoNombre { get; set; }
        public string Mail { get; set; }

        [JsonIgnore]
        public string Contrasenia { get; private set; }

        [JsonIgnore]
        public string Salt { get; private set; }
        
        public Persona() { }

        public Persona(string apellidoNombre, string mail, string contrasenia)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
        }

        public Persona(string apellidoNombre, string mail)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
        }

        public void SetPassword(string password)
        {
            Salt = GenerateSalt();
            Contrasenia = HashPassword(password, Salt);
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            string hashedInput = HashPassword(password, Salt);

            return Contrasenia == hashedInput;
        }

        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            RandomNumberGenerator.Fill(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        private static string HashPassword(string password, string salt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
