namespace WinFormsApp
{
    partial class ListaTurnos
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
            tlTurnos = new ToolStripContainer();
            tableTurnos = new TableLayoutPanel();
            dvgTurnos = new DataGridView();
            btnVolver = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            tlTurnos.ContentPanel.SuspendLayout();
            tlTurnos.SuspendLayout();
            tableTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTurnos).BeginInit();
            SuspendLayout();
            // 
            // tlTurnos
            // 
            // 
            // tlTurnos.ContentPanel
            // 
            tlTurnos.ContentPanel.Controls.Add(tableTurnos);
            tlTurnos.ContentPanel.Size = new Size(800, 425);
            tlTurnos.Dock = DockStyle.Fill;
            tlTurnos.Location = new Point(0, 0);
            tlTurnos.Name = "tlTurnos";
            tlTurnos.Size = new Size(800, 450);
            tlTurnos.TabIndex = 0;
            tlTurnos.Text = "toolStripContainer1";
            // 
            // tableTurnos
            // 
            tableTurnos.ColumnCount = 5;
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableTurnos.Controls.Add(dvgTurnos, 0, 0);
            tableTurnos.Controls.Add(btnVolver, 0, 1);
            tableTurnos.Controls.Add(btnAgregar, 4, 1);
            tableTurnos.Controls.Add(btnModificar, 3, 1);
            tableTurnos.Controls.Add(btnEliminar, 2, 1);
            tableTurnos.Controls.Add(btnActualizar, 1, 1);
            tableTurnos.Dock = DockStyle.Fill;
            tableTurnos.Location = new Point(0, 0);
            tableTurnos.Name = "tableTurnos";
            tableTurnos.RowCount = 2;
            tableTurnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableTurnos.RowStyles.Add(new RowStyle());
            tableTurnos.Size = new Size(800, 425);
            tableTurnos.TabIndex = 0;
            // 
            // dvgTurnos
            // 
            dvgTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTurnos.SetColumnSpan(dvgTurnos, 5);
            dvgTurnos.Dock = DockStyle.Fill;
            dvgTurnos.Location = new Point(3, 3);
            dvgTurnos.Name = "dvgTurnos";
            dvgTurnos.Size = new Size(794, 373);
            dvgTurnos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(30, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 40);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(670, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Turno";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(255, 255, 128);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(510, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 40);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Turno";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(350, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Turno";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(190, 382);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Lista";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ListaTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlTurnos);
            Name = "ListaTurnos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de Turnos";
            Load += ListaTurnos_Load;
            tlTurnos.ContentPanel.ResumeLayout(false);
            tlTurnos.ResumeLayout(false);
            tlTurnos.PerformLayout();
            tableTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgTurnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tlTurnos;
        private TableLayoutPanel tableTurnos;
        private DataGridView dvgTurnos;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnActualizar;
    }
}