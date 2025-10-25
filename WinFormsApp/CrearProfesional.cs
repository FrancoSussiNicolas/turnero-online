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
    public partial class CrearProfesional : Form
    {
        public CrearProfesional()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                var especialidades = await EspecialidadApiClient.GetAllAsync();
                comboEspecialidad.DataSource = especialidades;
                comboEspecialidad.DisplayMember = "Descripcion";
                comboEspecialidad.ValueMember = "EspecialidadId";
                comboEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRegistrarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (!string.IsNullOrWhiteSpace(textNombreCompleto.Text) &&
                    !string.IsNullOrWhiteSpace(textContrasenia.Text) &&
                    !string.IsNullOrWhiteSpace(textEmail.Text) &&
                    !string.IsNullOrWhiteSpace(textMatricula.Text) &&
                    comboEspecialidad.SelectedValue != null)
                {
                    int idEspecialidad = (int)comboEspecialidad.SelectedValue;

                    // Crear objeto profesional
                    var nuevoProfesional = new ProfesionalDTO {
                        ApellidoNombre =textNombreCompleto.Text,
                        Mail = textEmail.Text,
                        Contrasenia = textContrasenia.Text,
                        Matricula = textMatricula.Text,
                        EspecialidadId = idEspecialidad
                    };

                    await ProfesionalApiClient.AddAsync(nuevoProfesional);


                    MessageBox.Show("Profesional registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar formulario con resultado OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Completar todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar profesional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
