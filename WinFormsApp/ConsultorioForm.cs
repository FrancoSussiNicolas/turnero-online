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
    public partial class ConsultorioForm : Form
    {
        public ConsultorioForm()
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
                this.consultoriosGridView.DataSource = null;
                this.consultoriosGridView.DataSource = await ConsultorioApiClient.GetAllAsync();

                if (this.consultoriosGridView.Rows.Count > 0)
                {
                    this.consultoriosGridView.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de consultorios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            consultoriosGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            consultoriosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            consultoriosGridView.AllowUserToResizeColumns = true;
            consultoriosGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            consultoriosGridView.MultiSelect = false;

        }

        private async void btnEliminarConsultorio_Click(object sender, EventArgs e)
        {
            if (consultoriosGridView.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(consultoriosGridView.SelectedRows[0].Cells["ConsultorioId"].Value);

                try
                {
                    ConsultorioDTO seleccionado = (ConsultorioDTO)consultoriosGridView.SelectedRows[0].DataBoundItem;

                    bool estaHabilitado = seleccionado.Estado == EstadoConsultorioDTO.Habilitado;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitado" : "habilitado";

                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} este consultorio?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await ConsultorioApiClient.DisableAsync(id);

                        MessageBox.Show("El consultorio fue deshabilitado exitosamente",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el consultorio: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un consultorio primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarConsultorio_Click(object sender, EventArgs e)
        {
            CrearConsultorioForm crearConsultorioForm = new CrearConsultorioForm();
            DialogResult result = crearConsultorioForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                await GetAllAndLoad();
            }

            crearConsultorioForm.Dispose();
        }

        private async void btnModificarConsultorio_Click(object sender, EventArgs e)
        {
            if (consultoriosGridView.SelectedRows.Count > 0)
            {
                try
                {
                    ConsultorioDTO seleccionado = (ConsultorioDTO)consultoriosGridView.SelectedRows[0].DataBoundItem;

                    CrearConsultorioForm editarForm = new CrearConsultorioForm(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar consultorio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un consultorio primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
