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

        // Métodos para las subopciones del menú "Turnos"
        private void VerTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form verTurnosForm = new Form();
            verTurnosForm.MdiParent = this;
            verTurnosForm.Text = "Ver Turnos";
            verTurnosForm.Show();
        }

        private void CrearTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form crearTurnosForm = new Form();
            crearTurnosForm.MdiParent = this;
            crearTurnosForm.Text = "Crear Turnos";
            crearTurnosForm.Show();
        }

        private void ModificarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarTurnosForm = new Form();
            modificarTurnosForm.MdiParent = this;
            modificarTurnosForm.Text = "Modificar Turnos";
            modificarTurnosForm.Show();
        }

        private void BorrarTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form borrarTurnosForm = new Form();
            borrarTurnosForm.MdiParent = this;
            borrarTurnosForm.Text = "Borrar Turnos";
            borrarTurnosForm.Show();
        }

        // Métodos para las opciones de "Modificar" en los menús principales
        private void ModificarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarEspecialidadForm = new ModificarEspecialidad(1); // Cambiar por el valor que viene en la información del login
            modificarEspecialidadForm.MdiParent = this;
            modificarEspecialidadForm.Text = "Modificar Especialidad";
            modificarEspecialidadForm.Show();
        }

        private void ModificarObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarObrasSocialesForm = new Form();
            modificarObrasSocialesForm.MdiParent = this;
            modificarObrasSocialesForm.Text = "Modificar Obras Sociales";
            modificarObrasSocialesForm.Show();
        }

        private void ModificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modificarPerfilForm = new Form();
            modificarPerfilForm.MdiParent = this;
            modificarPerfilForm.Text = "Modificar Perfil";
            modificarPerfilForm.Show();
        }

        // Métodos de control de ventanas MDI (no modificados)
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

        // Eventos vacíos que se pueden eliminar o reutilizar
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void especialidadMenu_Click(object sender, EventArgs e)
        {
        }

        private void MenuProfesional_Load(object sender, EventArgs e)
        {
        }
    }
}