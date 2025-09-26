namespace WinFormsApp
{
    partial class ListaPacientes
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
            pacientesGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pacientesGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pacientesGridView
            // 
            pacientesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pacientesGridView.Location = new Point(369, 93);
            pacientesGridView.Name = "pacientesGridView";
            pacientesGridView.ReadOnly = true;
            pacientesGridView.Size = new Size(240, 150);
            pacientesGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.Location = new Point(356, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 34);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListaPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pacientesGridView);
            Name = "ListaPacientes";
            Text = "Lista Pacientes";
            ((System.ComponentModel.ISupportInitialize)pacientesGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pacientesGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnVolver;
    }
}