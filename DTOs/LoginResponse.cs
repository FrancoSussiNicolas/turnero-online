
namespace DTOs
{
    public class LoginResponse
    {
        public string Token {  get; set; }
        public DateTime ExpiresAt { get; set; }

        public LoginResponse(string token, DateTime expiresAt)
        {
            Token = token;
            ExpiresAt = expiresAt;
        }
    }
}
