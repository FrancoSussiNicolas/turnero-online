using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }
        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesionalForm profesionales = new ProfesionalForm();
            profesionales.MdiParent = this;
            profesionales.Show();
        }

        private void consultoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultorioForm consultorios = new ConsultorioForm();
            consultorios.MdiParent = this;
            consultorios.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPacientes pacientes = new ListaPacientes();
            pacientes.MdiParent = this;
            pacientes.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEspecialidad especialidades = new ListaEspecialidad();
            especialidades.MdiParent = this;
            especialidades.Show();
        }

        private void practicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPractica practica = new ListaPractica();
            practica.MdiParent = this;
            practica.Show();
        }

        private void planObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPlanObraSocial planObraSocial = new ListaPlanObraSocial();
            planObraSocial.MdiParent = this;
            planObraSocial.Show();
        }

        private void obraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaObraSocial obraSocial = new ListaObraSocial();
            obraSocial.MdiParent = this;
            obraSocial.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            this.Dispose();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarPerfilForm = new PerfilAdmin();
            modificarPerfilForm.MdiParent = this;
            modificarPerfilForm.Text = "Modificar Perfil";
            modificarPerfilForm.Show();
        }
    }
}
