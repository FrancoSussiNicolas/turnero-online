namespace WinFormsApp
{
    partial class ModificarEspecialidad
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
            dgvEspecialidades = new DataGridView();
            btnGuardar = new Button();
            btnCancelar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Dock = DockStyle.Top;
            dgvEspecialidades.Location = new Point(0, 0);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.Size = new Size(982, 212);
            dgvEspecialidades.TabIndex = 1;
            dgvEspecialidades.CellContentClick += dgvEspecialidades_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(255, 255, 128);
            btnGuardar.Location = new Point(682, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 43);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(191, 9);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 43);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 428);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(982, 125);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // ModificarEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvEspecialidades);
            Name = "ModificarEspecialidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Especialidad";
            Load += ModificarEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvEspecialidades;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column2;
        private Button btnGuardar;
        private Button button1;
        private Button btnCancelar;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
