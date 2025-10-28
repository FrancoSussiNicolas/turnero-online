using API.Clients;
using DTOs;
using Shared;

namespace WinFormsApp
{
    public partial class ListaTurnos : Form
    {
        public ListaTurnos()
        {
            InitializeComponent();
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
                this.dvgTurnos.DataSource = null;
                this.dvgTurnos.DataSource = await TurnoApiClient.GetByProfesionalAsync((int)SessionManager.PersonaId);

                if (this.dvgTurnos.Rows.Count > 0)
                {
                    this.dvgTurnos.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de turnos del profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dvgTurnos.Dock = DockStyle.Fill;
            dvgTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTurnos.AllowUserToResizeColumns = true;
            dvgTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTurnos.MultiSelect = false;
            dvgTurnos.AutoGenerateColumns = true;

            dvgTurnos.DataBindingComplete += DvgTurnos_DataBindingComplete;
        }

        private void DvgTurnos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dvgTurnos.Columns)
            {
                column.Visible = column.Name switch
                {
                    "TurnoId" => true,
                    "FechaTurno" => true,
                    "HoraTurno" => true,
                    "Estado" => true,
                    "ConsultorioId" => true,
                    _ => false
                };
            }

            if (dvgTurnos.Columns["TurnoId"] != null)
                dvgTurnos.Columns["TurnoId"].HeaderText = "ID";

            if (dvgTurnos.Columns["FechaTurno"] != null)
                dvgTurnos.Columns["FechaTurno"].HeaderText = "Fecha";

            if (dvgTurnos.Columns["HoraTurno"] != null)
                dvgTurnos.Columns["HoraTurno"].HeaderText = "Hora";

            if (dvgTurnos.Columns["ConsultorioId"] != null)
                dvgTurnos.Columns["ConsultorioId"].HeaderText = "Consultorio";
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

                    int id = seleccionado.TurnoId;

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