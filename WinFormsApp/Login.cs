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
    public enum TipoUsuario
    {
        Admin,
        Profesional
    }

    public partial class Login : Form
    {
        public TipoUsuario TipoUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "Admin" && this.txtPass.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.TipoUsuario = TipoUsuario.Admin;
            }
            else if (this.txtUsuario.Text == "Profesional" && this.txtPass.Text == "profesional")
            {
                this.DialogResult = DialogResult.OK;
                this.TipoUsuario = TipoUsuario.Profesional;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
