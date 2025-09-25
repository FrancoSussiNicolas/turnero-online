using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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
                HttpResponseMessage response = await client.GetAsync("admin");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<AdminDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener al Administrador. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al obtener al Administrador: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al obtener al Administrador:: {ex.Message}", ex);
            }
        }

        public static async Task UpdateAsync(AdminDTO admin)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"admin", admin);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar al Administrador . Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar al Administrador: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar al Administrador: {ex.Message}", ex);
            }
        }
    }
}
