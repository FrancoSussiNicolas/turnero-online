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
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(0, 0);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.Size = new Size(982, 267);
            dgvEspecialidades.TabIndex = 1;
            dgvEspecialidades.CellContentClick += dgvEspecialidades_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 255, 128);
            btnGuardar.Location = new Point(629, 405);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 43);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(214, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 43);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ModificarEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEspecialidades);
            Name = "ModificarEspecialidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Especialidad";
            Load += ModificarEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvEspecialidades;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column2;
        private Button btnGuardar;
        private Button button1;
        private Button btnCancelar;
    }
}
