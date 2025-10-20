using API.Clients;
using DTOs;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinFormsApp
{
    public partial class ReporteEspecialidadesForm : Form
    {
        private ReporteProfesionalesPorEspecialidadDTO reporteActual;

        public ReporteEspecialidadesForm()
        {
            InitializeComponent();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                reporteActual = await ReportesApiClient.GetReporteEspecialidadesAsync();

                if (reporteActual != null)
                {
                    MostrarReporte();
                    btnExportarPDF.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (reporteActual == null) return;

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Reporte",
                FileName = $"Reporte_Profesionales_Especialidad_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerarPDF(saveDialog.FileName);
                    MessageBox.Show("Reporte exportado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarReporte()
        {
            lblFecha.Text = $"Fecha de generación: {reporteActual.FechaGeneracion:dd/MM/yyyy HH:mm}";

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = reporteActual.Datos.Select(d => new
            {
                Id = d.EspecialidadId,
                Especialidad = d.Descripcion,
                CantidadProfesionales = d.CantidadProfesionales
            }).ToList();

            if (dgvDatos.Columns.Count > 0)
            {
                dgvDatos.Columns["Id"].Width = 80;
                dgvDatos.Columns["Id"].HeaderText = "ID";
                dgvDatos.Columns["Especialidad"].HeaderText = "Especialidad";
                dgvDatos.Columns["CantidadProfesionales"].HeaderText = "Cantidad";
                dgvDatos.Columns["CantidadProfesionales"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            int totalProfesionales = reporteActual.Datos.Sum(d => d.CantidadProfesionales);
            int especialidadesSinProfesionales = reporteActual.Datos.Count(d => d.CantidadProfesionales == 0);
            int especialidadesConPocosProfesionales = reporteActual.Datos.Count(d => d.CantidadProfesionales > 0 && d.CantidadProfesionales < 3);
            double promedio = reporteActual.Datos.Count > 0 ? reporteActual.Datos.Average(d => d.CantidadProfesionales) : 0;

            lblResumen.Text = $"RESUMEN ESTADÍSTICO:\n" +
                             $"• Total de profesionales: {totalProfesionales}\n" +
                             $"• Promedio por especialidad: {promedio:F2}\n" +
                             $"• Especialidades sin profesionales: {especialidadesSinProfesionales}\n" +
                             $"• Especialidades con pocos profesionales (< 3): {especialidadesConPocosProfesionales}";
        }

        private void GenerarPDF(string rutaArchivo)
        {
            using (PdfWriter writer = new PdfWriter(rutaArchivo))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                Paragraph titulo = new Paragraph("Reporte: Profesionales por Especialidad")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(titulo);

                Paragraph fecha = new Paragraph($"Fecha de generación: {reporteActual.FechaGeneracion:dd/MM/yyyy HH:mm}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(10)
                    .SetMarginBottom(20);
                document.Add(fecha);

                Table table = new Table(3);
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell().Add(new Paragraph("ID")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Especialidad")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad Profesionales")));

                foreach (var item in reporteActual.Datos)
                {
                    table.AddCell(new Cell().Add(new Paragraph(item.EspecialidadId.ToString())));
                    table.AddCell(new Cell().Add(new Paragraph(item.Descripcion)));

                    Cell cellCantidad = new Cell().Add(new Paragraph(item.CantidadProfesionales.ToString())
                        .SetTextAlignment(TextAlignment.CENTER));

                    if (item.CantidadProfesionales == 0)
                    {
                        cellCantidad.Add(new Paragraph().SetFontColor(iText.Kernel.Colors.ColorConstants.RED));
                    }

                    table.AddCell(cellCantidad);
                }

                document.Add(table);

                int totalProfesionales = reporteActual.Datos.Sum(d => d.CantidadProfesionales);
                int especialidadesSinProfesionales = reporteActual.Datos.Count(d => d.CantidadProfesionales == 0);
                double promedio = reporteActual.Datos.Count > 0 ?
                    reporteActual.Datos.Average(d => d.CantidadProfesionales) : 0;

                Paragraph resumen = new Paragraph("\nRESUMEN ESTADÍSTICO:")
                    .SetFontSize(12)
                    .SetMarginTop(20);
                document.Add(resumen);

                List list = new List()
                    .SetMarginLeft(20);
                list.Add(new ListItem($"Total de profesionales: {totalProfesionales}"));
                list.Add(new ListItem($"Promedio por especialidad: {promedio:F2}"));
                list.Add(new ListItem($"Especialidades sin profesionales: {especialidadesSinProfesionales}"));
                document.Add(list);

                if (especialidadesSinProfesionales > 0)
                {
                    Paragraph recomendacion = new Paragraph("\nATENCIÓN: Se recomienda contratar profesionales para las especialidades sin cobertura.")
                        .SetFontSize(10)
                        .SetMarginTop(10);
                    document.Add(recomendacion);
                }

                Paragraph footer = new Paragraph($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(8)
                    .SetMarginTop(30);
                document.Add(footer);
            }
        }
    }
}