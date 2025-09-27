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
    public partial class ListaPractica : Form
    {
        public ListaPractica()
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
                this.practicasGridView.DataSource = null;
                this.practicasGridView.DataSource = await PracticaApiClient.GetAllAsync();

                if (this.practicasGridView.Rows.Count > 0)
                {
                    this.practicasGridView.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de practicas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            practicasGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            practicasGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            practicasGridView.AllowUserToResizeColumns = true;
            practicasGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            practicasGridView.MultiSelect = false;
        }

        private async void btnEliminarPractica_Click(object sender, EventArgs e)
        {
            if (practicasGridView.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(practicasGridView.SelectedRows[0].Cells["PracticaId"].Value);

                try
                {
                    PracticaDTO seleccionado = (PracticaDTO)practicasGridView.SelectedRows[0].DataBoundItem;

                    bool estaHabilitado = seleccionado.Estado == EstadoPractica.Habilitada;

                    string accion = estaHabilitado ? "deshabilitar" : "habilitar";
                    string mensajeExito = estaHabilitado ? "deshabilitada" : "habilitada";


                    DialogResult result = MessageBox.Show($"¿Seguro que deseas {accion} esta práctica?",
                                      $"Confirmar {accion}",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await PracticaApiClient.DisableAsync(id);
                        MessageBox.Show($"La práctica fue {mensajeExito} exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la práctica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una práctica primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarPractica_Click(object sender, EventArgs e)
        {
            CrearPractica crearPracticaForm = new CrearPractica();
            DialogResult result = crearPracticaForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                await GetAllAndLoad();
            }

            crearPracticaForm.Dispose();
        }

        private async void btnModificarPractica_Click(object sender, EventArgs e)
        {
            if (practicasGridView.SelectedRows.Count > 0)
            {
                try
                {
                    PracticaDTO seleccionado = (PracticaDTO)practicasGridView.SelectedRows[0].DataBoundItem;

                    CrearPractica editarForm = new CrearPractica(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la práctica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una práctica primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarPlanPractica_Click(object sender, EventArgs e)
        {
            if (practicasGridView.SelectedRows.Count > 0)
            {
                try
                {
                    PracticaDTO seleccionado = (PracticaDTO)practicasGridView.SelectedRows[0].DataBoundItem;

                    ListaPlanObraSocial editarForm = new ListaPlanObraSocial(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la práctica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una práctica primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
