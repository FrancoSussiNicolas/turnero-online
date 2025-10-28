using DTOs;
using Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace API.Clients
{
    public class ProfesionalApiClient
    {
        private static HttpClient client = new HttpClient();
        static ProfesionalApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ProfesionalDTO> GetAsync(int id)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"profesionales/{id}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ProfesionalDTO>();
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

        public static async Task<IEnumerable<ProfesionalDTO>> GetAllAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"profesionales");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ProfesionalDTO>>();
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

        public async static Task AddAsync(ProfesionalDTO profesional)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("profesionales", profesional);

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
                var request = new HttpRequestMessage(HttpMethod.Delete, $"profesionales/{id}");
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

        public static async Task UpdateAsync(ProfesionalDTO profesional)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"profesionales/{profesional.PersonaId}")
                {
                    Content = JsonContent.Create(profesional)
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

        public static async Task CambiarEspecialidadProfesional(int profesionalId, int nuevaEspecialidadId)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, $"profesionales/cambiarEspecialidad/{profesionalId}")
                {
                    Content = new StringContent(nuevaEspecialidadId.ToString(), Encoding.UTF8, "application/json")
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
                var request = new HttpRequestMessage(HttpMethod.Patch, $"profesionales/cambiarEstado/{id}");
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

        public static async Task<IEnumerable<ObraSocialDTO>> GetObrasSocialesAsync(int profesionalId)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"profesionales/obrasSociales/{profesionalId}");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ObraSocialDTO>>();
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

        public static async Task EliminarObraSocialAsync(int profesionalId, int obraSocialId)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, $"profesionales/eliminarObraSocial/{profesionalId}/{obraSocialId}");
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

        public static async Task AgregarObraSocialAsync(int profesionalId, int obraSocialId)
        {
            try
            {
                var content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Put, $"profesionales/agregarObraSocial/{profesionalId}/{obraSocialId}")
                {
                    Content = content
                };

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        throw new InvalidOperationException("El profesional ya atiende por esta Obra Social. Por favor, seleccione otra.");
                    }

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

        public static async Task<IEnumerable<ProfesionalDTO>> GetProfesionalByEspecialidad(int especilidadId) 
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"profesionales/especialidad/{especilidadId}");

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ProfesionalDTO>>();
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
