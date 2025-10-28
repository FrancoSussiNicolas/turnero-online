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
            planObraSocialGridView.Margin = new Padding(3, 4, 3, 4);
            planObraSocialGridView.Name = "planObraSocialGridView";
            planObraSocialGridView.ReadOnly = true;
            planObraSocialGridView.RowHeadersWidth = 51;
            planObraSocialGridView.Size = new Size(1383, 600);
            planObraSocialGridView.TabIndex = 0;
            planObraSocialGridView.CellFormatting += planObraSocialGridView_CellFormatting;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnModificarPlan, 2, 1);
            tableLayoutPanel1.Controls.Add(btnEliminarPlan, 0, 1);
            tableLayoutPanel1.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPlanPractica, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 467);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1383, 133);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnModificarPlan
            // 
            btnModificarPlan.Anchor = AnchorStyles.None;
            btnModificarPlan.AutoSize = true;
            btnModificarPlan.BackColor = Color.FromArgb(255, 255, 128);
            btnModificarPlan.Location = new Point(1093, 75);
            btnModificarPlan.Margin = new Padding(3, 4, 3, 4);
            btnModificarPlan.Name = "btnModificarPlan";
            btnModificarPlan.Size = new Size(119, 48);
            btnModificarPlan.TabIndex = 4;
            btnModificarPlan.Text = "Modificar";
            btnModificarPlan.UseVisualStyleBackColor = false;
            btnModificarPlan.Click += btnModificarPlan_Click;
            // 
            // btnEliminarPlan
            // 
            btnEliminarPlan.Anchor = AnchorStyles.None;
            btnEliminarPlan.BackColor = Color.IndianRed;
            btnEliminarPlan.Location = new Point(175, 75);
            btnEliminarPlan.Margin = new Padding(3, 4, 3, 4);
            btnEliminarPlan.Name = "btnEliminarPlan";
            btnEliminarPlan.Size = new Size(111, 48);
            btnEliminarPlan.TabIndex = 15;
            btnEliminarPlan.Text = "Eliminar";
            btnEliminarPlan.UseVisualStyleBackColor = false;
            btnEliminarPlan.Click += btnEliminarPlan_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.Location = new Point(175, 11);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 44);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregarPlanPractica
            // 
            btnAgregarPlanPractica.Anchor = AnchorStyles.None;
            btnAgregarPlanPractica.BackColor = SystemColors.ActiveCaption;
            btnAgregarPlanPractica.Location = new Point(1095, 11);
            btnAgregarPlanPractica.Margin = new Padding(3, 4, 3, 4);
            btnAgregarPlanPractica.Name = "btnAgregarPlanPractica";
            btnAgregarPlanPractica.Size = new Size(114, 44);
            btnAgregarPlanPractica.TabIndex = 12;
            btnAgregarPlanPractica.Text = "Agregar";
            btnAgregarPlanPractica.UseVisualStyleBackColor = false;
            btnAgregarPlanPractica.Click += btnAgregarPlanPractica_Click;
            // 
            // ListaPlanObraSocial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1383, 600);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(planObraSocialGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnEliminarPlan;
        private Button btnModificarPlan;
    }
}