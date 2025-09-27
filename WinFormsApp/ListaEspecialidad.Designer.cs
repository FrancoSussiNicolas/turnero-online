namespace WinFormsApp
{
    partial class ListaEspecialidad
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
            especialidadGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEliminarEspecialidad = new Button();
            btnModificarEspecialidad = new Button();
            btnAgregarEspecialidad = new Button();
            ((System.ComponentModel.ISupportInitialize)especialidadGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // especialidadGridView
            // 
            especialidadGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadGridView.Location = new Point(4, 12);
            especialidadGridView.Name = "especialidadGridView";
            especialidadGridView.ReadOnly = true;
            especialidadGridView.Size = new Size(798, 190);
            especialidadGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAgregarEspecialidad, 1, 0);
            tableLayoutPanel1.Controls.Add(btnModificarEspecialidad, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarEspecialidad, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 100);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.Anchor = AnchorStyles.None;
            btnEliminarEspecialidad.BackColor = Color.IndianRed;
            btnEliminarEspecialidad.Location = new Point(84, 7);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new Size(97, 36);
            btnEliminarEspecialidad.TabIndex = 1;
            btnEliminarEspecialidad.Text = "Eliminar";
            btnEliminarEspecialidad.UseVisualStyleBackColor = false;
            btnEliminarEspecialidad.Click += btnEliminarEspecialidad_Click;
            // 
            // btnModificarEspecialidad
            // 
            btnModificarEspecialidad.Anchor = AnchorStyles.None;
            btnModificarEspecialidad.AutoSize = true;
            btnModificarEspecialidad.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarEspecialidad.Location = new Point(618, 7);
            btnModificarEspecialidad.Name = "btnModificarEspecialidad";
            btnModificarEspecialidad.Size = new Size(95, 36);
            btnModificarEspecialidad.TabIndex = 3;
            btnModificarEspecialidad.Text = "Modificar";
            btnModificarEspecialidad.UseVisualStyleBackColor = false;
            btnModificarEspecialidad.Click += btnModificarEspecialidad_Click;
            // 
            // btnAgregarEspecialidad
            // 
            btnAgregarEspecialidad.Anchor = AnchorStyles.None;
            btnAgregarEspecialidad.BackColor = SystemColors.ActiveCaption;
            btnAgregarEspecialidad.Location = new Point(350, 7);
            btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            btnAgregarEspecialidad.Size = new Size(97, 36);
            btnAgregarEspecialidad.TabIndex = 2;
            btnAgregarEspecialidad.Text = "Agregar";
            btnAgregarEspecialidad.UseVisualStyleBackColor = false;
            btnAgregarEspecialidad.Click += btnAgregarEspecialidad_Click;
            // 
            // ListaEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(especialidadGridView);
            Name = "ListaEspecialidad";
            Text = "Lista Especialidad";
            ((System.ComponentModel.ISupportInitialize)especialidadGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView especialidadGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnModificarEspecialidad;
        private Button btnEliminarEspecialidad;
        private Button btnAgregarEspecialidad;
    }
}