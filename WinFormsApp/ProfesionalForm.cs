using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DTOs;
using API.Clients;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ProfesionalForm : Form
    {
        private Dictionary<int, string> _especialidadesDictionary = new Dictionary<int, string>();

        public ProfesionalForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ConfigurarDataGridView();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await CargarEspecialidades();
            await GetAllAndLoad();
        }

        private async Task CargarEspecialidades()
        {
            try
            {
                var especialidades = await EspecialidadApiClient.GetAllAsync();
                _especialidadesDictionary = especialidades.ToDictionary(e => e.EspecialidadId, e => e.Descripcion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            ProfesionalesDataGridView.Dock = DockStyle.Fill;

            ProfesionalesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ProfesionalesDataGridView.AllowUserToResizeColumns = true;
            ProfesionalesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfesionalesDataGridView.MultiSelect = false;

            ConfigurarColumnasEspecificas();
        }

        private void ConfigurarColumnasEspecificas()
        {
            if (ProfesionalesDataGridView.Columns.Count > 0)
            {
                if (ProfesionalesDataGridView.Columns["PersonaId"] != null)
                {
                    ProfesionalesDataGridView.Columns["PersonaId"].FillWeight = 8;
                    ProfesionalesDataGridView.Columns["PersonaId"].HeaderText = "ID";
                }

                if (ProfesionalesDataGridView.Columns["ApellidoNombre"] != null)
                {
                    ProfesionalesDataGridView.Columns["ApellidoNombre"].FillWeight = 25;
                    ProfesionalesDataGridView.Columns["ApellidoNombre"].HeaderText = "Nombre Completo";
                }

                if (ProfesionalesDataGridView.Columns["Mail"] != null)
                {
                    ProfesionalesDataGridView.Columns["Mail"].FillWeight = 25;
                    ProfesionalesDataGridView.Columns["Mail"].HeaderText = "Correo";
                }

                if (ProfesionalesDataGridView.Columns["Contrasenia"] != null)
                {
                    ProfesionalesDataGridView.Columns["Contrasenia"].Visible = false;
                }

                if (ProfesionalesDataGridView.Columns["Matricula"] != null)
                {
                    ProfesionalesDataGridView.Columns["Matricula"].FillWeight = 12;
                    ProfesionalesDataGridView.Columns["Matricula"].HeaderText = "Matrícula";
                    ProfesionalesDataGridView.Columns["Matricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (ProfesionalesDataGridView.Columns["EspecialidadId"] != null)
                {
                    ProfesionalesDataGridView.Columns["EspecialidadId"].Visible = false;
                }

                if (ProfesionalesDataGridView.Columns["Especialidad"] != null)
                {
                    ProfesionalesDataGridView.Columns["Especialidad"].FillWeight = 18;
                    ProfesionalesDataGridView.Columns["Especialidad"].HeaderText = "Especialidad";
                }

                if (ProfesionalesDataGridView.Columns["Estado"] != null)
                {
                    ProfesionalesDataGridView.Columns["Estado"].FillWeight = 12;
                    ProfesionalesDataGridView.Columns["Estado"].HeaderText = "Estado";
                }

                if (ProfesionalesDataGridView.Columns["AtiendePorObraSocial"] != null)
                {
                    ProfesionalesDataGridView.Columns["AtiendePorObraSocial"].Visible = false;
                }

                ProfesionalesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ProfesionalesDataGridView.AllowUserToResizeColumns = true;
                ProfesionalesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ProfesionalesDataGridView.MultiSelect = false;
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.ProfesionalesDataGridView.DataSource = null;
                var profesionales = await ProfesionalApiClient.GetAllAsync();

                var profesionalesConEspecialidad = profesionales.Select(p => new
                {
                    p.PersonaId,
                    p.ApellidoNombre,
                    p.Mail,
                    p.Contrasenia,
                    p.Matricula,
                    p.EspecialidadId,
                    Especialidad = _especialidadesDictionary.ContainsKey(p.EspecialidadId)
                        ? _especialidadesDictionary[p.EspecialidadId]
                        : "No asignada",
                    p.Estado,
                    p.AtiendePorObraSocial
                }).ToList();

                this.ProfesionalesDataGridView.DataSource = profesionalesConEspecialidad;

                if (ProfesionalesDataGridView.Rows.Count > 0)
                {
                    ProfesionalesDataGridView.Rows[0].Selected = false;
                }

                ConfigurarColumnasEspecificas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de profesionales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            if (ProfesionalesDataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(ProfesionalesDataGridView.SelectedRows[0].Cells["PersonaId"].Value);

                try
                {
                    var profesionalSeleccionado = (dynamic)ProfesionalesDataGridView.SelectedRows[0].DataBoundItem;
                    string nombreProfesional = profesionalSeleccionado.ApellidoNombre;

                    DialogResult result = MessageBox.Show($"¿Seguro que deseas cambiar el estado del profesional {nombreProfesional}?",
                                      "Confirmar cambio de estado",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await ProfesionalApiClient.DisableAsync(id);
                        MessageBox.Show("El estado del profesional fue actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar estado del profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un profesional primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            CrearProfesional crearProfesional = new CrearProfesional();
            DialogResult result = crearProfesional.ShowDialog();

            if (result == DialogResult.OK)
            {
                await CargarEspecialidades();
                await GetAllAndLoad();
            }

            crearProfesional.Dispose();
        }
    }
}