using DTOs;
using API.Clients;

namespace WinFormsApp
{
    public partial class PacienteForm : Form
    {
        public PacienteForm()
        {
            InitializeComponent();
        }

        private async void PacienteForm_Load(object sender, EventArgs e)
        {
            await this.GetAllAndLoad();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await GetAllAndLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.PacientesDataGridView.DataSource = null;
                this.PacientesDataGridView.DataSource = await PacienteApiClient.GetAllAsync();

                if (this.PacientesDataGridView.Rows.Count > 0)
                {
                    this.PacientesDataGridView.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private PacienteDTO SelectedItem()
        {
            PacienteDTO cliente;

            cliente = (PacienteDTO)PacientesDataGridView.SelectedRows[0].DataBoundItem;

            return cliente;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            var pacienteDetalle = new PacienteDetalle();

            var newPaciente = new PacienteDTO();

            pacienteDetalle.Mode = FormMode.Add;
            pacienteDetalle.Paciente = newPaciente;

            pacienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pacienteDetalle = new PacienteDetalle();

                int id = this.SelectedItem().IdPersona;

                var pac = await PacienteApiClient.GetAsync(id);

                pacienteDetalle.Mode = FormMode.Update;
                pacienteDetalle.Paciente = pac;

                pacienteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar paciente para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().IdPersona;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el paciente con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PacienteApiClient.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
