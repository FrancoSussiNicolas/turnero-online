using API.Clients;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ObraSocialForm : Form
    {
        private ObraSocialDTO _obraSocialExistente;
        public ObraSocialForm()
        {
            InitializeComponent();
            ConfigurarVistaRegistro();
        }
        public ObraSocialForm(ObraSocialDTO obraSocial) : this()
        {
            _obraSocialExistente = obraSocial;
            ConfigurarVistaModificacion();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_obraSocialExistente != null)
            {
                CargarObraSocialAsync(_obraSocialExistente);
            }
        }

        private void CargarObraSocialAsync(ObraSocialDTO obraSocial)
        {
            try
            {
                ConfigurarVistaModificacion();

                // Precargar valores en controles
                textNombreObraSocial.Text = obraSocial.NombreObraSocial;

                if (_obraSocialExistente.Estado == EstadoObraSocialDTO.Habilitada)
                {
                    btnRadioHabilitado.Checked = true;
                }
                else
                {
                    btnRadioDeshabilitado.Checked = true;
                }

                if (_obraSocialExistente.PlanesObraSocial != null && _obraSocialExistente.PlanesObraSocial.Count > 0)
                {
                    var planesDto = _obraSocialExistente.PlanesObraSocial.Select(p => new PlanObraSocialDTO
                    {
                        PlanObraSocialId = p.PlanObraSocialId,
                        NombrePlan = p.NombrePlan,
                        DescripcionPlan = p.DescripcionPlan,
                        ObraSocialId = p.ObraSocialId,
                        Estado = p.Estado
                    }).ToList();

                    CargarPlanesAsignados(planesDto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la práctica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarColumnasEspecificas()
        {
            if (planesAsignadosGridView.Columns.Count > 0)
            {
                // Configurar tamaño relativo de columnas (FillWeight)
                if (planesAsignadosGridView.Columns["PlanObraSocialId"] != null)
                {
                    planesAsignadosGridView.Columns["PlanObraSocialId"].Visible = false;
                }

                if (planesAsignadosGridView.Columns["NombrePlan"] != null)
                {
                    planesAsignadosGridView.Columns["NombrePlan"].FillWeight = 40;
                    planesAsignadosGridView.Columns["NombrePlan"].HeaderText = "Nombre del Plan";
                }

                if (planesAsignadosGridView.Columns["DescripcionPlan"] != null)
                {
                    planesAsignadosGridView.Columns["DescripcionPlan"].FillWeight = 35;
                    planesAsignadosGridView.Columns["DescripcionPlan"].HeaderText = "Descripcion del Plan";
                }

                if (planesAsignadosGridView.Columns["ObraSocialId"] != null)
                {
                    planesAsignadosGridView.Columns["ObraSocialId"].Visible = false;
                }

                if (planesAsignadosGridView.Columns["Estado"] != null)
                {
                    planesAsignadosGridView.Columns["Estado"].FillWeight = 20;
                    planesAsignadosGridView.Columns["Estado"].HeaderText = "Estado";
                }

                // Ajustes generales
                planesAsignadosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                planesAsignadosGridView.AllowUserToResizeColumns = true;
                planesAsignadosGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                planesAsignadosGridView.MultiSelect = false;
            }
        }

        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            planesAsignadosGridView.Dock = DockStyle.None;

            // Las columnas se distribuyen proporcionalmente
            planesAsignadosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            planesAsignadosGridView.AllowUserToResizeColumns = true;
            planesAsignadosGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesAsignadosGridView.MultiSelect = false;
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                // Obtener la práctica actualizada desde la API
                _obraSocialExistente = await ObraSocialApiClient.GetAsync(_obraSocialExistente.ObraSocialId);

                // Transformar los planes a DTOs
                var planesDto = _obraSocialExistente.PlanesObraSocial.Select(p => new PlanObraSocialDTO
                {
                    PlanObraSocialId = p.PlanObraSocialId,
                    NombrePlan = p.NombrePlan,
                    DescripcionPlan = p.DescripcionPlan,
                    ObraSocialId = p.ObraSocialId,
                    Estado = p.Estado
                }).ToList();

                // Recargar el DataGridView
                CargarPlanesAsignados(planesDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recargar planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPlanesAsignados(List<PlanObraSocialDTO> planesAsignados)
        {
            try
            {
                planesAsignadosGridView.DataSource = null;
                planesAsignadosGridView.DataSource = planesAsignados;

                // Configurar columnas específicas
                ConfigurarColumnasEspecificas();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar planes asignados: {ex.Message}",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarVistaModificacion()
        {
            this.Text = "Modificar Obra Social";
            Titulo.Text = this.Text;
            btnRegistrarObraSocial.Text = "Modificar";
            lbSusPlanes.Text = "Sus Planes Asignados:";

            planesAsignadosGridView.Visible = true;
            btnCancelarPlan.Visible = true;
            lbSusPlanes.Visible = true;

            // Ubicar controles a un costado y botón abajo
            tableLayoutPanelBotones.SuspendLayout();

            // Configurar para 3 columnas
            tableLayoutPanelBotones.ColumnCount = 3;
            tableLayoutPanelBotones.RowCount = 1;

            // Limpiar estilos existentes
            tableLayoutPanelBotones.ColumnStyles.Clear();
            tableLayoutPanelBotones.RowStyles.Clear();

            // Configurar columnas con distribución equitativa
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // Configurar fila
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Posicionar controles
            tableLayoutPanelBotones.SetColumn(btnCancelarObraSocial, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarObraSocial, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnCancelarPlan, 2);
            tableLayoutPanelBotones.SetRow(btnCancelarPlan, 0);

            // Mostrar todos los botones
            btnCancelarObraSocial.Visible = true;
            btnRegistrarObraSocial.Visible = true;
            btnCancelarPlan.Visible = true;

            // Alineación centrada
            btnCancelarObraSocial.Anchor = AnchorStyles.None;
            btnRegistrarObraSocial.Anchor = AnchorStyles.None;
            btnCancelarPlan.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }
        private void ConfigurarVistaRegistro()
        {
            // Cambiar texto del formulario y botones
            this.Text = "Registrar Nueva Obra Social";
            Titulo.Text = this.Text;
            btnRegistrarObraSocial.Text = "Registrar";
            planesAsignadosGridView.Visible = false;

            tableLayoutPanelBotones.SuspendLayout();

            // Configurar para 2 columnas
            tableLayoutPanelBotones.ColumnCount = 2;
            tableLayoutPanelBotones.RowCount = 1;

            // Limpiar estilos existentes
            tableLayoutPanelBotones.ColumnStyles.Clear();
            tableLayoutPanelBotones.RowStyles.Clear();

            // Configurar columnas centradas
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Configurar fila
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Posicionar solo 2 botones
            tableLayoutPanelBotones.SetColumn(btnCancelarObraSocial, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarObraSocial, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarObraSocial, 0);

            // Ocultar el tercer botón
            btnCancelarPlan.Visible = false;

            // Alineación centrada
            btnCancelarObraSocial.Anchor = AnchorStyles.None;
            btnRegistrarObraSocial.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }


        private async void btnRegistrarObraSocial_Click(object sender, EventArgs e)
        {
            if ((!btnRadioDeshabilitado.Checked || !btnRadioHabilitado.Checked) && string.IsNullOrWhiteSpace(textNombreObraSocial.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_obraSocialExistente == null)
                {
                    ObraSocialDTO obraSocialDTO = new ObraSocialDTO
                    {
                        NombreObraSocial = textNombreObraSocial.Text,
                        Estado = btnRadioHabilitado.Checked ? EstadoObraSocialDTO.Habilitada : EstadoObraSocialDTO.Deshabilitada,
                        PlanesObraSocial = new List<PlanObraSocialDTO>()
                    };

                    await ObraSocialApiClient.AddAsync(obraSocialDTO);

                    MessageBox.Show("Obra Social registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    _obraSocialExistente.NombreObraSocial = textNombreObraSocial.Text;

                    if (btnRadioHabilitado.Checked)
                    {
                        await ObraSocialApiClient.ChangeStateAsync(_obraSocialExistente.ObraSocialId);
                    }
                    else if (btnRadioDeshabilitado.Checked)
                    {
                        await ObraSocialApiClient.ChangeStateAsync(_obraSocialExistente.ObraSocialId);
                    }

                    await ObraSocialApiClient.UpdateAsync(_obraSocialExistente.ObraSocialId, _obraSocialExistente);
                    MessageBox.Show("Obra Social modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelarPlan_Click(object sender, EventArgs e)
        {
            if (planesAsignadosGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Obtener el plan seleccionado
                PlanObraSocialDTO seleccionado = (PlanObraSocialDTO)planesAsignadosGridView.SelectedRows[0].DataBoundItem;
                int planId = seleccionado.PlanObraSocialId;

                // Confirmación del usuario
                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas cancelar este plan para la obra social '{_obraSocialExistente.NombreObraSocial}'?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes) return;

                // Llamar a la API para deshabilitar el plan (baja lógica)
                await ObraSocialApiClient.RemovePlanAsync(_obraSocialExistente.ObraSocialId, planId);

                // Quitar el plan de la lista en memoria
                _obraSocialExistente.PlanesObraSocial.RemoveAll(p => p.PlanObraSocialId == planId);

                // Traer la obra social actualizada desde la API
                var obraSocialActualizada = await ObraSocialApiClient.GetAsync(_obraSocialExistente.ObraSocialId);

                // Reemplazar la referencia local
                _obraSocialExistente = obraSocialActualizada;

                // Volver a cargar los planes en el grid
                CargarPlanesAsignados(_obraSocialExistente.PlanesObraSocial);

                MessageBox.Show("El plan fue cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar el plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarObraSocial_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
