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
    public partial class VerObrasSocialesProfesional : Form
    {
        public VerObrasSocialesProfesional()
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
                var obrasSociales = await ProfesionalApiClient.GetObrasSocialesAsync((int)SessionManager.PersonaId);
                dvgObrasSociales.DataSource = obrasSociales.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las Obras Sociales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private async void VerObrasSocialesProfesional_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            await CargarObrasSociales();
        }

        private async Task EliminarObraSocialSeleccionada()
        {
            if (dvgObrasSociales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una Obra Social para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "¿Está seguro que desea eliminar esta Obra Social de su lista? Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                var selectedRow = dvgObrasSociales.SelectedRows[0];
                var obraSocial = selectedRow.DataBoundItem as ObraSocialDTO;

                if (obraSocial == null)
                {
                    MessageBox.Show("No se pudo obtener la información de la Obra Social seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await ProfesionalApiClient.EliminarObraSocialAsync((int)SessionManager.PersonaId, obraSocial.ObraSocialId);
                MessageBox.Show("Obra Social eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarObrasSociales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar la Obra Social: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await EliminarObraSocialSeleccionada();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void VerObrasSocialesProfesional_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var frmAgregarObraSocial = new AgregarObraSocialProfesional())
            {
                if (frmAgregarObraSocial.ShowDialog() == DialogResult.OK)
                {
                    await CargarObrasSociales();
                    MessageBox.Show("¡Nueva Obra Social agregada al listado!", "Actualización completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
