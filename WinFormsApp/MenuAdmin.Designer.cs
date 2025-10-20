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
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            turnosToolStripMenuItem = new ToolStripMenuItem();
            consultoriosToolStripMenuItem = new ToolStripMenuItem();
            especialidadToolStripMenuItem = new ToolStripMenuItem();
            obraSocialToolStripMenuItem = new ToolStripMenuItem();
            verObrasSocialesToolStripMenuItem = new ToolStripMenuItem();
            crearObraSocialToolStripMenuItem = new ToolStripMenuItem();
            modificarObraSocialToolStripMenuItem = new ToolStripMenuItem();
            eliminarObraSocialToolStripMenuItem = new ToolStripMenuItem();
            planObraSocialToolStripMenuItem = new ToolStripMenuItem();
            practicaToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            obrasSocialesToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profesionalesToolStripMenuItem, pacienteToolStripMenuItem, turnosToolStripMenuItem, consultoriosToolStripMenuItem, especialidadToolStripMenuItem, obraSocialToolStripMenuItem, planObraSocialToolStripMenuItem, practicaToolStripMenuItem, reportesToolStripMenuItem, perfilToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1327, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // profesionalesToolStripMenuItem
            // 
            profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            profesionalesToolStripMenuItem.Size = new Size(97, 24);
            profesionalesToolStripMenuItem.Text = "Profesional";
            profesionalesToolStripMenuItem.Click += profesionalesToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(78, 24);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // turnosToolStripMenuItem
            // 
            turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            turnosToolStripMenuItem.Size = new Size(67, 24);
            turnosToolStripMenuItem.Text = "Turnos";
            turnosToolStripMenuItem.Click += turnosToolStripMenuItem_Click;
            // 
            // consultoriosToolStripMenuItem
            // 
            consultoriosToolStripMenuItem.Name = "consultoriosToolStripMenuItem";
            consultoriosToolStripMenuItem.Size = new Size(99, 24);
            consultoriosToolStripMenuItem.Text = "Consultorio";
            consultoriosToolStripMenuItem.Click += consultoriosToolStripMenuItem_Click;
            // 
            // especialidadToolStripMenuItem
            // 
            especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            especialidadToolStripMenuItem.Size = new Size(107, 24);
            especialidadToolStripMenuItem.Text = "Especialidad";
            especialidadToolStripMenuItem.Click += especialidadToolStripMenuItem_Click;
            // 
            // obraSocialToolStripMenuItem
            // 
            obraSocialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verObrasSocialesToolStripMenuItem, crearObraSocialToolStripMenuItem, modificarObraSocialToolStripMenuItem, eliminarObraSocialToolStripMenuItem });
            obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            obraSocialToolStripMenuItem.Size = new Size(100, 24);
            obraSocialToolStripMenuItem.Text = "Obra Social";
            obraSocialToolStripMenuItem.Click += obraSocialToolStripMenuItem_Click;
            // 
            // verObrasSocialesToolStripMenuItem
            // 
            verObrasSocialesToolStripMenuItem.Name = "verObrasSocialesToolStripMenuItem";
            verObrasSocialesToolStripMenuItem.Size = new Size(233, 26);
            verObrasSocialesToolStripMenuItem.Text = "Ver obras sociales";
            // 
            // crearObraSocialToolStripMenuItem
            // 
            crearObraSocialToolStripMenuItem.Name = "crearObraSocialToolStripMenuItem";
            crearObraSocialToolStripMenuItem.Size = new Size(233, 26);
            crearObraSocialToolStripMenuItem.Text = "Crear obra social";
            // 
            // modificarObraSocialToolStripMenuItem
            // 
            modificarObraSocialToolStripMenuItem.Name = "modificarObraSocialToolStripMenuItem";
            modificarObraSocialToolStripMenuItem.Size = new Size(233, 26);
            modificarObraSocialToolStripMenuItem.Text = "Modificar obra social";
            // 
            // eliminarObraSocialToolStripMenuItem
            // 
            eliminarObraSocialToolStripMenuItem.Name = "eliminarObraSocialToolStripMenuItem";
            eliminarObraSocialToolStripMenuItem.Size = new Size(233, 26);
            eliminarObraSocialToolStripMenuItem.Text = "Eliminar obra social";
            // 
            // planObraSocialToolStripMenuItem
            // 
            planObraSocialToolStripMenuItem.Name = "planObraSocialToolStripMenuItem";
            planObraSocialToolStripMenuItem.Size = new Size(132, 24);
            planObraSocialToolStripMenuItem.Text = "Plan Obra Social";
            planObraSocialToolStripMenuItem.Click += planObraSocialToolStripMenuItem_Click;
            // 
            // practicaToolStripMenuItem
            // 
            practicaToolStripMenuItem.Name = "practicaToolStripMenuItem";
            practicaToolStripMenuItem.Size = new Size(75, 24);
            practicaToolStripMenuItem.Text = "Practica";
            practicaToolStripMenuItem.Click += practicaToolStripMenuItem_Click;
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(56, 24);
            perfilToolStripMenuItem.Text = "Perfil";
            perfilToolStripMenuItem.Click += perfilToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { obrasSocialesToolStripMenuItem, especialidadesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // obrasSocialesToolStripMenuItem
            // 
            obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            obrasSocialesToolStripMenuItem.Size = new Size(224, 26);
            obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            obrasSocialesToolStripMenuItem.Click += obrasSocialesToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(224, 26);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem turnosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
    }
}