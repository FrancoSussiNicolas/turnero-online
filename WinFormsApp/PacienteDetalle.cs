using DTOs;
using API.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class PacienteDetalle : Form
    {
        private PacienteDTO paciente;
        private FormMode mode;

        public PacienteDTO Paciente
        {
            get { return paciente; }
            set
            {
                paciente = value;
                this.SetPaciente();
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


        public PacienteDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private void PacienteDetalle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidatePaciente())
            {
                try
                {
                    this.Paciente.Mail = emailTextBox.Text;
                    this.Paciente.ApellidoNombre = nombreTextBox.Text;
                    this.Paciente.Contrasenia = contraseniaTextBox.Text;
                    this.Paciente.DNI = dniTextBox.Text;
                    this.Paciente.Sexo = sexoTextBox.Text;
                    this.Paciente.Telefono = telefonoTextBox.Text;
                    this.Paciente.FechaNacimiento = DateOnly.Parse(fechaNacTextBox.Text);

                    if (this.Mode == FormMode.Update)
                    {
                        await PacienteApiClient.UpdateAsync(this.Paciente);
                    }
                    else
                    {
                        await PacienteApiClient.AddAsync(this.Paciente);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPaciente()
        {
            this.idTextBox.Text = this.Paciente.IdPersona.ToString();
            this.nombreTextBox.Text = this.Paciente.ApellidoNombre;
            this.dniTextBox.Text = this.Paciente.DNI;
            this.fechaNacTextBox.Text = this.Paciente.FechaNacimiento.ToString();
            this.emailTextBox.Text = this.Paciente.Mail;
            this.telefonoTextBox.Text = this.Paciente.Telefono;
            this.contraseniaTextBox.Text = this.Paciente.Contrasenia;
            this.sexoTextBox.Text = this.Paciente.Sexo;
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

        private bool ValidatePaciente()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(contraseniaTextBox, string.Empty);
            errorProvider.SetError(telefonoTextBox, string.Empty);
            errorProvider.SetError(sexoTextBox, string.Empty);
            errorProvider.SetError(dniTextBox, string.Empty);
            errorProvider.SetError(emailTextBox, string.Empty);


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

            if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "El telefono es Requerido");
            }

            if (this.fechaNacTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(fechaNacTextBox, "La fecha de nacimiento es Requerida");
            }

            if (this.sexoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(sexoTextBox, "El sexo es Requerido");
            }

            if (this.dniTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(dniTextBox, "El DNI es Requerido");
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
    }
}
