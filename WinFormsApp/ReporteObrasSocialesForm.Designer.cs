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
            lblFecha.Location = new Point(56, 90);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(457, 33);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha de generación: --";
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.None;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.Font = new Font("Segoe UI", 10F);
            btnCargar.Location = new Point(734, 78);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(171, 47);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Reporte";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Anchor = AnchorStyles.None;
            btnExportarPDF.Cursor = Cursors.Hand;
            btnExportarPDF.Enabled = false;
            btnExportarPDF.Font = new Font("Segoe UI", 10F);
            btnExportarPDF.Location = new Point(926, 78);
            btnExportarPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(171, 47);
            btnExportarPDF.TabIndex = 2;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // formsPlot
            // 
            formsPlot.Anchor = AnchorStyles.None;
            formsPlot.DisplayScale = 1F;
            formsPlot.Location = new Point(23, 133);
            formsPlot.Margin = new Padding(3, 4, 3, 4);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(1086, 467);
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
            dgvDatos.Location = new Point(23, 680);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1086, 240);
            dgvDatos.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(614, 37);
            label1.TabIndex = 5;
            label1.Text = "Reporte: cantidad de pacientes por obra social";
            // 
            // ReporteObrasSocialesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 933);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(formsPlot);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnCargar);
            Controls.Add(lblFecha);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReporteObrasSocialesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte: Pacientes por Obra Social";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}