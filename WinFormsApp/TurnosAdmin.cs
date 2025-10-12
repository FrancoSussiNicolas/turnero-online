using API.Clients;

namespace WinFormsApp
{
    public partial class TurnosAdmin : Form
    {
        public TurnosAdmin()
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
                this.dvgTurnosAdmin.DataSource = null;
                this.dvgTurnosAdmin.DataSource = await TurnoApiClient.GetAllAsync();

                if (this.dvgTurnosAdmin.Rows.Count > 0)
                {
                    this.dvgTurnosAdmin.Rows[0].Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dvgTurnosAdmin.Dock = DockStyle.Fill;
            dvgTurnosAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTurnosAdmin.AllowUserToResizeColumns = true;
            dvgTurnosAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgTurnosAdmin.MultiSelect = false;
        }

        private async void ListaTurnos_Load(object sender, EventArgs e)
        {
            await GetAllAndLoad();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetAllAndLoad();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
