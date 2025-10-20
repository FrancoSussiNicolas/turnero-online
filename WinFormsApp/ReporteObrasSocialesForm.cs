using API.Clients;
using DTOs;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ScottPlot;

namespace WinFormsApp
{
    public partial class ReporteObrasSocialesForm : Form
    {
        private ReportePacientesPorObraSocialDTO reporteActual;

        public ReporteObrasSocialesForm()
        {
            InitializeComponent();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                reporteActual = await ReportesApiClient.GetReporteObrasSocialesAsync();

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
                FileName = $"Reporte_Pacientes_ObraSocial_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerarPDF(saveDialog.FileName);
                    MessageBox.Show("Reporte exportado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarReporte()
        {
            lblFecha.Text = $"Fecha de generación: {reporteActual.FechaGeneracion:dd/MM/yyyy HH:mm}";

            formsPlot.Plot.Clear();

            double[] valores = reporteActual.Datos.Select(d => (double)d.CantidadPacientes).ToArray();
            string[] etiquetas = reporteActual.Datos.Select(d => d.NombreObraSocial).ToArray();
            double[] posiciones = Enumerable.Range(0, valores.Length).Select(i => (double)i).ToArray();

            var barPlot = formsPlot.Plot.Add.Bars(posiciones, valores);

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == 0)
                {
                    barPlot.Bars[i].FillColor = ScottPlot.Color.FromHex("#e74c3c");
                }
                else
                {
                    barPlot.Bars[i].FillColor = ScottPlot.Color.FromHex("#3498db");
                }
            }

            formsPlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(posiciones, etiquetas);
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = -40;
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

            formsPlot.Plot.Axes.Bottom.Label.Text = "Obras Sociales";
            formsPlot.Plot.Axes.Bottom.Label.FontSize = 12;
            formsPlot.Plot.Axes.Bottom.Label.Bold = true;
            formsPlot.Plot.Axes.Bottom.Label.OffsetY = 5; 

            formsPlot.Plot.Axes.Left.Label.Text = "Cantidad de Pacientes";
            formsPlot.Plot.Axes.Left.Label.FontSize = 12;
            formsPlot.Plot.Axes.Left.Label.Bold = true;

            formsPlot.Plot.Title("Cantidad de Pacientes por Obra Social");
            formsPlot.Plot.Axes.Margins(bottom: 0.4); 

            formsPlot.Refresh();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = reporteActual.Datos.Select(d => new
            {
                Id = d.ObraSocialId,
                ObraSocial = d.NombreObraSocial,
                CantidadPacientes = d.CantidadPacientes
            }).ToList();

            if (dgvDatos.Columns.Count > 0)
            {
                dgvDatos.Columns["Id"].Width = 80;
                dgvDatos.Columns["ObraSocial"].HeaderText = "Obra Social";
                dgvDatos.Columns["CantidadPacientes"].HeaderText = "Cantidad de Pacientes";
                dgvDatos.Columns["CantidadPacientes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void GenerarPDF(string rutaArchivo)
        {
            string tempImagePath = Path.Combine(Path.GetTempPath(), $"grafico_temp_{Guid.NewGuid()}.png");

            try
            {
                formsPlot.Plot.Save(tempImagePath, 800, 400);

                if (!File.Exists(tempImagePath))
                {
                    throw new Exception("No se pudo generar la imagen del gráfico");
                }

                using (PdfWriter writer = new PdfWriter(rutaArchivo))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    Paragraph titulo = new Paragraph("Reporte: Pacientes por Obra Social")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(18);
                    document.Add(titulo);

                    Paragraph fecha = new Paragraph($"Fecha de generación: {reporteActual.FechaGeneracion:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10)
                        .SetMarginBottom(20);
                    document.Add(fecha);

                    var imageData = iText.IO.Image.ImageDataFactory.Create(tempImagePath);
                    iText.Layout.Element.Image img = new iText.Layout.Element.Image(imageData);
                    img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    img.SetWidth(500);
                    document.Add(img);

                    Table table = new Table(3);
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.SetMarginTop(20);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("ID")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Obra Social")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad Pacientes")));

                    foreach (var item in reporteActual.Datos)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(item.ObraSocialId.ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(item.NombreObraSocial)));
                        table.AddCell(new Cell().Add(new Paragraph(item.CantidadPacientes.ToString())
                            .SetTextAlignment(TextAlignment.CENTER)));
                    }

                    document.Add(table);

                    int totalPacientes = reporteActual.Datos.Sum(d => d.CantidadPacientes);
                    Paragraph resumen = new Paragraph($"\nTotal de pacientes: {totalPacientes}")
                        .SetFontSize(12)
                        .SetMarginTop(20);
                    document.Add(resumen);

                    Paragraph footer = new Paragraph($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFontSize(8)
                        .SetMarginTop(30);
                    document.Add(footer);
                }
            }
            finally
            {
                try
                {
                    if (File.Exists(tempImagePath))
                    {
                        File.Delete(tempImagePath);
                    }
                }
                catch { }
            }
        }
    }
}