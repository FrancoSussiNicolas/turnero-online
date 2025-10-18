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
            ProfesionalesDataGridView = new DataGridView();
            btnVolver = new Button();
            btnEliminarProfesional = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarProfesional = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProfesionalesDataGridView
            // 
            ProfesionalesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfesionalesDataGridView.Location = new Point(12, 11);
            ProfesionalesDataGridView.Margin = new Padding(3, 2, 3, 2);
            ProfesionalesDataGridView.Name = "ProfesionalesDataGridView";
            ProfesionalesDataGridView.ReadOnly = true;
            ProfesionalesDataGridView.RowHeadersWidth = 51;
            ProfesionalesDataGridView.Size = new Size(1091, 374);
            ProfesionalesDataGridView.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = SystemColors.ActiveBorder;
            btnVolver.Location = new Point(130, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 37);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminarProfesional
            // 
            btnEliminarProfesional.Anchor = AnchorStyles.None;
            btnEliminarProfesional.BackColor = Color.FromArgb(128, 255, 128);
            btnEliminarProfesional.Location = new Point(501, 6);
            btnEliminarProfesional.Name = "btnEliminarProfesional";
            btnEliminarProfesional.Size = new Size(110, 37);
            btnEliminarProfesional.TabIndex = 7;
            btnEliminarProfesional.Text = "Cambiar Estado";
            btnEliminarProfesional.UseVisualStyleBackColor = false;
            btnEliminarProfesional.Click += btnEliminarProfesional_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAgregarProfesional, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarProfesional, 1, 0);
            tableLayoutPanel1.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 498);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1115, 100);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnAgregarProfesional
            // 
            btnAgregarProfesional.Anchor = AnchorStyles.None;
            btnAgregarProfesional.BackColor = Color.FromArgb(128, 128, 255);
            btnAgregarProfesional.Location = new Point(873, 6);
            btnAgregarProfesional.Name = "btnAgregarProfesional";
            btnAgregarProfesional.Size = new Size(110, 37);
            btnAgregarProfesional.TabIndex = 8;
            btnAgregarProfesional.Text = "Agregar";
            btnAgregarProfesional.UseVisualStyleBackColor = false;
            btnAgregarProfesional.Click += this.btnAgregarProfesional_Click;
            // 
            // ProfesionalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 598);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ProfesionalesDataGridView);
            Name = "ProfesionalForm";
            Text = "Profesionales";
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ProfesionalesDataGridView;
        private Button btnVolver;
        private Button btnEliminarProfesional;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregarProfesional;
    }
}