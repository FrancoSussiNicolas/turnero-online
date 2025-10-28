using DTOs;
using Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace API.Clients
{
    public class PracticaApiClient
    {
        private static HttpClient client = new HttpClient();
        static PracticaApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<PracticaDTO> GetAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"practicas/{id}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<PracticaDTO>();
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

        public static async Task<IEnumerable<PracticaDTO>> GetAllAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"practicas");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<PracticaDTO>>();
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

        public async static Task AddAsync(PracticaDTO practica)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "practicas")
                {
                    Content = JsonContent.Create(practica)
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

        public static async Task DeleteAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, $"practicas/{id}");
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

        public static async Task UpdateAsync(PracticaDTO practica)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"practicas/{practica.PracticaId}")
                {
                    Content = JsonContent.Create(practica)
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
                var request = new HttpRequestMessage(HttpMethod.Put, $"practicas/cambiarEstado/{id}");
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

        public async static Task AddPlanAsync(int practicaId, int planObraSocialId)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"practicas/agregarPlanOS/{practicaId}/{planObraSocialId}");
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

        public static async Task RemovePlanAsync(int practicaId, int planObraSocialId)
        { 
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"practicas/eliminarPlan/{practicaId}/{planObraSocialId}");
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

