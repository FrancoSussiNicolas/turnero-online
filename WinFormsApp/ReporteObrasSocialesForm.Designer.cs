using System.Drawing;
using System.Windows.Forms;
using ScottPlot.WinForms;

namespace WinFormsApp
{
    partial class ReporteObrasSocialesForm
    {
        private System.ComponentModel.IContainer components = null;

        private FormsPlot formsPlot;
        private DataGridView dgvDatos;
        private Button btnCargar;
        private Button btnExportarPDF;
        private Label lblFecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFecha = new Label();
            btnCargar = new Button();
            btnExportarPDF = new Button();
            formsPlot = new FormsPlot();
            dgvDatos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(49, 68);
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
            btnCargar.Location = new Point(642, 58);
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
            btnExportarPDF.Location = new Point(810, 58);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(150, 35);
            btnExportarPDF.TabIndex = 2;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // formsPlot
            // 
            formsPlot.Anchor = AnchorStyles.None;
            formsPlot.DisplayScale = 1F;
            formsPlot.Location = new Point(20, 100);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(950, 350);
            formsPlot.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.Anchor = AnchorStyles.None;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.ColumnHeadersHeight = 29;
            dgvDatos.Location = new Point(20, 510);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(950, 180);
            dgvDatos.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(49, 22);
            label1.Name = "label1";
            label1.Size = new Size(468, 30);
            label1.TabIndex = 5;
            label1.Text = "Reporte: cantidad de pacientes por obra social";
            // 
            // ReporteObrasSocialesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(formsPlot);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnCargar);
            Controls.Add(lblFecha);
            Name = "ReporteObrasSocialesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Pacientes por Obra Social";
            WindowState = FormWindowState.Maximized;
            Load += ReporteObrasSocialesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}