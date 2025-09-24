using API.Clients;
using DTOs;
using Shared;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if(this.ValidateLoginRequest())
            {
                try
                {
                    var loginData = new LoginRequest(txtMail.Text, txtPass.Text);
                    var userToken = await AuthApiClient.LoginAsync(loginData);

                    SessionManager.SetSession(userToken.Token);

                    if (SessionManager.UserType == "Paciente")
                    {
                        MessageBox.Show("La aplicación es accesible únicamente para Profesionales y el Administrador", "Login", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Abort;
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateLoginRequest()
        {
            bool isValid = true;

            errorProvider.SetError(txtMail, string.Empty);
            errorProvider.SetError(txtPass, string.Empty);

            if (this.txtMail.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtMail, "El email es requerido");
            }
            if (this.txtPass.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtPass, "La contraseña es requerida");
            }
            else if (!EsEmailValido(this.txtMail.Text))
            {
                isValid = false;
                errorProvider.SetError(txtMail, "Ingrese un email válido");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria",
                "Olvidé mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // TODO ---> recuperación de contraseña
        }
    }
}
