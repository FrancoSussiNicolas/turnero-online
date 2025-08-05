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
            PacientesDataGridView.Location = new Point(10, 9);
            PacientesDataGridView.Margin = new Padding(3, 2, 3, 2);
            PacientesDataGridView.Name = "PacientesDataGridView";
            PacientesDataGridView.RowHeadersWidth = 51;
            PacientesDataGridView.Size = new Size(1091, 495);
            PacientesDataGridView.TabIndex = 0;
            PacientesDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(281, 536);
            agregarButton.Margin = new Padding(3, 2, 3, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(121, 42);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(503, 536);
            modificarButton.Margin = new Padding(3, 2, 3, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(121, 42);
            modificarButton.TabIndex = 2;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(728, 536);
            eliminarButton.Margin = new Padding(3, 2, 3, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(121, 42);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 610);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(PacientesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
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