namespace WinFormsApp
{
    partial class PacienteForm
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
            PacientesDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PacientesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PacientesDataGridView
            // 
            PacientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PacientesDataGridView.Location = new Point(12, 12);
            PacientesDataGridView.Name = "PacientesDataGridView";
            PacientesDataGridView.RowHeadersWidth = 51;
            PacientesDataGridView.Size = new Size(776, 365);
            PacientesDataGridView.TabIndex = 0;
            PacientesDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(79, 403);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(138, 35);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(324, 403);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(138, 35);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(582, 403);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(138, 35);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(PacientesDataGridView);
            Name = "PacienteForm";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)PacientesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PacientesDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
    }
}