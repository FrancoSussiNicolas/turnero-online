using DTOs;
using Shared;
using System.Net.Http.Headers;

namespace API.Clients
{
    public class ReportesApiClient
    {
        private static HttpClient client = new HttpClient();

        static ReportesApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7119/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ReportePacientesPorObraSocialDTO> GetReporteObrasSocialesAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "reportes/obras-sociales");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ReportePacientesPorObraSocialDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al generar el reporte solicitado. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al generar el reporte solicitado: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al generar el reporte solicitado: {ex.Message}", ex);
            }
        }

        public static async Task<ReporteProfesionalesPorEspecialidadDTO> GetReporteEspecialidadesAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "reportes/especialidades");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<ReporteProfesionalesPorEspecialidadDTO>();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al generar el reporte solicitado. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al generar el reporte solicitado: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al generar el reporte solicitado: {ex.Message}", ex);
            }
        }
    }
}
