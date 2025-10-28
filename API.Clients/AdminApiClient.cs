using DTOs;
using Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class AdminApiClient
    {
        private static HttpClient client = new HttpClient();
        static AdminApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<AdminDTO> GetAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "admin");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<AdminDTO>();
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

        public static async Task UpdateAsync(AdminDTO admin)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, "admin")
                {
                    Content = JsonContent.Create(admin)
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode)
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
