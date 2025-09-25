namespace WinFormsApp
{
    partial class VerObrasSocialesProfesional
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
            dvgObrasSociales = new DataGridView();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).BeginInit();
            SuspendLayout();
            // 
            // dvgObrasSociales
            // 
            dvgObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgObrasSociales.Location = new Point(0, 0);
            dvgObrasSociales.Name = "dvgObrasSociales";
            dvgObrasSociales.RowHeadersWidth = 51;
            dvgObrasSociales.Size = new Size(982, 267);
            dvgObrasSociales.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ButtonShadow;
            btnVolver.Location = new Point(145, 413);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 43);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(419, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 43);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Eliminar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 255, 128);
            btnGuardar.Location = new Point(684, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 43);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // VerObrasSocialesProfesional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(dvgObrasSociales);
            Name = "VerObrasSocialesProfesional";
            Text = "Ver Obras Sociales";
            Load += VerObrasSocialesProfesional_Load;
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgObrasSociales;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}