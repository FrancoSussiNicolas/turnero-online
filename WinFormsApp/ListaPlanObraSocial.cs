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
            await GetAllAndLoad();
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
                this.planObraSocialGridView.DataSource = await PlanApiClient.GetAllAsync();

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
                btnAgregarPlan.Visible = false;
                btnModificarPlan.Visible = false;

                btnEliminarPlan.Visible = false;
                btnAgregarPlanPractica.Visible = true;
            }
            else if (_practica != null)
            {
                btnVolver.Visible = true;
                btnAgregarPlanPractica.Visible = true;

                btnEliminarPlan.Visible = false;
                btnAgregarPlan.Visible = false;
                btnModificarPlan.Visible = false;
            }
            else
            {
                btnVolver.Visible = false;
                btnAgregarPlanPractica.Visible = false;

                btnEliminarPlan.Visible = true;
                btnAgregarPlan.Visible = true;
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
                    planObraSocialGridView.Columns["NombrePlan"].FillWeight = 40;
                    planObraSocialGridView.Columns["NombrePlan"].HeaderText = "Nombre del Plan";
                }

                if (planObraSocialGridView.Columns["DescripcionPlan"] != null)
                {
                    planObraSocialGridView.Columns["DescripcionPlan"].FillWeight = 35;
                    planObraSocialGridView.Columns["DescripcionPlan"].HeaderText = "Descripcion del Plan";
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
                var planSeleccionado = (PlanObraSocialDTO)planObraSocialGridView.SelectedRows[0].DataBoundItem;
                int planId = Convert.ToInt32(planObraSocialGridView.SelectedRows[0].Cells["PlanObraSocialId"].Value);

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
                    _practica.PlanObraSocial.Add(planSeleccionado);

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
                    _obrasSocial.PlanesObraSocial.Add(planSeleccionado);

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
                int id = Convert.ToInt32(planObraSocialGridView.SelectedRows[0].Cells["PlanObraSocialId"].Value);

                try
                {
                    PlanObraSocialDTO seleccionado = (PlanObraSocialDTO)planObraSocialGridView.SelectedRows[0].DataBoundItem;

                    bool estaHabilitado = seleccionado.Estado == EstadoPlanObraSocialDTO.Habilitado;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitado" : "habilitado";


                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} este plan?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await PlanApiClient.DisableAsync(id);
                        MessageBox.Show($"El plan fue {mensajeExito} exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    PlanObraSocialDTO seleccionado = (PlanObraSocialDTO)planObraSocialGridView.SelectedRows[0].DataBoundItem;

                    CrearPlanObraSocial editarForm = new CrearPlanObraSocial(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
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

        private async void btnEliminarPlan_Click_1(object sender, EventArgs e)
        {
            if (planObraSocialGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(planObraSocialGridView.SelectedRows[0].Cells["PlanObraSocialId"].Value);

                try
                {
                    PlanObraSocialDTO seleccionado = (PlanObraSocialDTO)planObraSocialGridView.SelectedRows[0].DataBoundItem;

                    bool estaHabilitado = seleccionado.Estado == EstadoPlanObraSocialDTO.Habilitado;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitado" : "habilitado";


                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} este plan?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await PlanApiClient.DisableAsync(id);
                        MessageBox.Show($"El plan fue {mensajeExito} exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
