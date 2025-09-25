using API.Clients;
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
    public partial class ModificarEspecialidad : Form
    {
        private int profesionalId;

        public ModificarEspecialidad(int idProfesional)
        {
            InitializeComponent();
            this.profesionalId = idProfesional;
        }


        private async void ModificarEspecialidad_Load(object sender, EventArgs e)
        {
            await CargarEspecialidades();
        }
        private async Task CargarEspecialidades()
        {
            try
            {
                var especialidades = await EspecialidadApiClient.GetAllAsync();
                dgvEspecialidades.DataSource = especialidades.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                int especialidadId = Convert.ToInt32(dgvEspecialidades.SelectedRows[0].Cells[0].Value);

                try
                {
                    await ProfesionalApiClient.CambiarEspecialidadProfesional(profesionalId, especialidadId);
                    MessageBox.Show("Especialidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar actualizar la especialidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una especialidad para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarForm = new ModificarEspecialidad(profesionalId);
            modificarForm.MdiParent = this;
            modificarForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
