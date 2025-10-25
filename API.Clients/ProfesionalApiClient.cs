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
                    throw new Exception($"Error al obtener profesional con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener profesional con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener profesional con Id {id}: {ex.Message}", ex);
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
                    throw new Exception($"Error al obtener lista de profesionales. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de profesionales: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de profesionales: {ex.Message}", ex);
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
                    throw new Exception($"Error al crear profesional. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear profesional: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear profesional: {ex.Message}", ex);
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
                    throw new Exception($"Error al eliminar profesional con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar profesional con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar profesional con Id {id}: {ex.Message}", ex);
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
                    throw new Exception($"Error al actualizar profesional con Id {profesional.PersonaId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar profesional con Id {profesional.PersonaId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar profesional con Id {profesional.PersonaId}: {ex.Message}", ex);
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
                    throw new Exception($"Error al cambiar la especialidad del profesional con Id {profesionalId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al cambiar la especialidad del profesional con Id {profesionalId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al cambiar la especialidad del profesional con Id {profesionalId}: {ex.Message}", ex);
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
                    throw new Exception($"Error al deshabilitar profesional con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al cambiar la especialidad del profesional con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al cambiar la especialidad del profesional con Id {id}: {ex.Message}", ex);
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
                    throw new Exception($"Error al obtener obras sociales del profesional con Id {profesionalId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener obras sociales del profesional con Id {profesionalId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener obras sociales del profesional con Id {profesionalId}: {ex.Message}", ex);
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
                    throw new Exception($"Error al eliminar la Obra Social {obraSocialId} del Profesional {profesionalId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar la obra social del profesional con Id {profesionalId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar la obra social del profesional con Id {profesionalId}: {ex.Message}", ex);
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

                    throw new Exception($"Error al agregar la Obra Social {obraSocialId} al Profesional {profesionalId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al agregar la obra social del profesional con Id {profesionalId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al agregar la obra social del profesional con Id {profesionalId}: {ex.Message}", ex);
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
                    throw new Exception($"Error al obtener especialidad del profesional con Id {especilidadId}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener la especialidad del profesional con Id {especilidadId}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener la epecilalidad del profesional con Id {especilidadId}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<ProfesionalDTO>> GetProfesionalesByEspecialidadAndObraAsync(int especialidadId, int planId)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"profesionales/especialidad/obraSocial?especialidadId={especialidadId}&planId={planId}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                Console.WriteLine($"[API CLIENT] Enviando request: {request.RequestUri}");

                HttpResponseMessage response = await client.SendAsync(request);

               
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return Enumerable.Empty<ProfesionalDTO>();
                }

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception(
                        $"Error al encontrar profesionales con esa especialidad que cubran con la obra social. " +
                        $"Status: {response.StatusCode}, Detalle: {errorContent}");
                }

                var options = new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
                };

                var result = await response.Content.ReadFromJsonAsync<IEnumerable<ProfesionalDTO>>(options);

                return result ?? Enumerable.Empty<ProfesionalDTO>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al buscar profesionales: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al buscar profesionales: {ex.Message}", ex);
            }
        }
    }
}
