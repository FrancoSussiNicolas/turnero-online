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
            planObraSocialToolStripMenuItem = new ToolStripMenuItem();
            practicaToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { profesionalesToolStripMenuItem, pacienteToolStripMenuItem, turnosToolStripMenuItem, consultoriosToolStripMenuItem, especialidadToolStripMenuItem, obraSocialToolStripMenuItem, planObraSocialToolStripMenuItem, practicaToolStripMenuItem, perfilToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profesionalesToolStripMenuItem
            // 
            profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            profesionalesToolStripMenuItem.Size = new Size(78, 20);
            profesionalesToolStripMenuItem.Text = "Profesional";
            profesionalesToolStripMenuItem.Click += profesionalesToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(64, 20);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // turnosToolStripMenuItem
            // 
            turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            turnosToolStripMenuItem.Size = new Size(55, 20);
            turnosToolStripMenuItem.Text = "Turnos";
            turnosToolStripMenuItem.Click += turnosToolStripMenuItem_Click;
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
            obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            obraSocialToolStripMenuItem.Size = new Size(79, 20);
            obraSocialToolStripMenuItem.Text = "Obra Social";
            obraSocialToolStripMenuItem.Click += obraSocialToolStripMenuItem_Click;
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
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(46, 20);
            perfilToolStripMenuItem.Text = "Perfil";
            perfilToolStripMenuItem.Click += perfilToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
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
        private ToolStripMenuItem consultoriosToolStripMenuItem;
        private ToolStripMenuItem especialidadToolStripMenuItem;
        private ToolStripMenuItem obraSocialToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem planObraSocialToolStripMenuItem;
        private ToolStripMenuItem practicaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem turnosToolStripMenuItem;
    }
}