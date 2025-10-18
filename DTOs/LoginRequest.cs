using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class LoginRequest
    {

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Mail { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public LoginRequest() { }

        public LoginRequest(string mail, string password)
        {
            Mail = mail;
            Password = password;
        }
    }
}
