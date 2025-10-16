using API;
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
    public partial class CrearPractica : Form
    {
        private PracticaDTO _practicaExistente;
        public CrearPractica()
        {
            InitializeComponent();
            ConfigurarVistaRegistro();
        }

        public CrearPractica(PracticaDTO practica) : this()
        {
            _practicaExistente = practica;
            ConfigurarVistaModificacion();
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                // Obtener la práctica actualizada desde la API
                _practicaExistente = await PracticaApiClient.GetAsync(_practicaExistente.PracticaId);

                // Transformar los planes a DTOs
                var planesDto = _practicaExistente.PlanObraSocial.Select(p => new PlanObraSocialDTO
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
        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_practicaExistente != null)
            {
                await CargarPracticaAsync(_practicaExistente.PracticaId);
            }
        }

        private async Task CargarPracticaAsync(int practicaId)
        {
            try
            {
                _practicaExistente = await PracticaApiClient.GetAsync(practicaId);

                ConfigurarVistaModificacion();

                // Precargar valores en controles
                textNombrePractica.Text = _practicaExistente.Nombre;
                textDescripcionPractica.Text = _practicaExistente.Descripcion;

                if (_practicaExistente.Estado == EstadoPracticaDTO.Habilitada)
                {
                    btnRadioHabilitado.Checked = true;
                }
                else
                {
                    btnRadioDeshabilitado.Checked = true;
                }

                if (_practicaExistente.PlanObraSocial != null && _practicaExistente.PlanObraSocial.Count > 0)
                {
                    var planesDto = _practicaExistente.PlanObraSocial.Select(p => new PlanObraSocialDTO
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

        private void ConfigurarVistaModificacion()
        {
            this.Text = "Modificar Practica";
            Titulo.Text = this.Text;
            btnRegistrarPractica.Text = "Modificar";
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
            tableLayoutPanelBotones.SetColumn(btnCancelarPractica, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarPractica, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarPractica, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarPractica, 0);

            tableLayoutPanelBotones.SetColumn(btnCancelarPlan, 2);
            tableLayoutPanelBotones.SetRow(btnCancelarPlan, 0);

            // Mostrar todos los botones
            btnCancelarPractica.Visible = true;
            btnRegistrarPractica.Visible = true;
            btnCancelarPlan.Visible = true;

            // Alineación centrada
            btnCancelarPractica.Anchor = AnchorStyles.None;
            btnRegistrarPractica.Anchor = AnchorStyles.None;
            btnCancelarPlan.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }

        private void ConfigurarVistaRegistro()
        {
            // Cambiar texto del formulario y botones
            this.Text = "Registrar Nueva Practica";
            Titulo.Text = this.Text;
            btnRegistrarPractica.Text = "Registrar";
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
            tableLayoutPanelBotones.SetColumn(btnCancelarPractica, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarPractica, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarPractica, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarPractica, 0);

            // Ocultar el tercer botón
            btnCancelarPlan.Visible = false;

            // Alineación centrada
            btnCancelarPractica.Anchor = AnchorStyles.None;
            btnRegistrarPractica.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }

        private async void btnRegistrarPractica_Click(object sender, EventArgs e)
        {
            if ((!btnRadioDeshabilitado.Checked || !btnRadioHabilitado.Checked) && string.IsNullOrWhiteSpace(textNombrePractica.Text) && string.IsNullOrWhiteSpace(textDescripcionPractica.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_practicaExistente == null)
                {
                    PracticaDTO practicaDTO = new PracticaDTO
                    {
                        Nombre = textNombrePractica.Text,
                        Descripcion = textDescripcionPractica.Text,
                        Estado = btnRadioHabilitado.Checked ? EstadoPracticaDTO.Habilitada : EstadoPracticaDTO.Deshabilitada,
                        PlanObraSocial = new List<PlanObraSocialDTO>()
                    };

                    await PracticaApiClient.AddAsync(practicaDTO);

                    MessageBox.Show("Práctica registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    _practicaExistente.Nombre = textNombrePractica.Text;
                    _practicaExistente.Descripcion = textDescripcionPractica.Text;

                    if (btnRadioHabilitado.Checked)
                    {
                        await PracticaApiClient.DisableAsync(_practicaExistente.PracticaId);
                    }
                    else if (btnRadioDeshabilitado.Checked)
                    {
                        await PracticaApiClient.DisableAsync(_practicaExistente.PracticaId);
                    }


                    await PracticaApiClient.UpdateAsync(_practicaExistente);
                    MessageBox.Show("Práctica modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarPractica_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                    $"¿Seguro que deseas cancelar este plan para la práctica '{_practicaExistente.Nombre}'?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes) return;

                // Llamar a la API para deshabilitar el plan (baja lógica)
                await PracticaApiClient.RemovePlanAsync(_practicaExistente.PracticaId, planId);

                // Quitar el plan de la lista en memoria
                _practicaExistente.PlanObraSocial.RemoveAll(p => p.PlanObraSocialId == planId);

                // Recargar el DataGridView con la lista actualizada
                PracticaDTO planesDto = (PracticaDTO)await PracticaApiClient.GetAsync(_practicaExistente.PracticaId);

                CargarPlanesAsignados(_practicaExistente.PlanObraSocial);

                MessageBox.Show("El plan fue cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar el plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
