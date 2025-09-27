namespace WinFormsApp
{
    partial class CrearPlanObraSocial
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
            btnVolver = new Button();
            btnRegistrarPlan = new Button();
            btnRadioDeshabilitado = new RadioButton();
            btnRadioHabilitado = new RadioButton();
            label2 = new Label();
            Titulo = new Label();
            textDescripcionPlan = new TextBox();
            textNombrePlan = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(237, 392);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 36);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrarPlan
            // 
            btnRegistrarPlan.BackColor = SystemColors.ActiveCaption;
            btnRegistrarPlan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarPlan.Location = new Point(530, 392);
            btnRegistrarPlan.Name = "btnRegistrarPlan";
            btnRegistrarPlan.Size = new Size(100, 36);
            btnRegistrarPlan.TabIndex = 14;
            btnRegistrarPlan.Text = "Registrar";
            btnRegistrarPlan.UseVisualStyleBackColor = false;
            btnRegistrarPlan.Click += btnRegistrarPlan_Click;
            // 
            // btnRadioDeshabilitado
            // 
            btnRadioDeshabilitado.AutoSize = true;
            btnRadioDeshabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioDeshabilitado.Location = new Point(387, 336);
            btnRadioDeshabilitado.Name = "btnRadioDeshabilitado";
            btnRadioDeshabilitado.Size = new Size(106, 21);
            btnRadioDeshabilitado.TabIndex = 13;
            btnRadioDeshabilitado.TabStop = true;
            btnRadioDeshabilitado.Text = "Deshabilitado";
            btnRadioDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // btnRadioHabilitado
            // 
            btnRadioHabilitado.AutoSize = true;
            btnRadioHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioHabilitado.Location = new Point(387, 301);
            btnRadioHabilitado.Name = "btnRadioHabilitado";
            btnRadioHabilitado.Size = new Size(86, 21);
            btnRadioHabilitado.TabIndex = 12;
            btnRadioHabilitado.TabStop = true;
            btnRadioHabilitado.Text = "Habilitado";
            btnRadioHabilitado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 278);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Estado";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(320, 30);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(220, 30);
            Titulo.TabIndex = 8;
            Titulo.Text = "Registrar Nuevo Plan";
            // 
            // textDescripcionPlan
            // 
            textDescripcionPlan.Location = new Point(237, 191);
            textDescripcionPlan.Multiline = true;
            textDescripcionPlan.Name = "textDescripcionPlan";
            textDescripcionPlan.Size = new Size(393, 70);
            textDescripcionPlan.TabIndex = 19;
            // 
            // textNombrePlan
            // 
            textNombrePlan.Location = new Point(237, 124);
            textNombrePlan.Name = "textNombrePlan";
            textNombrePlan.Size = new Size(393, 23);
            textNombrePlan.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 168);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 17;
            label1.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(237, 82);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // CrearPlanObraSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textDescripcionPlan);
            Controls.Add(textNombrePlan);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarPlan);
            Controls.Add(btnRadioDeshabilitado);
            Controls.Add(btnRadioHabilitado);
            Controls.Add(label2);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearPlanObraSocial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear Plan Obra Social";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnRegistrarPlan;
        private RadioButton btnRadioDeshabilitado;
        private RadioButton btnRadioHabilitado;
        private Label label2;
        private Label Titulo;
        private TextBox textDescripcionPlan;
        private TextBox textNombrePlan;
        private Label label1;
        private Label label4;
    }
}