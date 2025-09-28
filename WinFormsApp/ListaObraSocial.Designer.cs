namespace WinFormsApp
{
    partial class ListaObraSocial
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
            obraSocialGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarPlanAobra = new Button();
            btnModificarObraSocial = new Button();
            btnAgregarObraSocial = new Button();
            btnEliminarObraSocial = new Button();
            ((System.ComponentModel.ISupportInitialize)obraSocialGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // obraSocialGridView
            // 
            obraSocialGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            obraSocialGridView.Location = new Point(-6, 0);
            obraSocialGridView.Name = "obraSocialGridView";
            obraSocialGridView.ReadOnly = true;
            obraSocialGridView.Size = new Size(804, 162);
            obraSocialGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.23077F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.76923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 348F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.Controls.Add(btnAgregarPlanAobra, 3, 0);
            tableLayoutPanel1.Controls.Add(btnModificarObraSocial, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarObraSocial, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarObraSocial, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tableLayoutPanel1.Size = new Size(1270, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAgregarPlanAobra
            // 
            btnAgregarPlanAobra.Anchor = AnchorStyles.None;
            btnAgregarPlanAobra.AutoSize = true;
            btnAgregarPlanAobra.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarPlanAobra.Location = new Point(1075, 12);
            btnAgregarPlanAobra.Name = "btnAgregarPlanAobra";
            btnAgregarPlanAobra.Size = new Size(93, 36);
            btnAgregarPlanAobra.TabIndex = 5;
            btnAgregarPlanAobra.Text = "Agregar Plan";
            btnAgregarPlanAobra.UseVisualStyleBackColor = false;
            btnAgregarPlanAobra.Click += btnAgregarPlanAobra_Click;
            // 
            // btnModificarObraSocial
            // 
            btnModificarObraSocial.Anchor = AnchorStyles.None;
            btnModificarObraSocial.AutoSize = true;
            btnModificarObraSocial.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarObraSocial.Location = new Point(755, 12);
            btnModificarObraSocial.Name = "btnModificarObraSocial";
            btnModificarObraSocial.Size = new Size(88, 36);
            btnModificarObraSocial.TabIndex = 4;
            btnModificarObraSocial.Text = "Modificar";
            btnModificarObraSocial.UseVisualStyleBackColor = false;
            btnModificarObraSocial.Click += btnModificarObraSocial_Click_1;
            // 
            // btnAgregarObraSocial
            // 
            btnAgregarObraSocial.Anchor = AnchorStyles.None;
            btnAgregarObraSocial.BackColor = SystemColors.ActiveCaption;
            btnAgregarObraSocial.Location = new Point(405, 12);
            btnAgregarObraSocial.Name = "btnAgregarObraSocial";
            btnAgregarObraSocial.Size = new Size(97, 36);
            btnAgregarObraSocial.TabIndex = 3;
            btnAgregarObraSocial.Text = "Agregar";
            btnAgregarObraSocial.UseVisualStyleBackColor = false;
            btnAgregarObraSocial.Click += btnAgregarObraSocial_Click;
            // 
            // btnEliminarObraSocial
            // 
            btnEliminarObraSocial.Anchor = AnchorStyles.None;
            btnEliminarObraSocial.BackColor = Color.IndianRed;
            btnEliminarObraSocial.Location = new Point(93, 12);
            btnEliminarObraSocial.Name = "btnEliminarObraSocial";
            btnEliminarObraSocial.Size = new Size(97, 36);
            btnEliminarObraSocial.TabIndex = 2;
            btnEliminarObraSocial.Text = "Eliminar";
            btnEliminarObraSocial.UseVisualStyleBackColor = false;
            btnEliminarObraSocial.Click += btnEliminarObraSocial_Click;
            // 
            // ListaObraSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(obraSocialGridView);
            Name = "ListaObraSocial";
            Text = "Lista Obra Social";
            ((System.ComponentModel.ISupportInitialize)obraSocialGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView obraSocialGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEliminarObraSocial;
        private Button btnAgregarObraSocial;
        private Button btnModificarObraSocial;
        private Button btnAgregarPlanAobra;
    }
}