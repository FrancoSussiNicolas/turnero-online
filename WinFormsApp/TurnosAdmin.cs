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
            dvgTurnosAdmin.AutoGenerateColumns = true;

            dvgTurnosAdmin.DataBindingComplete += DvgTurnosAdmin_DataBindingComplete;
        }

        private void DvgTurnosAdmin_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dvgTurnosAdmin.Columns)
            {
                column.Visible = column.Name switch
                {
                    "TurnoId" => true,
                    "FechaTurno" => true,
                    "HoraTurno" => true,
                    "Estado" => true,
                    "ConsultorioId" => true,
                    "ProfesionalId" => true,
                    _ => false
                };
            }

            if (dvgTurnosAdmin.Columns["TurnoId"] != null)
                dvgTurnosAdmin.Columns["TurnoId"].HeaderText = "ID";

            if (dvgTurnosAdmin.Columns["FechaTurno"] != null)
                dvgTurnosAdmin.Columns["FechaTurno"].HeaderText = "Fecha";

            if (dvgTurnosAdmin.Columns["HoraTurno"] != null)
                dvgTurnosAdmin.Columns["HoraTurno"].HeaderText = "Hora";

            if (dvgTurnosAdmin.Columns["ConsultorioId"] != null)
                dvgTurnosAdmin.Columns["ConsultorioId"].HeaderText = "Consultorio";

            if (dvgTurnosAdmin.Columns["ProfesionalId"] != null)
                dvgTurnosAdmin.Columns["ProfesionalId"].HeaderText = "ID Profesional";
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