using API.Clients;
using DTOs;
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
    public partial class ListaPacientes : Form
    {
        public ListaPacientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ConfigurarDataGridView();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await GetAllAndLoad();
        }
<<<<<<< HEAD
=======

>>>>>>> 1eba31f24a277b27a13716b1911e2dbef3212051
        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            pacientesGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            pacientesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            pacientesGridView.AllowUserToResizeColumns = true;
            pacientesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pacientesGridView.MultiSelect = false;

            ConfigurarColumnasEspecificas();
        }

        private void ConfigurarColumnasEspecificas()
        {
            if (pacientesGridView.Columns.Count > 0)
            {
                // Configurar tamaño relativo de columnas (FillWeight)
                if (pacientesGridView.Columns["PersonaId"] != null)
                {
                    pacientesGridView.Columns["PersonaId"].Visible = false;
                }

                if (pacientesGridView.Columns["ApellidoNombre"] != null)
                {
                    pacientesGridView.Columns["ApellidoNombre"].FillWeight = 40;
                    pacientesGridView.Columns["ApellidoNombre"].HeaderText = "Nombre Completo";
                }

                if (pacientesGridView.Columns["Mail"] != null)
                {
                    pacientesGridView.Columns["Mail"].FillWeight = 35;
                    pacientesGridView.Columns["Mail"].HeaderText = "Correo";
                }

                if (pacientesGridView.Columns["Contrasenia"] != null)
                {
                    pacientesGridView.Columns["Contrasenia"].Visible = false;
                }

                if (pacientesGridView.Columns["DNI"] != null)
                {
                    pacientesGridView.Columns["DNI"].FillWeight = 15;
                    pacientesGridView.Columns["DNI"].HeaderText = "DNI";
                }

                if (pacientesGridView.Columns["Sexo"] != null)
                {
                    pacientesGridView.Columns["Sexo"].FillWeight = 15;
                    pacientesGridView.Columns["Sexo"].HeaderText = "Sexo";
                }

                if (pacientesGridView.Columns["FechaNacimiento"] != null)
                {
                    pacientesGridView.Columns["FechaNacimiento"].FillWeight = 15;
                    pacientesGridView.Columns["FechaNacimiento"].HeaderText = "Fecha Nacimiento";
                }

                if (pacientesGridView.Columns["Telefono"] != null)
                {
                    pacientesGridView.Columns["Telefono"].FillWeight = 15;
                    pacientesGridView.Columns["Telefono"].HeaderText = "Telefono";
                }

                if (pacientesGridView.Columns["PlanObraSocialId"] != null) 
                { 
                    pacientesGridView.Columns["PlanObraSocialId"].Visible = false;
                }

                // Ajustes generales
                pacientesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                pacientesGridView.AllowUserToResizeColumns = true;
                pacientesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                pacientesGridView.MultiSelect = false;
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {

                this.pacientesGridView.DataSource = null;
                this.pacientesGridView.DataSource = await PacienteApiClient.GetAllAsync();

                if (pacientesGridView.Rows.Count > 0)
                {
                    pacientesGridView.Rows[0].Selected = false;
                }

                ConfigurarColumnasEspecificas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
