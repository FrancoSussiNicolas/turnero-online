using DTOs;
using System.Net.Http.Headers;

namespace API.Clients
{
    public class AuthApiClient
    {
        private static HttpClient client = new HttpClient();
        static AuthApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("auth/login", request);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<LoginResponse>();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new Exception("Correo electrónico o contraseña incorrectos");
                }
                else 
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorContent);
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error al comunicarse con el servidor, inténtelo de nuevo");
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception("El servidor no respondió a su solicitud, inténtelo más tarde");
            }
        }
    }
}
