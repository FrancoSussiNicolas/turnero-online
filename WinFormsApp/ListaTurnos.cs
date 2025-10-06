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
    public partial class ListaTurnos : Form
    {
        public ListaTurnos()
        {
            InitializeComponent();
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
                this.dvgTurnos.DataSource = null;
                this.dvgTurnos.DataSource = await TurnoApiClient.GetAllAsync();

                if (this.dvgTurnos.Rows.Count > 0)
                {
                    this.dvgTurnos.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de obras sociales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ListaTurnos_Load(object sender, EventArgs e)
        {
            await GetAllAndLoad();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetAllAndLoad();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgTurnos.SelectedRows.Count > 0)
            {
                try
                {
                    TurnoDTO seleccionado = (TurnoDTO)dvgTurnos.SelectedRows[0].DataBoundItem;

                    int id = Convert.ToInt32(dvgTurnos.SelectedRows[0].Cells["TurnoId"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar definitivamente este turno?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        await TurnoApiClient.DeleteAsync(id);

                        MessageBox.Show("El turno fue eliminado exitosamente",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el turno: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un turno primero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgTurnos.SelectedRows.Count > 0)
            {
                try
                {
                    TurnoDTO seleccionado = (TurnoDTO)dvgTurnos.SelectedRows[0].DataBoundItem;

                    var turnoDetalle = new TurnoDetalle(seleccionado);
                    DialogResult result = turnoDetalle.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        await GetAllAndLoad();
                    }

                    turnoDetalle.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un turno primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var turnoDetalle = new TurnoDetalle();
            DialogResult result = turnoDetalle.ShowDialog();

            if (result == DialogResult.OK)
            {
                await GetAllAndLoad();
            }

            turnoDetalle.Dispose();
        }
    }
}
