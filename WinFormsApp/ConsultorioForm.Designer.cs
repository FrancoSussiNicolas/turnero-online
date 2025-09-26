namespace WinFormsApp
{
    partial class ConsultorioForm
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
            consultoriosGridView = new DataGridView();
            btnEliminarConsultorio = new Button();
            btnAgregarConsultorio = new Button();
            btnModificarConsultorio = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)consultoriosGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // consultoriosGridView
            // 
            consultoriosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultoriosGridView.Location = new Point(96, -10);
            consultoriosGridView.Name = "consultoriosGridView";
            consultoriosGridView.ReadOnly = true;
            consultoriosGridView.Size = new Size(787, 359);
            consultoriosGridView.TabIndex = 0;
            // 
            // btnEliminarConsultorio
            // 
            btnEliminarConsultorio.Anchor = AnchorStyles.None;
            btnEliminarConsultorio.BackColor = Color.IndianRed;
            btnEliminarConsultorio.Location = new Point(167, 7);
            btnEliminarConsultorio.Name = "btnEliminarConsultorio";
            btnEliminarConsultorio.Size = new Size(97, 36);
            btnEliminarConsultorio.TabIndex = 1;
            btnEliminarConsultorio.Text = "Eliminar";
            btnEliminarConsultorio.UseVisualStyleBackColor = false;
            btnEliminarConsultorio.Click += btnEliminarConsultorio_Click;
            // 
            // btnAgregarConsultorio
            // 
            btnAgregarConsultorio.Anchor = AnchorStyles.None;
            btnAgregarConsultorio.BackColor = SystemColors.ActiveCaption;
            btnAgregarConsultorio.Location = new Point(598, 7);
            btnAgregarConsultorio.Name = "btnAgregarConsultorio";
            btnAgregarConsultorio.Size = new Size(97, 36);
            btnAgregarConsultorio.TabIndex = 2;
            btnAgregarConsultorio.Text = "Agregar";
            btnAgregarConsultorio.UseVisualStyleBackColor = false;
            btnAgregarConsultorio.Click += btnAgregarConsultorio_Click;
            // 
            // btnModificarConsultorio
            // 
            btnModificarConsultorio.Anchor = AnchorStyles.None;
            btnModificarConsultorio.AutoSize = true;
            btnModificarConsultorio.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarConsultorio.Location = new Point(1029, 7);
            btnModificarConsultorio.Name = "btnModificarConsultorio";
            btnModificarConsultorio.Size = new Size(97, 36);
            btnModificarConsultorio.TabIndex = 3;
            btnModificarConsultorio.Text = "Modificar";
            btnModificarConsultorio.UseVisualStyleBackColor = false;
            btnModificarConsultorio.Click += btnModificarConsultorio_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnModificarConsultorio, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarConsultorio, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarConsultorio, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1293, 100);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // ConsultorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(consultoriosGridView);
            Name = "ConsultorioForm";
            Text = "Consultorios";
            ((System.ComponentModel.ISupportInitialize)consultoriosGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView consultoriosGridView;
        private Button btnEliminarConsultorio;
        private Button btnAgregarConsultorio;
        private Button btnModificarConsultorio;
        private TableLayoutPanel tableLayoutPanel1;
    }
}