namespace WinFormsApp
{
    partial class ListaPractica
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
            practicasGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarPlanPractica = new Button();
            btnAgregarPractica = new Button();
            btnEliminarPractica = new Button();
            btnModificarPractica = new Button();
            ((System.ComponentModel.ISupportInitialize)practicasGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // practicasGridView
            // 
            practicasGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            practicasGridView.Location = new Point(12, 3);
            practicasGridView.Name = "practicasGridView";
            practicasGridView.ReadOnly = true;
            practicasGridView.Size = new Size(776, 171);
            practicasGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.7784424F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.8922157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.32934F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.Controls.Add(btnAgregarPlanPractica, 3, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPractica, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarPractica, 0, 0);
            tableLayoutPanel1.Controls.Add(btnModificarPractica, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1097, 100);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btnAgregarPlanPractica
            // 
            btnAgregarPlanPractica.Anchor = AnchorStyles.None;
            btnAgregarPlanPractica.AutoSize = true;
            btnAgregarPlanPractica.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarPlanPractica.Location = new Point(918, 7);
            btnAgregarPlanPractica.Name = "btnAgregarPlanPractica";
            btnAgregarPlanPractica.Size = new Size(96, 36);
            btnAgregarPlanPractica.TabIndex = 4;
            btnAgregarPlanPractica.Text = "Agregar Plan";
            btnAgregarPlanPractica.UseVisualStyleBackColor = false;
            btnAgregarPlanPractica.Click += btnAgregarPlanPractica_Click;
            // 
            // btnAgregarPractica
            // 
            btnAgregarPractica.Anchor = AnchorStyles.None;
            btnAgregarPractica.BackColor = SystemColors.ActiveCaption;
            btnAgregarPractica.Location = new Point(350, 7);
            btnAgregarPractica.Name = "btnAgregarPractica";
            btnAgregarPractica.Size = new Size(97, 36);
            btnAgregarPractica.TabIndex = 2;
            btnAgregarPractica.Text = "Agregar";
            btnAgregarPractica.UseVisualStyleBackColor = false;
            btnAgregarPractica.Click += btnAgregarPractica_Click;
            // 
            // btnEliminarPractica
            // 
            btnEliminarPractica.Anchor = AnchorStyles.None;
            btnEliminarPractica.BackColor = Color.IndianRed;
            btnEliminarPractica.Location = new Point(80, 7);
            btnEliminarPractica.Name = "btnEliminarPractica";
            btnEliminarPractica.Size = new Size(97, 36);
            btnEliminarPractica.TabIndex = 1;
            btnEliminarPractica.Text = "Eliminar";
            btnEliminarPractica.UseVisualStyleBackColor = false;
            btnEliminarPractica.Click += btnEliminarPractica_Click;
            // 
            // btnModificarPractica
            // 
            btnModificarPractica.Anchor = AnchorStyles.None;
            btnModificarPractica.AutoSize = true;
            btnModificarPractica.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarPractica.Location = new Point(635, 7);
            btnModificarPractica.Name = "btnModificarPractica";
            btnModificarPractica.Size = new Size(104, 36);
            btnModificarPractica.TabIndex = 3;
            btnModificarPractica.Text = "Modificar";
            btnModificarPractica.UseVisualStyleBackColor = false;
            btnModificarPractica.Click += btnModificarPractica_Click;
            // 
            // ListaPractica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(practicasGridView);
            Name = "ListaPractica";
            Text = "Lista Practica";
            ((System.ComponentModel.ISupportInitialize)practicasGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView practicasGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregarPlanPractica;
        private Button btnAgregarPractica;
        private Button btnModificarPractica;
        private Button btnEliminarPractica;
    }
}