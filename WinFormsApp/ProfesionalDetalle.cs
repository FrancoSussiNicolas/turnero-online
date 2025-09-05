using API.Clients;
using DTOs;
using Entities;
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
    public partial class ProfesionalDetalle : Form
    {
        private ProfesionalDTO profesional;
        private FormMode mode;

        public ProfesionalDTO Profesional
        {
            get { return profesional; }
            set
            {
                profesional = value;
                this.SetProfesional();
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }

        public ProfesionalDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateProfesional())
            {
                try
                {
                    this.Profesional.Mail = emailTextBox.Text;
                    this.Profesional.ApellidoNombre = nombreTextBox.Text;
                    this.Profesional.Contrasenia = contraseniaTextBox.Text;
                    this.Profesional.Matricula = matriculaTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        this.Profesional.PersonaId = int.Parse(idTextBox.Text);
                        await ProfesionalApiClient.UpdateAsync(this.Profesional);
                    }
                    else
                    {
                        await ProfesionalApiClient.AddAsync(this.Profesional);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new Exception();
            }
        }

        private void cancelarButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetProfesional()
        {
            this.idTextBox.Text = this.Profesional.PersonaId.ToString();
            this.nombreTextBox.Text = this.Profesional.ApellidoNombre;
            this.emailTextBox.Text = this.Profesional.Mail;
            this.contraseniaTextBox.Text = this.Profesional.Contrasenia;
            this.matriculaTextBox.Text = this.Profesional.Matricula;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;
            }
        }

        private bool ValidateProfesional()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);
            errorProvider.SetError(matriculaTextBox, string.Empty);


            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre y Apellido es Requerido");
            }

            if (this.contraseniaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(contraseniaTextBox, "La contraseña es Requerida");
            }

            if (this.matriculaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(matriculaTextBox, "La matricula es Requerida");
            }

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void ProfesionalDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
