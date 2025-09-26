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
            this.WindowState = FormWindowState.Maximized;
            ConfigurarDataGridView();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await GetAllAndLoad();
        }


        private void ConfigurarDataGridView()
        {
            // La tabla ocupa todo el ancho del formulario
            ProfesionalesDataGridView.Dock = DockStyle.Fill;

            // Las columnas se distribuyen proporcionalmente
            ProfesionalesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configuraciones adicionales
            ProfesionalesDataGridView.AllowUserToResizeColumns = true;
            ProfesionalesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfesionalesDataGridView.MultiSelect = false;

            ConfigurarColumnasEspecificas();
        }
        private void ConfigurarColumnasEspecificas()
        {
            if (ProfesionalesDataGridView.Columns.Count > 0)
            {
                // Configurar tamaño relativo de columnas (FillWeight)
                if (ProfesionalesDataGridView.Columns["PersonaId"] != null)
                {
                    ProfesionalesDataGridView.Columns["PersonaId"].FillWeight = 10;
                    ProfesionalesDataGridView.Columns["PersonaId"].HeaderText = "ID";
                }

                if (ProfesionalesDataGridView.Columns["ApellidoNombre"] != null)
                {
                    ProfesionalesDataGridView.Columns["ApellidoNombre"].FillWeight = 40;
                    ProfesionalesDataGridView.Columns["ApellidoNombre"].HeaderText = "Nombre Completo";
                }

                if (ProfesionalesDataGridView.Columns["Mail"] != null)
                {
                    ProfesionalesDataGridView.Columns["Mail"].FillWeight = 35;
                    ProfesionalesDataGridView.Columns["Mail"].HeaderText = "Correo";
                }
                if (ProfesionalesDataGridView.Columns["Contrasenia"] != null)
                {
                    ProfesionalesDataGridView.Columns["Contrasenia"].Visible = false; 
                }

                if (ProfesionalesDataGridView.Columns["Matricula"] != null)
                {
                    ProfesionalesDataGridView.Columns["Matricula"].FillWeight = 15;
                    ProfesionalesDataGridView.Columns["Matricula"].HeaderText = "Matrícula";
                    ProfesionalesDataGridView.Columns["Matricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (ProfesionalesDataGridView.Columns["EspecialidadId"] != null)
                {
                    ProfesionalesDataGridView.Columns["EspecialidadId"].FillWeight = 15;
                    ProfesionalesDataGridView.Columns["EspecialidadId"].HeaderText = "EspecialidadId";
                }

                if (ProfesionalesDataGridView.Columns["Estado"] != null)
                {
                    ProfesionalesDataGridView.Columns["Estado"].FillWeight = 15;
                    ProfesionalesDataGridView.Columns["Estado"].HeaderText = "Estado";
                }

                // Ajustes generales
                ProfesionalesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ProfesionalesDataGridView.AllowUserToResizeColumns = true;
                ProfesionalesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ProfesionalesDataGridView.MultiSelect = false;
            }
        }

        private async Task GetAllAndLoad()
        {
            try
            {

                this.ProfesionalesDataGridView.DataSource = null;
                this.ProfesionalesDataGridView.DataSource = await ProfesionalApiClient.GetAllAsync();

                if (ProfesionalesDataGridView.Rows.Count > 0)
                {
                    ProfesionalesDataGridView.Rows[0].Selected = false;
                }

                ConfigurarColumnasEspecificas();
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

        private async void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            if (ProfesionalesDataGridView.SelectedRows.Count > 0) {

                int id = Convert.ToInt32(ProfesionalesDataGridView.SelectedRows[0].Cells["PersonaId"].Value);

                try
                {
                    DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este profesional?",
                                      "Confirmar eliminación",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) { 
                        await ProfesionalApiClient.DisableAsync(id);
                        MessageBox.Show("El profesional fue eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetAllAndLoad();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error al eliminar profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }
        }
    }
}