using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTOs;
using API.Clients;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class VerTurnosForm : Form
    {
        public VerTurnosForm()
        {
            InitializeComponent();
        }


        private TurnoDTO SelectedItem()
        {
            TurnoDTO turno;

            turno = (TurnoDTO)TurnosDataGridView.SelectedRows[0].DataBoundItem;

            return turno;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Lógica para el botón Aceptar.
            this.Close();
        }

        private async void VerTurnos_Load(object sender, EventArgs e)
        {

            try
            {
                this.TurnosDataGridView.DataSource = null;
                this.TurnosDataGridView.DataSource = await TurnoApiClient.GetAllAsync();

                if (this.TurnosDataGridView.Rows.Count > 0)
                {
                    this.TurnosDataGridView.Rows[0].Selected = true;
                    this.btnEliminarTurno.Enabled = true;
                }
                else
                {
                    this.btnEliminarTurno.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().TurnoId;

                var result = MessageBox.Show($"¿Está seguro que desea cancelar el turno {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await TurnoApiClient.DeleteAsync(id);
                    await this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.TurnosDataGridView.DataSource = null;
                this.TurnosDataGridView.DataSource = await TurnoApiClient.GetAllAsync();

                if (this.TurnosDataGridView.Rows.Count > 0)
                {
                    this.TurnosDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de profesionales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
