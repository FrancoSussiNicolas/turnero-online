namespace WinFormsApp
{
    partial class VerObrasSocialesProfesional
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dvgObrasSociales = new DataGridView();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dvgObrasSociales
            // 
            dvgObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgObrasSociales.Dock = DockStyle.Top;
            dvgObrasSociales.Location = new Point(0, 0);
            dvgObrasSociales.Name = "dvgObrasSociales";
            dvgObrasSociales.ReadOnly = true;
            dvgObrasSociales.RowHeadersWidth = 51;
            dvgObrasSociales.Size = new Size(860, 267);
            dvgObrasSociales.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = SystemColors.ButtonShadow;
            btnVolver.Location = new Point(90, 17);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 43);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(389, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 43);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.FromArgb(255, 255, 128);
            btnAgregar.Location = new Point(675, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 43);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.1605339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.8394661F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 261F));
            tableLayoutPanel1.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregar, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 382);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(860, 78);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // VerObrasSocialesProfesional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 460);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dvgObrasSociales);
            Name = "VerObrasSocialesProfesional";
            Text = "Ver Obras Sociales";
            Load += VerObrasSocialesProfesional_Load;
            Click += VerObrasSocialesProfesional_Click;
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgObrasSociales;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnGuardar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregar;
    }
}
