using API.Clients;
using DTOs;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class PerfilProfesional : Form
    {
        private ProfesionalDTO profesional;

        public PerfilProfesional()
        {
            InitializeComponent();
        }

        private async void PerfilProfesional_Shown(object sender, EventArgs e)
        {
            try
            {
                profesional = await ProfesionalApiClient.GetAsync((int)SessionManager.PersonaId);
                if (profesional is not null)
                {
                    var especialidad = await EspecialidadApiClient.GetAsync(profesional.EspecialidadId);
                    txtApellidoNombre.Text = profesional.ApellidoNombre;
                    txtMail.Text = profesional.Mail;
                    txtMatricula.Text = profesional.Matricula;
                    txtEspecialidad.Text = especialidad?.Descripcion ?? "ERROR";
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos del Profesional", "Perfil",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al cargar los datos del Profesional, inténtelo de nuevo más tarde", "Perfil",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.ValidatePerfilFields())
            {
                try
                {
                    var profData = new ProfesionalDTO { 
                        ApellidoNombre =txtApellidoNombre.Text,
                        Mail = txtMail.Text,
                        Contrasenia = profesional.Contrasenia,
                        Matricula =txtMatricula.Text,
                        EspecialidadId = profesional.EspecialidadId
                    };
                    profData.PersonaId = (int)SessionManager.PersonaId;

                    if (profesional.ApellidoNombre != profData.ApellidoNombre || profesional.Mail != profData.Mail || profesional.Matricula != profData.Matricula)
                    {
                        await ProfesionalApiClient.UpdateAsync(profData);
                        MessageBox.Show("Perfil actualizado con éxito", "Perfil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Modifique algún campo para actualizar su perfil", "Perfil",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Error al actualizar el perfil, inténtelo de nuevo más tarde", "Perfil",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidatePerfilFields()
        {
            bool isValid = true;

            errorProvider.SetError(txtApellidoNombre, string.Empty);
            errorProvider.SetError(txtMail, string.Empty);
            errorProvider.SetError(txtMatricula, string.Empty);

            if (this.txtMail.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtMail, "El email es requerido");
            }
            else if (!EsEmailValido(this.txtMail.Text))
            {
                isValid = false;
                errorProvider.SetError(txtMail, "Ingrese un email válido");
            }
            if (this.txtApellidoNombre.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtApellidoNombre, "El apellido y nombre es requerido");
            }
            if (this.txtMatricula.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtApellidoNombre, "La matrícula es requerida");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
