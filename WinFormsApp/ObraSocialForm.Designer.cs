namespace WinFormsApp
{
    partial class ObraSocialForm
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
            Titulo = new Label();
            label3 = new Label();
            textNombreObraSocial = new TextBox();
            btnRadioDeshabilitado = new RadioButton();
            btnRadioHabilitado = new RadioButton();
            label2 = new Label();
            tableLayoutPanelBotones = new TableLayoutPanel();
            btnRegistrarObraSocial = new Button();
            btnCancelarObraSocial = new Button();
            btnCancelarPlan = new Button();
            lbSusPlanes = new Label();
            planesAsignadosGridView = new DataGridView();
            tableLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planesAsignadosGridView).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(220, 21);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(287, 30);
            Titulo.TabIndex = 0;
            Titulo.Text = "Registrar Nueva Obra Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 91);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // textNombreObraSocial
            // 
            textNombreObraSocial.Location = new Point(220, 131);
            textNombreObraSocial.Name = "textNombreObraSocial";
            textNombreObraSocial.Size = new Size(287, 23);
            textNombreObraSocial.TabIndex = 3;
            // 
            // btnRadioDeshabilitado
            // 
            btnRadioDeshabilitado.AutoSize = true;
            btnRadioDeshabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioDeshabilitado.Location = new Point(296, 256);
            btnRadioDeshabilitado.Name = "btnRadioDeshabilitado";
            btnRadioDeshabilitado.Size = new Size(105, 21);
            btnRadioDeshabilitado.TabIndex = 17;
            btnRadioDeshabilitado.TabStop = true;
            btnRadioDeshabilitado.Text = "Deshabilitada";
            btnRadioDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // btnRadioHabilitado
            // 
            btnRadioHabilitado.AutoSize = true;
            btnRadioHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioHabilitado.Location = new Point(296, 225);
            btnRadioHabilitado.Name = "btnRadioHabilitado";
            btnRadioHabilitado.Size = new Size(85, 21);
            btnRadioHabilitado.TabIndex = 16;
            btnRadioHabilitado.TabStop = true;
            btnRadioHabilitado.Text = "Habilitada";
            btnRadioHabilitado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 190);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 15;
            label2.Text = "Estado";
            // 
            // tableLayoutPanelBotones
            // 
            tableLayoutPanelBotones.ColumnCount = 3;
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.7124672F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.2875328F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 273F));
            tableLayoutPanelBotones.Controls.Add(btnRegistrarObraSocial, 1, 0);
            tableLayoutPanelBotones.Controls.Add(btnCancelarObraSocial, 0, 0);
            tableLayoutPanelBotones.Controls.Add(btnCancelarPlan, 2, 0);
            tableLayoutPanelBotones.Dock = DockStyle.Bottom;
            tableLayoutPanelBotones.Location = new Point(0, 350);
            tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            tableLayoutPanelBotones.RowCount = 2;
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.Size = new Size(807, 100);
            tableLayoutPanelBotones.TabIndex = 18;
            // 
            // btnRegistrarObraSocial
            // 
            btnRegistrarObraSocial.Anchor = AnchorStyles.None;
            btnRegistrarObraSocial.BackColor = SystemColors.ActiveCaption;
            btnRegistrarObraSocial.Location = new Point(299, 4);
            btnRegistrarObraSocial.Name = "btnRegistrarObraSocial";
            btnRegistrarObraSocial.Size = new Size(151, 42);
            btnRegistrarObraSocial.TabIndex = 13;
            btnRegistrarObraSocial.Text = "Registrar";
            btnRegistrarObraSocial.UseVisualStyleBackColor = false;
            // 
            // btnCancelarObraSocial
            // 
            btnCancelarObraSocial.Anchor = AnchorStyles.None;
            btnCancelarObraSocial.Location = new Point(33, 4);
            btnCancelarObraSocial.Name = "btnCancelarObraSocial";
            btnCancelarObraSocial.Size = new Size(151, 42);
            btnCancelarObraSocial.TabIndex = 12;
            btnCancelarObraSocial.Text = "Cancelar";
            btnCancelarObraSocial.UseVisualStyleBackColor = true;
            btnCancelarObraSocial.Click += btnCancelarObraSocial_Click_1;
            // 
            // btnCancelarPlan
            // 
            btnCancelarPlan.Anchor = AnchorStyles.None;
            btnCancelarPlan.BackColor = Color.IndianRed;
            btnCancelarPlan.Location = new Point(608, 4);
            btnCancelarPlan.Name = "btnCancelarPlan";
            btnCancelarPlan.Size = new Size(123, 42);
            btnCancelarPlan.TabIndex = 21;
            btnCancelarPlan.Text = "Cancelar Plan";
            btnCancelarPlan.UseVisualStyleBackColor = false;
            btnCancelarPlan.Visible = false;
            // 
            // lbSusPlanes
            // 
            lbSusPlanes.AutoSize = true;
            lbSusPlanes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSusPlanes.Location = new Point(534, 91);
            lbSusPlanes.Name = "lbSusPlanes";
            lbSusPlanes.Size = new Size(82, 20);
            lbSusPlanes.TabIndex = 20;
            lbSusPlanes.Text = "Sus Planes";
            lbSusPlanes.Visible = false;
            // 
            // planesAsignadosGridView
            // 
            planesAsignadosGridView.BackgroundColor = SystemColors.Control;
            planesAsignadosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planesAsignadosGridView.Location = new Point(534, 122);
            planesAsignadosGridView.Name = "planesAsignadosGridView";
            planesAsignadosGridView.ReadOnly = true;
            planesAsignadosGridView.Size = new Size(261, 136);
            planesAsignadosGridView.TabIndex = 19;
            planesAsignadosGridView.Visible = false;
            // 
            // ObraSocialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(lbSusPlanes);
            Controls.Add(planesAsignadosGridView);
            Controls.Add(tableLayoutPanelBotones);
            Controls.Add(btnRadioDeshabilitado);
            Controls.Add(btnRadioHabilitado);
            Controls.Add(label2);
            Controls.Add(textNombreObraSocial);
            Controls.Add(label3);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ObraSocialForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Obra Social";
            tableLayoutPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)planesAsignadosGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label label3;
        private TextBox textNombreObraSocial;
        private RadioButton btnRadioDeshabilitado;
        private RadioButton btnRadioHabilitado;
        private Label label2;
        private TableLayoutPanel tableLayoutPanelBotones;
        private Button btnCancelarObraSocial;
        private Button btnRegistrarObraSocial;
        private Label lbSusPlanes;
        private DataGridView planesAsignadosGridView;
        private Button btnCancelarPlan;
    }
}