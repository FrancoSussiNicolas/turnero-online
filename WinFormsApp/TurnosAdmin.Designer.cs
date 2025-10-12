namespace WinFormsApp
{
    partial class TurnosAdmin
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
            dvgTurnos = new DataGridView();
            tableTurnos = new TableLayoutPanel();
            btnVolver = new Button();
            btnActualizar = new Button();
            dvgTurnosAdmin = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgTurnos).BeginInit();
            tableTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTurnosAdmin).BeginInit();
            SuspendLayout();
            // 
            // dvgTurnos
            // 
            dvgTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTurnos.Dock = DockStyle.Fill;
            dvgTurnos.Location = new Point(0, 0);
            dvgTurnos.Name = "dvgTurnos";
            dvgTurnos.Size = new Size(800, 450);
            dvgTurnos.TabIndex = 1;
            // 
            // tableTurnos
            // 
            tableTurnos.ColumnCount = 2;
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableTurnos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableTurnos.Controls.Add(dvgTurnosAdmin, 0, 0);
            tableTurnos.Controls.Add(btnVolver, 0, 1);
            tableTurnos.Controls.Add(btnActualizar, 1, 1);
            tableTurnos.Dock = DockStyle.Fill;
            tableTurnos.Location = new Point(0, 0);
            tableTurnos.Name = "tableTurnos";
            tableTurnos.RowCount = 2;
            tableTurnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableTurnos.RowStyles.Add(new RowStyle());
            tableTurnos.Size = new Size(800, 450);
            tableTurnos.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(150, 407);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 40);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = Color.White;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(550, 407);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Lista";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dvgTurnosAdmin
            // 
            dvgTurnosAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTurnos.SetColumnSpan(dvgTurnosAdmin, 2);
            dvgTurnosAdmin.Dock = DockStyle.Fill;
            dvgTurnosAdmin.Location = new Point(3, 3);
            dvgTurnosAdmin.Name = "dvgTurnosAdmin";
            dvgTurnosAdmin.Size = new Size(794, 398);
            dvgTurnosAdmin.TabIndex = 0;
            // 
            // TurnosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableTurnos);
            Controls.Add(dvgTurnos);
            Name = "TurnosAdmin";
            Text = "TurnosAdmin";
            ((System.ComponentModel.ISupportInitialize)dvgTurnos).EndInit();
            tableTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgTurnosAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgTurnos;
        private TableLayoutPanel tableTurnos;
        private Button btnVolver;
        private Button btnActualizar;
        private DataGridView dvgTurnosAdmin;
    }
}