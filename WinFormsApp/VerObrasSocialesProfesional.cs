using API.Clients;
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

    }
}
