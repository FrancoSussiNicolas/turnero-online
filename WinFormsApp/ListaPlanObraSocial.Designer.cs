namespace WinFormsApp
{
    partial class ListaPlanObraSocial
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
            planObraSocialGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnModificarPlan = new Button();
            btnEliminarPlan = new Button();
            btnVolver = new Button();
            btnAgregarPlanPractica = new Button();
            btnAgregarPlan = new Button();
            ((System.ComponentModel.ISupportInitialize)planObraSocialGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // planObraSocialGridView
            // 
            planObraSocialGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planObraSocialGridView.Dock = DockStyle.Fill;
            planObraSocialGridView.EnableHeadersVisualStyles = false;
            planObraSocialGridView.Location = new Point(0, 0);
            planObraSocialGridView.Name = "planObraSocialGridView";
            planObraSocialGridView.ReadOnly = true;
            planObraSocialGridView.Size = new Size(1210, 450);
            planObraSocialGridView.TabIndex = 0;
            planObraSocialGridView.CellFormatting += planObraSocialGridView_CellFormatting;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 357F));
            tableLayoutPanel1.Controls.Add(btnModificarPlan, 2, 1);
            tableLayoutPanel1.Controls.Add(btnEliminarPlan, 0, 1);
            tableLayoutPanel1.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPlanPractica, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPlan, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1210, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnModificarPlan
            // 
            btnModificarPlan.Anchor = AnchorStyles.None;
            btnModificarPlan.AutoSize = true;
            btnModificarPlan.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarPlan.Location = new Point(979, 57);
            btnModificarPlan.Name = "btnModificarPlan";
            btnModificarPlan.Size = new Size(104, 36);
            btnModificarPlan.TabIndex = 4;
            btnModificarPlan.Text = "Modificar";
            btnModificarPlan.UseVisualStyleBackColor = false;
            btnModificarPlan.Click += btnModificarPlan_Click;
            // 
            // btnEliminarPlan
            // 
            btnEliminarPlan.Anchor = AnchorStyles.None;
            btnEliminarPlan.BackColor = Color.IndianRed;
            btnEliminarPlan.Location = new Point(164, 57);
            btnEliminarPlan.Name = "btnEliminarPlan";
            btnEliminarPlan.Size = new Size(97, 36);
            btnEliminarPlan.TabIndex = 15;
            btnEliminarPlan.Text = "Eliminar";
            btnEliminarPlan.UseVisualStyleBackColor = false;
            btnEliminarPlan.Click += btnEliminarPlan_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.Location = new Point(165, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 33);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregarPlanPractica
            // 
            btnAgregarPlanPractica.Anchor = AnchorStyles.None;
            btnAgregarPlanPractica.BackColor = SystemColors.ActiveCaption;
            btnAgregarPlanPractica.Location = new Point(981, 8);
            btnAgregarPlanPractica.Name = "btnAgregarPlanPractica";
            btnAgregarPlanPractica.Size = new Size(100, 33);
            btnAgregarPlanPractica.TabIndex = 12;
            btnAgregarPlanPractica.Text = "Agregar";
            btnAgregarPlanPractica.UseVisualStyleBackColor = false;
            btnAgregarPlanPractica.Click += btnAgregarPlanPractica_Click;
            // 
            // btnAgregarPlan
            // 
            btnAgregarPlan.Anchor = AnchorStyles.None;
            btnAgregarPlan.BackColor = SystemColors.ActiveCaption;
            btnAgregarPlan.Location = new Point(587, 58);
            btnAgregarPlan.Name = "btnAgregarPlan";
            btnAgregarPlan.Size = new Size(103, 33);
            btnAgregarPlan.TabIndex = 14;
            btnAgregarPlan.Text = "Agregar";
            btnAgregarPlan.UseVisualStyleBackColor = false;
            btnAgregarPlan.Click += btnAgregarPlan_Click;
            // 
            // ListaPlanObraSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1210, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(planObraSocialGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListaPlanObraSocial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista Plan Obra Social";
            ((System.ComponentModel.ISupportInitialize)planObraSocialGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView planObraSocialGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnVolver;
        private Button btnAgregarPlanPractica;
        private Button btnAgregarPlan;
        private Button btnEliminarPlan;
        private Button btnModificarPlan;
    }
}