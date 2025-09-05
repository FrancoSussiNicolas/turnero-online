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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de profesionales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
