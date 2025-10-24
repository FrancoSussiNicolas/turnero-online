using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class ReporteEspecialidadesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvDatos;
        private Button btnCargar;
        private Button btnExportarPDF;
        private Label lblFecha;
        private Label lblResumen;

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
            lblFecha = new Label();
            btnCargar = new Button();
            btnExportarPDF = new Button();
            dgvDatos = new DataGridView();
            lblResumen = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(20, 68);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(400, 25);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha de generación: --";
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.Font = new Font("Segoe UI", 10F);
            btnCargar.Location = new Point(560, 58);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(150, 35);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Recargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Anchor = AnchorStyles.None;
            btnExportarPDF.Cursor = Cursors.Hand;
            btnExportarPDF.Enabled = false;
            btnExportarPDF.Font = new Font("Segoe UI", 10F);
            btnExportarPDF.Location = new Point(720, 58);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(150, 35);
            btnExportarPDF.TabIndex = 2;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.Anchor = AnchorStyles.None;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.ColumnHeadersHeight = 35;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.Font = new Font("Segoe UI", 10F);
            dgvDatos.Location = new Point(20, 100);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 30;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(850, 350);
            dgvDatos.TabIndex = 3;
            // 
            // lblResumen
            // 
            lblResumen.Anchor = AnchorStyles.None;
            lblResumen.BackColor = Color.FromArgb(236, 240, 241);
            lblResumen.BorderStyle = BorderStyle.FixedSingle;
            lblResumen.Font = new Font("Segoe UI", 10F);
            lblResumen.Location = new Point(20, 460);
            lblResumen.Name = "lblResumen";
            lblResumen.Padding = new Padding(10, 10, 10, 10);
            lblResumen.Size = new Size(850, 134);
            lblResumen.TabIndex = 4;
            lblResumen.Text = "Cargue el reporte para ver el resumen estadístico";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(468, 30);
            label1.TabIndex = 6;
            label1.Text = "Reporte: cantidad de pacientes por obra social";
            // 
            // ReporteEspecialidadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(label1);
            Controls.Add(lblResumen);
            Controls.Add(dgvDatos);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnCargar);
            Controls.Add(lblFecha);
            Name = "ReporteEspecialidadesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Profesionales por Especialidad";
            WindowState = FormWindowState.Maximized;
            Load += ReporteEspecialidadesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}