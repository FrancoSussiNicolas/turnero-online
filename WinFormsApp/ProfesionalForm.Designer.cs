namespace WinFormsApp
{
    partial class ProfesionalForm
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
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
            ProfesionalesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(730, 538);
            eliminarButton.Margin = new Padding(3, 2, 3, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(121, 42);
            eliminarButton.TabIndex = 7;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(505, 538);
            modificarButton.Margin = new Padding(3, 2, 3, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(121, 42);
            modificarButton.TabIndex = 6;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(283, 538);
            agregarButton.Margin = new Padding(3, 2, 3, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(121, 42);
            agregarButton.TabIndex = 5;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // ProfesionalesDataGridView
            // 
            ProfesionalesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfesionalesDataGridView.Location = new Point(12, 11);
            ProfesionalesDataGridView.Margin = new Padding(3, 2, 3, 2);
            ProfesionalesDataGridView.Name = "ProfesionalesDataGridView";
            ProfesionalesDataGridView.RowHeadersWidth = 51;
            ProfesionalesDataGridView.Size = new Size(1091, 495);
            ProfesionalesDataGridView.TabIndex = 4;
            // 
            // ProfesionalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 598);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(ProfesionalesDataGridView);
            Name = "ProfesionalForm";
            Text = "Profesionales";
            Load += ProfesionalForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
        private DataGridView ProfesionalesDataGridView;
    }
}