namespace WinFormsApp
{
    partial class AgregarObraSocialProfesional
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dvgObrasSociales = new DataGridView();
            btnCancelar = new Button();
            btnAceptar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dvgObrasSociales
            // 
            dvgObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgObrasSociales.Dock = DockStyle.Top;
            dvgObrasSociales.Location = new Point(0, 0);
            dvgObrasSociales.Name = "dvgObrasSociales";
            dvgObrasSociales.ReadOnly = true;
            dvgObrasSociales.RowHeadersWidth = 51;
            dvgObrasSociales.Size = new Size(800, 267);
            dvgObrasSociales.TabIndex = 3;
            dvgObrasSociales.CellContentClick += dvgObrasSociales_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(153, 48);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.BackColor = Color.FromArgb(255, 255, 128);
            btnAceptar.Location = new Point(553, 48);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAceptar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 325);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 125);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // AgregarObraSocialProfesional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dvgObrasSociales);
            Name = "AgregarObraSocialProfesional";
            Text = "AgregarObraSocialProfesional";
            Load += AgregarObraSocialProfesional_Load;
            ((System.ComponentModel.ISupportInitialize)dvgObrasSociales).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dvgObrasSociales;
        private Button btnCancelar;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel1;
    }
}