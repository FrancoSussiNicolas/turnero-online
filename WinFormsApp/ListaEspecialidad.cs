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
    public partial class ListaEspecialidad : Form
    {
        public ListaEspecialidad()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ConfigurarDataGridView();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await GetAllAndLoad();
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.especialidadGridView.DataSource = null;
                this.especialidadGridView.DataSource = await EspecialidadApiClient.GetAllAsync();

                if (this.especialidadGridView.Rows.Count > 0)
                {
                    this.especialidadGridView.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            especialidadGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            especialidadGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            especialidadGridView.AllowUserToResizeColumns = true;
            especialidadGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadGridView.MultiSelect = false;

        }

        private async void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            if (especialidadGridView.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(especialidadGridView.SelectedRows[0].Cells["EspecialidadId"].Value);

                try
                {
                    EspecialidadDTO seleccionado = (EspecialidadDTO)especialidadGridView.SelectedRows[0].DataBoundItem;

                    // Verificamos estado
                    if (seleccionado.Estado == EstadoEspecialidad.Deshabilitada)
                    {
                        MessageBox.Show("La especialidad ya está deshabilitada, no puede volver a eliminarla.\nDebe modificarla en su lugar.",
                                        "Acción no permitida",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    int id = Convert.ToInt32(especialidadGridView.SelectedRows[0].Cells["EspecialidadId"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas deshabilitar esta especialidad?",
                    "Confirmar deshabilitar",)
                    bool estaHabilitado = seleccionado.Estado == EstadoEspecialidad.Habilitada;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitada" : "habilitada";

                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} esta especialidad?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await EspecialidadApiClient.DisableAsync(id);

                        MessageBox.Show("La especialidad fue deshabilitada exitosamente",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la especialidad: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una especialidad primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            CrearEspecialidad crearEspecialidadForm = new CrearEspecialidad();
            DialogResult result = crearEspecialidadForm.ShowDialog();

            if (result == DialogResult.OK) await GetAllAndLoad();

            crearEspecialidadForm.Dispose();
        }
        
        private async void btnModificarEspecialidad_Click(object sender, EventArgs e)
        {
            if (especialidadGridView.SelectedRows.Count > 0)
            {
                try
                {
                    EspecialidadDTO seleccionado = (EspecialidadDTO)especialidadGridView.SelectedRows[0].DataBoundItem;

                    CrearEspecialidad editarForm = new CrearEspecialidad(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar especialidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una especialidad primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
