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
                MessageBox.Show($"Error al cargar la obra social y sus planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarColumnasEspecificas()
        {
            if (planesAsignadosGridView.Columns.Count > 0)
            {
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

                planesAsignadosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                planesAsignadosGridView.AllowUserToResizeColumns = true;
                planesAsignadosGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                planesAsignadosGridView.MultiSelect = false;
            }
        }

        private void ConfigurarDataGridView()
        {
            planesAsignadosGridView.Dock = DockStyle.None;

            planesAsignadosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            planesAsignadosGridView.AllowUserToResizeColumns = true;
            planesAsignadosGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesAsignadosGridView.MultiSelect = false;
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                _obraSocialExistente = await ObraSocialApiClient.GetAsync(_obraSocialExistente.ObraSocialId);

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

            tableLayoutPanelBotones.SuspendLayout();

            tableLayoutPanelBotones.ColumnCount = 3;
            tableLayoutPanelBotones.RowCount = 1;

            tableLayoutPanelBotones.ColumnStyles.Clear();
            tableLayoutPanelBotones.RowStyles.Clear();

            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
  
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tableLayoutPanelBotones.SetColumn(btnCancelarObraSocial, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarObraSocial, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnCancelarPlan, 2);
            tableLayoutPanelBotones.SetRow(btnCancelarPlan, 0);

            btnCancelarObraSocial.Visible = true;
            btnRegistrarObraSocial.Visible = true;
            btnCancelarPlan.Visible = true;

            btnCancelarObraSocial.Anchor = AnchorStyles.None;
            btnRegistrarObraSocial.Anchor = AnchorStyles.None;
            btnCancelarPlan.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }
        private void ConfigurarVistaRegistro()
        {
            this.Text = "Registrar Nueva Obra Social";
            Titulo.Text = this.Text;
            btnRegistrarObraSocial.Text = "Registrar";
            planesAsignadosGridView.Visible = false;

            tableLayoutPanelBotones.SuspendLayout();

            tableLayoutPanelBotones.ColumnCount = 2;
            tableLayoutPanelBotones.RowCount = 1;

            tableLayoutPanelBotones.ColumnStyles.Clear();
            tableLayoutPanelBotones.RowStyles.Clear();

            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tableLayoutPanelBotones.SetColumn(btnCancelarObraSocial, 0);
            tableLayoutPanelBotones.SetRow(btnCancelarObraSocial, 0);

            tableLayoutPanelBotones.SetColumn(btnRegistrarObraSocial, 1);
            tableLayoutPanelBotones.SetRow(btnRegistrarObraSocial, 0);

            btnCancelarPlan.Visible = false;

            btnCancelarObraSocial.Anchor = AnchorStyles.None;
            btnRegistrarObraSocial.Anchor = AnchorStyles.None;

            tableLayoutPanelBotones.ResumeLayout();
        }


        private async void btnRegistrarObraSocial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombreObraSocial.Text) ||
               (!btnRadioHabilitado.Checked && !btnRadioDeshabilitado.Checked))
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
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    _obraSocialExistente.NombreObraSocial = textNombreObraSocial.Text;

                    _obraSocialExistente.Estado = btnRadioHabilitado.Checked ? EstadoObraSocialDTO.Habilitada : EstadoObraSocialDTO.Deshabilitada;

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
                PlanObraSocialDTO seleccionado = (PlanObraSocialDTO)planesAsignadosGridView.SelectedRows[0].DataBoundItem;
                int planId = seleccionado.PlanObraSocialId;

                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas cancelar este plan para la obra social '{_obraSocialExistente.NombreObraSocial}'?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes) return;

                await ObraSocialApiClient.RemovePlanAsync(_obraSocialExistente.ObraSocialId, planId);

                _obraSocialExistente.PlanesObraSocial.RemoveAll(p => p.PlanObraSocialId == planId);

                var obraSocialActualizada = await ObraSocialApiClient.GetAsync(_obraSocialExistente.ObraSocialId);

                _obraSocialExistente = obraSocialActualizada;

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
