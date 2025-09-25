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
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { turnosMenu, especialidadMenu, obrasSocialesMenu, perfilMenu, windowsMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // turnosMenu
            // 
            turnosMenu.DropDownItems.AddRange(new ToolStripItem[] { verTurnosToolStripMenuItem, crearTurnosToolStripMenuItem, modificarTurnosToolStripMenuItem, borrarTurnosToolStripMenuItem });
            turnosMenu.Name = "turnosMenu";
            turnosMenu.Size = new Size(67, 24);
            turnosMenu.Text = "&Turnos";
            // 
            // verTurnosToolStripMenuItem
            // 
            verTurnosToolStripMenuItem.Name = "verTurnosToolStripMenuItem";
            verTurnosToolStripMenuItem.Size = new Size(204, 26);
            verTurnosToolStripMenuItem.Text = "&Ver Turnos";
            verTurnosToolStripMenuItem.Click += VerTurnosToolStripMenuItem_Click;
            // 
            // crearTurnosToolStripMenuItem
            // 
            crearTurnosToolStripMenuItem.Name = "crearTurnosToolStripMenuItem";
            crearTurnosToolStripMenuItem.Size = new Size(204, 26);
            crearTurnosToolStripMenuItem.Text = "&Crear Turnos";
            crearTurnosToolStripMenuItem.Click += CrearTurnosToolStripMenuItem_Click;
            // 
            // modificarTurnosToolStripMenuItem
            // 
            modificarTurnosToolStripMenuItem.Name = "modificarTurnosToolStripMenuItem";
            modificarTurnosToolStripMenuItem.Size = new Size(204, 26);
            modificarTurnosToolStripMenuItem.Text = "&Modificar Turnos";
            modificarTurnosToolStripMenuItem.Click += ModificarTurnosToolStripMenuItem_Click;
            // 
            // borrarTurnosToolStripMenuItem
            // 
            borrarTurnosToolStripMenuItem.Name = "borrarTurnosToolStripMenuItem";
            borrarTurnosToolStripMenuItem.Size = new Size(204, 26);
            borrarTurnosToolStripMenuItem.Text = "&Borrar Turnos";
            borrarTurnosToolStripMenuItem.Click += BorrarTurnosToolStripMenuItem_Click;
            // 
            // especialidadMenu
            // 
            especialidadMenu.Name = "especialidadMenu";
            especialidadMenu.Size = new Size(107, 24);
            especialidadMenu.Text = "&Especialidad";
            especialidadMenu.Click += ModificarEspecialidadToolStripMenuItem_Click;
            // 
            // obrasSocialesMenu
            // 
            obrasSocialesMenu.Name = "obrasSocialesMenu";
            obrasSocialesMenu.Size = new Size(120, 24);
            obrasSocialesMenu.Text = "&Obras Sociales";
            obrasSocialesMenu.Click += ModificarObrasSocialesToolStripMenuItem_Click;
            // 
            // perfilMenu
            // 
            perfilMenu.Name = "perfilMenu";
            perfilMenu.Size = new Size(56, 24);
            perfilMenu.Text = "&Perfil";
            perfilMenu.Click += ModificarPerfilToolStripMenuItem_Click;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(82, 24);
            windowsMenu.Text = "&Ventanas";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(224, 26);
            cascadeToolStripMenuItem.Text = "&Cascada";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(224, 26);
            tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(224, 26);
            tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(224, 26);
            closeAllToolStripMenuItem.Text = "C&errar todo";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(224, 26);
            arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // MenuProfesional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 697);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuProfesional";
            Text = "Menú Principal del Profesional";
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
    }
}