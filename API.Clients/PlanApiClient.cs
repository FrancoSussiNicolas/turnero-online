using DTOs;
using Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class PlanApiClient
    {

        private static HttpClient client = new HttpClient();
        static PlanApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<PlanObraSocialDTO> GetAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"planObraSocial/{id}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PlanObraSocialDTO>();
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
        public static async Task<IEnumerable<PlanObraSocialDTO>> GetAllAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"planObraSocial");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PlanObraSocialDTO>>();
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

        public async static Task AddAsync(PlanObraSocialDTO plan)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "planObraSocial")
                {
                    Content = JsonContent.Create(plan)
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

        public static async Task UpdateAsync(PlanObraSocialDTO plan)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"planObraSocial/{plan.PlanObraSocialId}")
                {
                    Content = JsonContent.Create(plan)
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
        public static async Task DisableAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Patch, $"planObraSocial/cambiarEstado/{id}");
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
        public static async Task DeleteAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, $"planObraSocial/{id}");
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
