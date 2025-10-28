using API.Clients;
using DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ListaPlanObraSocial : Form
    {
        private readonly PracticaDTO _practica;
        private readonly ObraSocialDTO _obrasSocial;
        private Dictionary<int, string> _obrasSocialesDictionary = new Dictionary<int, string>();

        public ListaPlanObraSocial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            planObraSocialGridView.CellFormatting += planObraSocialGridView_CellFormatting;
            ConfigurarDataGridView();
        }

        public ListaPlanObraSocial(PracticaDTO practica)
        {
            InitializeComponent();
            _practica = practica;
            this.WindowState = FormWindowState.Maximized;
            planObraSocialGridView.CellFormatting += planObraSocialGridView_CellFormatting;
            ConfigurarDataGridView();
        }

        public ListaPlanObraSocial(ObraSocialDTO obraSocial)
        {
            InitializeComponent();
            _obrasSocial = obraSocial;
            this.WindowState = FormWindowState.Maximized;
            planObraSocialGridView.CellFormatting += planObraSocialGridView_CellFormatting;
            ConfigurarDataGridView();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await CargarObrasSociales();
            await GetAllAndLoad();
        }

        private async Task CargarObrasSociales()
        {
            try
            {
                var obrasSociales = await ObraSocialApiClient.GetAllAsync();
                _obrasSocialesDictionary = obrasSociales.ToDictionary(o => o.ObraSocialId, o => o.NombreObraSocial);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar obras sociales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void planObraSocialGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (planObraSocialGridView.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null && e.Value.ToString() == EstadoPlanObraSocialDTO.Deshabilitado.ToString())
                {
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.planObraSocialGridView.DataSource = null;
                var planes = await PlanApiClient.GetAllAsync();

                var planesConObraSocial = planes.Select(p => new
                {
                    p.PlanObraSocialId,
                    p.NombrePlan,
                    p.DescripcionPlan,
                    ObraSocial = _obrasSocialesDictionary.ContainsKey(p.ObraSocialId)
                        ? _obrasSocialesDictionary[p.ObraSocialId]
                        : string.Empty,
                    p.ObraSocialId,
                    p.Estado
                }).ToList();

                this.planObraSocialGridView.DataSource = planesConObraSocial;

                if (this.planObraSocialGridView.Rows.Count > 0)
                {
                    this.planObraSocialGridView.Rows[0].Selected = false;
                }

                ConfigurarColumnasEspecificas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            planObraSocialGridView.Dock = DockStyle.Fill;
            planObraSocialGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            planObraSocialGridView.AllowUserToResizeColumns = true;
            planObraSocialGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planObraSocialGridView.MultiSelect = false;

            ConfigurarColumnasEspecificas();
        }

        private void ConfigurarColumnasEspecificas()
        {
            if (_obrasSocial != null)
            {
                btnVolver.Visible = true;
                btnModificarPlan.Visible = false;
                btnEliminarPlan.Visible = false;
                btnAgregarPlanPractica.Visible = true;
            }
            else if (_practica != null)
            {
                btnVolver.Visible = true;
                btnAgregarPlanPractica.Visible = true;
                btnEliminarPlan.Visible = false;
                btnModificarPlan.Visible = false;
            }
            else
            {
                btnVolver.Visible = false;
                btnAgregarPlanPractica.Visible = false;
                btnEliminarPlan.Visible = true;
                btnModificarPlan.Visible = true;
            }

            if (planObraSocialGridView.Columns.Count > 0)
            {
                if (planObraSocialGridView.Columns["PlanObraSocialId"] != null)
                {
                    planObraSocialGridView.Columns["PlanObraSocialId"].Visible = false;
                }

                if (planObraSocialGridView.Columns["NombrePlan"] != null)
                {
                    planObraSocialGridView.Columns["NombrePlan"].FillWeight = 25;
                    planObraSocialGridView.Columns["NombrePlan"].HeaderText = "Nombre del Plan";
                }

                if (planObraSocialGridView.Columns["DescripcionPlan"] != null)
                {
                    planObraSocialGridView.Columns["DescripcionPlan"].FillWeight = 30;
                    planObraSocialGridView.Columns["DescripcionPlan"].HeaderText = "Descripción del Plan";
                }

                if (planObraSocialGridView.Columns["ObraSocial"] != null)
                {
                    planObraSocialGridView.Columns["ObraSocial"].FillWeight = 25;
                    planObraSocialGridView.Columns["ObraSocial"].HeaderText = "Obra Social";
                }

                if (planObraSocialGridView.Columns["ObraSocialId"] != null)
                {
                    planObraSocialGridView.Columns["ObraSocialId"].Visible = false;
                }

                if (planObraSocialGridView.Columns["Estado"] != null)
                {
                    planObraSocialGridView.Columns["Estado"].FillWeight = 20;
                    planObraSocialGridView.Columns["Estado"].HeaderText = "Estado";
                }

                planObraSocialGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                planObraSocialGridView.AllowUserToResizeColumns = true;
                planObraSocialGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                planObraSocialGridView.MultiSelect = false;
            }
        }

        private async void btnAgregarPlanPractica_Click(object sender, EventArgs e)
        {
            if (planObraSocialGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un plan de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var planSeleccionado = (dynamic)planObraSocialGridView.SelectedRows[0].DataBoundItem;
                int planId = planSeleccionado.PlanObraSocialId;

                bool esDePractica = _practica is not null;
                bool esDeObraSocial = _obrasSocial is not null;

                if (esDePractica)
                {
                    bool yaExiste = _practica.PlanObraSocial.Any(p => p.PlanObraSocialId == planId);
                    if (yaExiste)
                    {
                        MessageBox.Show($"El plan '{planSeleccionado.NombrePlan}' ya está asignado a la práctica '{_practica.Nombre}'.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    await PracticaApiClient.AddPlanAsync(_practica.PracticaId, planId);
                    _practica.PlanObraSocial.Add(new PlanObraSocialDTO
                    {
                        PlanObraSocialId = planSeleccionado.PlanObraSocialId,
                        NombrePlan = planSeleccionado.NombrePlan,
                        DescripcionPlan = planSeleccionado.DescripcionPlan,
                        ObraSocialId = planSeleccionado.ObraSocialId,
                        Estado = planSeleccionado.Estado
                    });

                    MessageBox.Show($"El plan '{planSeleccionado.NombrePlan}' fue agregado correctamente a la práctica '{_practica.Nombre}'.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (esDeObraSocial)
                {
                    bool yaExiste = _obrasSocial.PlanesObraSocial.Any(p => p.PlanObraSocialId == planId);
                    if (yaExiste)
                    {
                        MessageBox.Show($"El plan '{planSeleccionado.NombrePlan}' ya está asignado a la obra social '{_obrasSocial.NombreObraSocial}'.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    await ObraSocialApiClient.AddPlanAsync(_obrasSocial.ObraSocialId, planId);
                    _obrasSocial.PlanesObraSocial.Add(new PlanObraSocialDTO
                    {
                        PlanObraSocialId = planSeleccionado.PlanObraSocialId,
                        NombrePlan = planSeleccionado.NombrePlan,
                        DescripcionPlan = planSeleccionado.DescripcionPlan,
                        ObraSocialId = planSeleccionado.ObraSocialId,
                        Estado = planSeleccionado.Estado
                    });

                    MessageBox.Show($"El plan '{planSeleccionado.NombrePlan}' fue agregado correctamente a la obra social '{_obrasSocial.NombreObraSocial}'.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                await GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            if (planObraSocialGridView.SelectedRows.Count > 0)
            {
                int id = (int)planObraSocialGridView.SelectedRows[0].Cells["PlanObraSocialId"].Value;

                try
                {
                    var planSeleccionado = (dynamic)planObraSocialGridView.SelectedRows[0].DataBoundItem;
                    EstadoPlanObraSocialDTO estado = planSeleccionado.Estado;

                    bool estaHabilitado = estado == EstadoPlanObraSocialDTO.Habilitado;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitado" : "habilitado";

                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} este plan?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await PlanApiClient.DisableAsync(id);
                        MessageBox.Show($"El plan fue {mensajeExito} exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el plan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un plan primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            CrearPlanObraSocial crearPlan = new CrearPlanObraSocial();
            DialogResult result = crearPlan.ShowDialog();

            if (result == DialogResult.OK)
            {
                await CargarObrasSociales();
                await GetAllAndLoad();
            }

            crearPlan.Dispose();
        }

        private async void btnModificarPlan_Click(object sender, EventArgs e)
        {
            if (planObraSocialGridView.SelectedRows.Count > 0)
            {
                try
                {
                    var planDinamico = (dynamic)planObraSocialGridView.SelectedRows[0].DataBoundItem;

                    var planObraSocialDTO = new PlanObraSocialDTO
                    {
                        PlanObraSocialId = planDinamico.PlanObraSocialId,
                        NombrePlan = planDinamico.NombrePlan,
                        DescripcionPlan = planDinamico.DescripcionPlan,
                        ObraSocialId = planDinamico.ObraSocialId,
                        Estado = planDinamico.Estado
                    };

                    CrearPlanObraSocial editarForm = new CrearPlanObraSocial(planObraSocialDTO);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await CargarObrasSociales();
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar plan de obra social: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un plan de obra social primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}