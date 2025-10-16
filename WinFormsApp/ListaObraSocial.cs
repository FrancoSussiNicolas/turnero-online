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
    public partial class ListaObraSocial : Form
    {
        public ListaObraSocial()
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
                this.obraSocialGridView.DataSource = null;
                this.obraSocialGridView.DataSource = await ObraSocialApiClient.GetAllAsync();

                if (this.obraSocialGridView.Rows.Count > 0)
                {
                    this.obraSocialGridView.Rows[0].Selected = false;
                }

                ConfigurarColumnasEspecificas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de obras sociales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            obraSocialGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            obraSocialGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            obraSocialGridView.AllowUserToResizeColumns = true;
            obraSocialGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            obraSocialGridView.MultiSelect = false;

            ConfigurarColumnasEspecificas();
        }

        private void ConfigurarColumnasEspecificas()
        {
            if (obraSocialGridView.Columns.Count > 0)
            {
                // Configurar tamaño relativo de columnas (FillWeight)
                if (obraSocialGridView.Columns["ObraSocialId"] != null)
                {
                    obraSocialGridView.Columns["ObraSocialId"].Visible = false;
                }

                if (obraSocialGridView.Columns["NombreObraSocial"] != null)
                {
                    obraSocialGridView.Columns["NombreObraSocial"].FillWeight = 40;
                    obraSocialGridView.Columns["NombreObraSocial"].HeaderText = "Nombre Obra Social";
                }

                if (obraSocialGridView.Columns["Estado"] != null)
                {
                    obraSocialGridView.Columns["Estado"].FillWeight = 35;
                    obraSocialGridView.Columns["Estado"].HeaderText = "Estado";
                }

                // Ajustes generales
                obraSocialGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                obraSocialGridView.AllowUserToResizeColumns = true;
                obraSocialGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                obraSocialGridView.MultiSelect = false;
            }
        }

        private async void btnEliminarObraSocial_Click(object sender, EventArgs e)
        {
            if (obraSocialGridView.SelectedRows.Count > 0)
            {
                try
                {
                    ObraSocialDTO seleccionado = (ObraSocialDTO)obraSocialGridView.SelectedRows[0].DataBoundItem;

                    // Verificamos estado
                    if (seleccionado.Estado == EstadoObraSocialDTO.Deshabilitada)
                    {
                        MessageBox.Show("La obra social ya está deshabilitada, no puede volver a eliminarla.\nDebe modificarla en su lugar.",
                                        "Acción no permitida",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    int id = Convert.ToInt32(obraSocialGridView.SelectedRows[0].Cells["ObraSocialId"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas deshabilitar esta obra social?",
                                      "Confirmar deshabilitar",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await ObraSocialApiClient.ChangeStateAsync(id);

                        MessageBox.Show("La obra social fue deshabilitada exitosamente",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la obra social: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una obra social primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarObraSocial_Click(object sender, EventArgs e)
        {
            ObraSocialForm crearObraSocialForm = new ObraSocialForm();
            DialogResult result = crearObraSocialForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                await GetAllAndLoad();
            }

            crearObraSocialForm.Dispose();
        }


        private async void btnModificarObraSocial_Click_1(object sender, EventArgs e)
        {
            if (obraSocialGridView.SelectedRows.Count > 0)
            {
                try
                {
                    ObraSocialDTO seleccionado = (ObraSocialDTO)obraSocialGridView.SelectedRows[0].DataBoundItem;

                    ObraSocialForm editarForm = new ObraSocialForm(seleccionado);
                    DialogResult result = editarForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    editarForm.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la obra social: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una obra social primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregarPlanAobra_Click(object sender, EventArgs e)
        {
            if (obraSocialGridView.SelectedRows.Count > 0)
            {
                try
                {
                    ObraSocialDTO seleccionado = (ObraSocialDTO)obraSocialGridView.SelectedRows[0].DataBoundItem;

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
                    MessageBox.Show($"Error al modificar la obra social: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una obra social primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
