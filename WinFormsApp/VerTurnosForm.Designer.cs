namespace WinFormsApp
{
    partial class VerTurnosForm
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
            TurnosDataGridView = new DataGridView();
            btnAceptar = new Button();
            btnEliminarTurno = new Button();
            ((System.ComponentModel.ISupportInitialize)TurnosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // TurnosDataGridView
            // 
            TurnosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TurnosDataGridView.Location = new Point(14, 11);
            TurnosDataGridView.Name = "TurnosDataGridView";
            TurnosDataGridView.Size = new Size(774, 363);
            TurnosDataGridView.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(179, 395);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(168, 33);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminarTurno
            // 
            btnEliminarTurno.Location = new Point(442, 395);
            btnEliminarTurno.Name = "btnEliminarTurno";
            btnEliminarTurno.Size = new Size(193, 33);
            btnEliminarTurno.TabIndex = 2;
            btnEliminarTurno.Text = "Eliminar";
            btnEliminarTurno.UseVisualStyleBackColor = true;
            btnEliminarTurno.Click += btnEliminarTurno_Click;
            // 
            // VerTurnosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarTurno);
            Controls.Add(btnAceptar);
            Controls.Add(TurnosDataGridView);
            Name = "VerTurnosForm";
            Text = "Turnos";
            Load += VerTurnos_Load;
            ((System.ComponentModel.ISupportInitialize)TurnosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TurnosDataGridView;
        private Button btnAceptar;
        private Button btnEliminarTurno;
    }
}