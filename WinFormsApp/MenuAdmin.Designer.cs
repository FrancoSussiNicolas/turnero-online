namespace WinFormsApp
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            profesionalesToolStripMenuItem = new ToolStripMenuItem();
            verProfesionalesToolStripMenuItem = new ToolStripMenuItem();
            consultoriosToolStripMenuItem = new ToolStripMenuItem();
            especialidadToolStripMenuItem = new ToolStripMenuItem();
            obraSocialToolStripMenuItem = new ToolStripMenuItem();
            verObrasSocialesToolStripMenuItem = new ToolStripMenuItem();
            crearObraSocialToolStripMenuItem = new ToolStripMenuItem();
            modificarObraSocialToolStripMenuItem = new ToolStripMenuItem();
            eliminarObraSocialToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            planObraSocialToolStripMenuItem = new ToolStripMenuItem();
            practicaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { profesionalesToolStripMenuItem, consultoriosToolStripMenuItem, especialidadToolStripMenuItem, obraSocialToolStripMenuItem, pacienteToolStripMenuItem, planObraSocialToolStripMenuItem, practicaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profesionalesToolStripMenuItem
            // 
            profesionalesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verProfesionalesToolStripMenuItem });
            profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            profesionalesToolStripMenuItem.Size = new Size(78, 20);
            profesionalesToolStripMenuItem.Text = "Profesional";
            profesionalesToolStripMenuItem.Click += profesionalesToolStripMenuItem_Click;
            // 
            // verProfesionalesToolStripMenuItem
            // 
            verProfesionalesToolStripMenuItem.Name = "verProfesionalesToolStripMenuItem";
            verProfesionalesToolStripMenuItem.Size = new Size(67, 22);
            // 
            // consultoriosToolStripMenuItem
            // 
            consultoriosToolStripMenuItem.Name = "consultoriosToolStripMenuItem";
            consultoriosToolStripMenuItem.Size = new Size(81, 20);
            consultoriosToolStripMenuItem.Text = "Consultorio";
            consultoriosToolStripMenuItem.Click += consultoriosToolStripMenuItem_Click;
            // 
            // especialidadToolStripMenuItem
            // 
            especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            especialidadToolStripMenuItem.Size = new Size(84, 20);
            especialidadToolStripMenuItem.Text = "Especialidad";
            especialidadToolStripMenuItem.Click += especialidadToolStripMenuItem_Click;
            // 
            // obraSocialToolStripMenuItem
            // 
            obraSocialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verObrasSocialesToolStripMenuItem, crearObraSocialToolStripMenuItem, modificarObraSocialToolStripMenuItem, eliminarObraSocialToolStripMenuItem });
            obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            obraSocialToolStripMenuItem.Size = new Size(79, 20);
            obraSocialToolStripMenuItem.Text = "Obra Social";
            // 
            // verObrasSocialesToolStripMenuItem
            // 
            verObrasSocialesToolStripMenuItem.Name = "verObrasSocialesToolStripMenuItem";
            verObrasSocialesToolStripMenuItem.Size = new Size(185, 22);
            verObrasSocialesToolStripMenuItem.Text = "Ver obras sociales";
            // 
            // crearObraSocialToolStripMenuItem
            // 
            crearObraSocialToolStripMenuItem.Name = "crearObraSocialToolStripMenuItem";
            crearObraSocialToolStripMenuItem.Size = new Size(185, 22);
            crearObraSocialToolStripMenuItem.Text = "Crear obra social";
            // 
            // modificarObraSocialToolStripMenuItem
            // 
            modificarObraSocialToolStripMenuItem.Name = "modificarObraSocialToolStripMenuItem";
            modificarObraSocialToolStripMenuItem.Size = new Size(185, 22);
            modificarObraSocialToolStripMenuItem.Text = "Modificar obra social";
            // 
            // eliminarObraSocialToolStripMenuItem
            // 
            eliminarObraSocialToolStripMenuItem.Name = "eliminarObraSocialToolStripMenuItem";
            eliminarObraSocialToolStripMenuItem.Size = new Size(185, 22);
            eliminarObraSocialToolStripMenuItem.Text = "Eliminar obra social";
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(64, 20);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // planObraSocialToolStripMenuItem
            // 
            planObraSocialToolStripMenuItem.Name = "planObraSocialToolStripMenuItem";
            planObraSocialToolStripMenuItem.Size = new Size(105, 20);
            planObraSocialToolStripMenuItem.Text = "Plan Obra Social";
            planObraSocialToolStripMenuItem.Click += planObraSocialToolStripMenuItem_Click;
            // 
            // practicaToolStripMenuItem
            // 
            practicaToolStripMenuItem.Name = "practicaToolStripMenuItem";
            practicaToolStripMenuItem.Size = new Size(61, 20);
            practicaToolStripMenuItem.Text = "Practica";
            practicaToolStripMenuItem.Click += practicaToolStripMenuItem_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuAdmin";
            Text = "Menu Administrador";
            Load += MenuAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profesionalesToolStripMenuItem;
        private ToolStripMenuItem verProfesionalesToolStripMenuItem;
        private ToolStripMenuItem consultoriosToolStripMenuItem;
        private ToolStripMenuItem especialidadToolStripMenuItem;
        private ToolStripMenuItem obraSocialToolStripMenuItem;
        private ToolStripMenuItem verObrasSocialesToolStripMenuItem;
        private ToolStripMenuItem crearObraSocialToolStripMenuItem;
        private ToolStripMenuItem modificarObraSocialToolStripMenuItem;
        private ToolStripMenuItem eliminarObraSocialToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem planObraSocialToolStripMenuItem;
        private ToolStripMenuItem practicaToolStripMenuItem;
    }
}