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
        public ProfesionalForm()
        {
            InitializeComponent();
        }

        private async void ProfesionalForm_Load(object sender, EventArgs e)
        {
            await this.GetAllAndLoad();
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
                this.ProfesionalesDataGridView.DataSource = null;
                this.ProfesionalesDataGridView.DataSource = await ProfesionalApiClient.GetAllAsync();

                if (this.ProfesionalesDataGridView.Rows.Count > 0)
                {
                    this.ProfesionalesDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de profesionales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private ProfesionalDTO SelectedItem()
        {
            ProfesionalDTO profesional;

            profesional = (ProfesionalDTO)ProfesionalesDataGridView.SelectedRows[0].DataBoundItem;

            return profesional;
        }


        private async void agregarButton_Click(object sender, EventArgs e)
        {
            var profesionalDetalle = new ProfesionalDetalle();

            var newProf = new ProfesionalDTO();

            profesionalDetalle.Mode = FormMode.Add;
            profesionalDetalle.Profesional = newProf;

            profesionalDetalle.ShowDialog();

            await this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var profesionalDetalle = new ProfesionalDetalle();

                int id = this.SelectedItem().PersonaId;

                var prof = await ProfesionalApiClient.GetAsync(id);

                profesionalDetalle.Mode = FormMode.Update;
                profesionalDetalle.Profesional = prof;

                profesionalDetalle.ShowDialog();

                await this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar profesional para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().PersonaId;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el profesional con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ProfesionalApiClient.DeleteAsync(id);
                    await this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
