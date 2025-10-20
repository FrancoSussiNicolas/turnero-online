using Shared;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuProfesional : Form
    {
        public MenuProfesional()
        {
            InitializeComponent();
            this.Text = "Menú Principal del Profesional";
        }

        private void ModificarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarEspecialidadForm = new ModificarEspecialidad((int)SessionManager.PersonaId); // Cambiar por el valor que viene en la información del login
            modificarEspecialidadForm.MdiParent = this;
            modificarEspecialidadForm.Text = "Modificar Especialidad";
            modificarEspecialidadForm.Show();
        }

        private void ModificarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarObrasSocialesForm = new VerObrasSocialesProfesional();
            modificarObrasSocialesForm.MdiParent = this;
            modificarObrasSocialesForm.Text = "Modificar Obras Sociales";
            modificarObrasSocialesForm.Show();
        }

        private void ModificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarPerfilForm = new PerfilProfesional();
            modificarPerfilForm.MdiParent = this;
            modificarPerfilForm.Text = "Modificar Perfil";
            modificarPerfilForm.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void especialidadMenu_Click(object sender, EventArgs e)
        {
        }

        private void MenuProfesional_Load(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            this.Dispose();
        }

        private void turnosMenu_Click(object sender, EventArgs e)
        {
            Form verTurnosForm = new ListaTurnos();
            verTurnosForm.MdiParent = this;
            verTurnosForm.Text = "Ver Turnos";
            verTurnosForm.Show();
        }

        private void reporteObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reporteObrasSociales = new ReporteObrasSocialesForm();
            reporteObrasSociales.MdiParent = this;
            reporteObrasSociales.Text = "Reporte Pacientes Por Obra Social";
            reporteObrasSociales.Show();
        }
    }
}