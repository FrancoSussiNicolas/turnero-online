using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace API.Clients
{
    public class ObraSocialApiClient
    {
        private static HttpClient client = new HttpClient();
        static ObraSocialApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ObraSocialDTO> GetAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("obraSocial/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ObraSocialDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener obra social con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener obra social con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener obra social con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<ObraSocialDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("obraSocial");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ObraSocialDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de obras sociales. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de obras sociales: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de obras sociales: {ex.Message}", ex);
            }
        }

        public async static Task AddAsync(ObraSocialDTO obraSocial)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("obraSocial", obraSocial);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear obra social. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear obra social: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear obra social: {ex.Message}", ex);
            }
        }

        public static async Task DeleteAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("obraSocial/" + id);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al eliminar obra social con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al eliminar obra social con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al eliminar obra social con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(int id, ObraSocialDTO obraSocial)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"obraSocial/{id}", obraSocial);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar obra social con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar obra social con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar obra social con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task ChangeStateAsync(int id)
        {
            try
            {
                HttpContent content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PatchAsync($"obraSocial/cambiarEstado/{id}", content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al cambiar estado de la obra social con Id {id}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al cambiar estado de la obra social con Id {id}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al cambiar estado de la obra social con Id {id}: {ex.Message}", ex);
            }
        }

        public static async Task<IEnumerable<ObraSocialDTO>> GetDisponiblesAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("obraSocial/disponibles").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<ObraSocialDTO>>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener lista de obras sociales disponibles. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener lista de obras sociales disponibles: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener lista de obras sociales disponibles: {ex.Message}", ex);
            }
        }
    }
}