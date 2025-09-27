namespace WinFormsApp
{
    partial class MenuProfesional
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            turnosMenu = new ToolStripMenuItem();
            verTurnosToolStripMenuItem = new ToolStripMenuItem();
            crearTurnosToolStripMenuItem = new ToolStripMenuItem();
            modificarTurnosToolStripMenuItem = new ToolStripMenuItem();
            borrarTurnosToolStripMenuItem = new ToolStripMenuItem();
            especialidadMenu = new ToolStripMenuItem();
            obrasSocialesMenu = new ToolStripMenuItem();
            perfilMenu = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { turnosMenu, especialidadMenu, obrasSocialesMenu, perfilMenu, windowsMenu, salirToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(738, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // turnosMenu
            // 
            turnosMenu.DropDownItems.AddRange(new ToolStripItem[] { verTurnosToolStripMenuItem, crearTurnosToolStripMenuItem, modificarTurnosToolStripMenuItem, borrarTurnosToolStripMenuItem });
            turnosMenu.Name = "turnosMenu";
            turnosMenu.Size = new Size(55, 20);
            turnosMenu.Text = "&Turnos";
            // 
            // verTurnosToolStripMenuItem
            // 
            verTurnosToolStripMenuItem.Name = "verTurnosToolStripMenuItem";
            verTurnosToolStripMenuItem.Size = new Size(164, 22);
            verTurnosToolStripMenuItem.Text = "&Ver Turnos";
            verTurnosToolStripMenuItem.Click += VerTurnosToolStripMenuItem_Click;
            // 
            // crearTurnosToolStripMenuItem
            // 
            crearTurnosToolStripMenuItem.Name = "crearTurnosToolStripMenuItem";
            crearTurnosToolStripMenuItem.Size = new Size(164, 22);
            crearTurnosToolStripMenuItem.Text = "&Crear Turnos";
            crearTurnosToolStripMenuItem.Click += CrearTurnosToolStripMenuItem_Click;
            // 
            // modificarTurnosToolStripMenuItem
            // 
            modificarTurnosToolStripMenuItem.Name = "modificarTurnosToolStripMenuItem";
            modificarTurnosToolStripMenuItem.Size = new Size(164, 22);
            modificarTurnosToolStripMenuItem.Text = "&Modificar Turnos";
            modificarTurnosToolStripMenuItem.Click += ModificarTurnosToolStripMenuItem_Click;
            // 
            // borrarTurnosToolStripMenuItem
            // 
            borrarTurnosToolStripMenuItem.Name = "borrarTurnosToolStripMenuItem";
            borrarTurnosToolStripMenuItem.Size = new Size(164, 22);
            borrarTurnosToolStripMenuItem.Text = "&Borrar Turnos";
            borrarTurnosToolStripMenuItem.Click += BorrarTurnosToolStripMenuItem_Click;
            // 
            // especialidadMenu
            // 
            especialidadMenu.Name = "especialidadMenu";
            especialidadMenu.Size = new Size(84, 20);
            especialidadMenu.Text = "&Especialidad";
            especialidadMenu.Click += ModificarEspecialidadToolStripMenuItem_Click;
            // 
            // obrasSocialesMenu
            // 
            obrasSocialesMenu.Name = "obrasSocialesMenu";
            obrasSocialesMenu.Size = new Size(95, 20);
            obrasSocialesMenu.Text = "&Obras Sociales";
            obrasSocialesMenu.Click += ModificarObrasSocialesToolStripMenuItem_Click;
            // 
            // perfilMenu
            // 
            perfilMenu.Name = "perfilMenu";
            perfilMenu.Size = new Size(46, 20);
            perfilMenu.Text = "&Perfil";
            perfilMenu.Click += ModificarPerfilToolStripMenuItem_Click;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(66, 20);
            windowsMenu.Text = "&Ventanas";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "&Cascada";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(180, 22);
            tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(180, 22);
            tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(180, 22);
            closeAllToolStripMenuItem.Text = "C&errar todo";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(180, 22);
            arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // MenuProfesional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 523);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MenuProfesional";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal del Profesional";
            WindowState = FormWindowState.Maximized;
            Load += MenuProfesional_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;

        private System.Windows.Forms.ToolStripMenuItem turnosMenu;
        private System.Windows.Forms.ToolStripMenuItem especialidadMenu;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesMenu;
        private System.Windows.Forms.ToolStripMenuItem perfilMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;

        private System.Windows.Forms.ToolStripMenuItem verTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}