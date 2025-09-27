using API.Clients;
using DTOs;
using Entities;
using Shared;
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
    public partial class AgregarObraSocialProfesional : Form
    {
        public AgregarObraSocialProfesional()
        {
            InitializeComponent();
        }

        private void ConfigurarDataGridView()
        {
            dvgObrasSociales.Dock = DockStyle.Fill;

            dvgObrasSociales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgObrasSociales.AllowUserToResizeColumns = true;
            dvgObrasSociales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgObrasSociales.MultiSelect = false;
        }

        private async Task CargarObrasSociales()
        {
            try
            {
                var obrasSociales = await ObraSocialApiClient.GetDisponiblesAsync();
                dvgObrasSociales.DataSource = obrasSociales.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las Obras Sociales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private async void AgregarObraSocialProfesional_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            await CargarObrasSociales();
        }

        private void dvgObrasSociales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dvgObrasSociales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una Obra Social de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var obraSocialSeleccionada = dvgObrasSociales.SelectedRows[0].DataBoundItem as ObraSocialDTO;

                if (obraSocialSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la Obra Social seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idObraSocial = obraSocialSeleccionada.ObraSocialId;
                await ProfesionalApiClient.AgregarObraSocialAsync((int)SessionManager.PersonaId, idObraSocial);

                MessageBox.Show("Obra Social agregada al profesional correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar la Obra Social: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
