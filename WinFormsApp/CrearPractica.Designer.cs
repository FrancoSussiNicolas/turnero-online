namespace WinFormsApp
{
    partial class CrearPractica
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
            label1 = new Label();
            label2 = new Label();
            textNombrePractica = new TextBox();
            textDescripcionPractica = new TextBox();
            btnCancelarPractica = new Button();
            btnRegistrarPractica = new Button();
            btnRadioDeshabilitado = new RadioButton();
            btnRadioHabilitado = new RadioButton();
            label3 = new Label();
            planesAsignadosGridView = new DataGridView();
            tableLayoutPanelBotones = new TableLayoutPanel();
            btnCancelarPlan = new Button();
            lbSusPlanes = new Label();
            ((System.ComponentModel.ISupportInitialize)planesAsignadosGridView).BeginInit();
            tableLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(468, 22);
            Titulo.MaximumSize = new Size(0, 400);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(404, 32);
            Titulo.TabIndex = 5;
            Titulo.Text = "Registrar Nueva Práctica";
            Titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 69);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 151);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // textNombrePractica
            // 
            textNombrePractica.Location = new Point(340, 108);
            textNombrePractica.Name = "textNombrePractica";
            textNombrePractica.Size = new Size(393, 23);
            textNombrePractica.TabIndex = 8;
            // 
            // textDescripcionPractica
            // 
            textDescripcionPractica.Location = new Point(340, 174);
            textDescripcionPractica.Multiline = true;
            textDescripcionPractica.Name = "textDescripcionPractica";
            textDescripcionPractica.Size = new Size(393, 70);
            textDescripcionPractica.TabIndex = 9;
            // 
            // btnCancelarPractica
            // 
            btnCancelarPractica.Anchor = AnchorStyles.None;
            btnCancelarPractica.Location = new Point(135, 4);
            btnCancelarPractica.Name = "btnCancelarPractica";
            btnCancelarPractica.Size = new Size(151, 42);
            btnCancelarPractica.TabIndex = 11;
            btnCancelarPractica.Text = "Cancelar";
            btnCancelarPractica.UseVisualStyleBackColor = true;
            btnCancelarPractica.Click += btnCancelarPractica_Click;
            // 
            // btnRegistrarPractica
            // 
            btnRegistrarPractica.Anchor = AnchorStyles.None;
            btnRegistrarPractica.BackColor = SystemColors.ActiveCaption;
            btnRegistrarPractica.Location = new Point(556, 4);
            btnRegistrarPractica.Name = "btnRegistrarPractica";
            btnRegistrarPractica.Size = new Size(151, 42);
            btnRegistrarPractica.TabIndex = 10;
            btnRegistrarPractica.Text = "Registrar";
            btnRegistrarPractica.UseVisualStyleBackColor = false;
            btnRegistrarPractica.Click += btnRegistrarPractica_Click;
            // 
            // btnRadioDeshabilitado
            // 
            btnRadioDeshabilitado.AutoSize = true;
            btnRadioDeshabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioDeshabilitado.Location = new Point(480, 313);
            btnRadioDeshabilitado.Name = "btnRadioDeshabilitado";
            btnRadioDeshabilitado.Size = new Size(105, 21);
            btnRadioDeshabilitado.TabIndex = 14;
            btnRadioDeshabilitado.TabStop = true;
            btnRadioDeshabilitado.Text = "Deshabilitada";
            btnRadioDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // btnRadioHabilitado
            // 
            btnRadioHabilitado.AutoSize = true;
            btnRadioHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioHabilitado.Location = new Point(480, 282);
            btnRadioHabilitado.Name = "btnRadioHabilitado";
            btnRadioHabilitado.Size = new Size(85, 21);
            btnRadioHabilitado.TabIndex = 13;
            btnRadioHabilitado.TabStop = true;
            btnRadioHabilitado.Text = "Habilitada";
            btnRadioHabilitado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(351, 268);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Estado";
            // 
            // planesAsignadosGridView
            // 
            planesAsignadosGridView.BackgroundColor = SystemColors.Control;
            planesAsignadosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planesAsignadosGridView.Location = new Point(777, 108);
            planesAsignadosGridView.Name = "planesAsignadosGridView";
            planesAsignadosGridView.ReadOnly = true;
            planesAsignadosGridView.Size = new Size(403, 136);
            planesAsignadosGridView.TabIndex = 15;
            planesAsignadosGridView.Visible = false;
            // 
            // tableLayoutPanelBotones
            // 
            tableLayoutPanelBotones.ColumnCount = 3;
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 380F));
            tableLayoutPanelBotones.Controls.Add(btnCancelarPlan, 2, 0);
            tableLayoutPanelBotones.Controls.Add(btnRegistrarPractica, 1, 0);
            tableLayoutPanelBotones.Controls.Add(btnCancelarPractica, 0, 0);
            tableLayoutPanelBotones.Dock = DockStyle.Bottom;
            tableLayoutPanelBotones.Location = new Point(0, 350);
            tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            tableLayoutPanelBotones.RowCount = 2;
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBotones.Size = new Size(1223, 100);
            tableLayoutPanelBotones.TabIndex = 16;
            // 
            // btnCancelarPlan
            // 
            btnCancelarPlan.Anchor = AnchorStyles.None;
            btnCancelarPlan.BackColor = Color.IndianRed;
            btnCancelarPlan.Location = new Point(960, 4);
            btnCancelarPlan.Name = "btnCancelarPlan";
            btnCancelarPlan.Size = new Size(145, 42);
            btnCancelarPlan.TabIndex = 12;
            btnCancelarPlan.Text = "Cancelar Plan";
            btnCancelarPlan.UseVisualStyleBackColor = false;
            btnCancelarPlan.Visible = false;
            btnCancelarPlan.Click += btnCancelarPlan_Click;
            // 
            // lbSusPlanes
            // 
            lbSusPlanes.AutoSize = true;
            lbSusPlanes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSusPlanes.Location = new Point(777, 72);
            lbSusPlanes.Name = "lbSusPlanes";
            lbSusPlanes.Size = new Size(82, 20);
            lbSusPlanes.TabIndex = 17;
            lbSusPlanes.Text = "Sus Planes";
            lbSusPlanes.Visible = false;
            // 
            // CrearPractica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 450);
            Controls.Add(lbSusPlanes);
            Controls.Add(tableLayoutPanelBotones);
            Controls.Add(planesAsignadosGridView);
            Controls.Add(btnRadioDeshabilitado);
            Controls.Add(btnRadioHabilitado);
            Controls.Add(label3);
            Controls.Add(textDescripcionPractica);
            Controls.Add(textNombrePractica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearPractica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear Práctica";
            ((System.ComponentModel.ISupportInitialize)planesAsignadosGridView).EndInit();
            tableLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label label1;
        private Label label2;
        private TextBox textNombrePractica;
        private TextBox textDescripcionPractica;
        private Button btnCancelarPractica;
        private Button btnRegistrarPractica;
        private RadioButton btnRadioDeshabilitado;
        private RadioButton btnRadioHabilitado;
        private Label label3;
        private DataGridView planesAsignadosGridView;
        private TableLayoutPanel tableLayoutPanelBotones;
        private Button btnCancelarPlan;
        private Label lbSusPlanes;
    }
}