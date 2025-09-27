using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class PerfilAdmin : Form
    {
        private AdminDTO admin;

        public PerfilAdmin()
        {
            InitializeComponent();
        }

        private async void PerfilAdmin_Shown(object sender, EventArgs e)
        {
            try
            {
                admin = await AdminApiClient.GetAsync();
                if (admin is not null)
                {
                    txtApellidoNombre.Text = admin.ApellidoNombre;
                    txtMail.Text = admin.Mail;
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos del Administrador", "Perfil",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error al cargar los datos del Administrador, inténtelo de nuevo más tarde", "Perfil",
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
                    var adminData = new AdminDTO(
                        txtApellidoNombre.Text,
                        txtMail.Text,
                        admin.Contrasenia
                    );

                    if (admin.ApellidoNombre != adminData.ApellidoNombre || admin.Mail != adminData.Mail)
                    {
                        await AdminApiClient.UpdateAsync(adminData);
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
