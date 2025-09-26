namespace WinFormsApp
{
    partial class CrearConsultorioForm
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
            label2 = new Label();
            label3 = new Label();
            textUbicacion = new TextBox();
            btnRadioHabilitado = new RadioButton();
            btnRadioDeshabilitado = new RadioButton();
            btnRegistrarConsultorio = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(240, 25);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(292, 30);
            Titulo.TabIndex = 0;
            Titulo.Text = "Registrar Nuevo Consultorio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 158);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 83);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Ubicación";
            // 
            // textUbicacion
            // 
            textUbicacion.Location = new Point(240, 113);
            textUbicacion.Name = "textUbicacion";
            textUbicacion.Size = new Size(292, 23);
            textUbicacion.TabIndex = 3;
            // 
            // btnRadioHabilitado
            // 
            btnRadioHabilitado.AutoSize = true;
            btnRadioHabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioHabilitado.Location = new Point(340, 194);
            btnRadioHabilitado.Name = "btnRadioHabilitado";
            btnRadioHabilitado.Size = new Size(86, 21);
            btnRadioHabilitado.TabIndex = 4;
            btnRadioHabilitado.TabStop = true;
            btnRadioHabilitado.Text = "Habilitado";
            btnRadioHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnRadioDeshabilitado
            // 
            btnRadioDeshabilitado.AutoSize = true;
            btnRadioDeshabilitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRadioDeshabilitado.Location = new Point(340, 229);
            btnRadioDeshabilitado.Name = "btnRadioDeshabilitado";
            btnRadioDeshabilitado.Size = new Size(106, 21);
            btnRadioDeshabilitado.TabIndex = 5;
            btnRadioDeshabilitado.TabStop = true;
            btnRadioDeshabilitado.Text = "Deshabilitado";
            btnRadioDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarConsultorio
            // 
            btnRegistrarConsultorio.BackColor = SystemColors.ActiveCaption;
            btnRegistrarConsultorio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarConsultorio.Location = new Point(445, 304);
            btnRegistrarConsultorio.Name = "btnRegistrarConsultorio";
            btnRegistrarConsultorio.Size = new Size(100, 36);
            btnRegistrarConsultorio.TabIndex = 6;
            btnRegistrarConsultorio.Text = "Registrar";
            btnRegistrarConsultorio.UseVisualStyleBackColor = false;
            btnRegistrarConsultorio.Click += btnRegistrarConsultorio_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(240, 304);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 36);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // CrearConsultorioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarConsultorio);
            Controls.Add(btnRadioDeshabilitado);
            Controls.Add(btnRadioHabilitado);
            Controls.Add(textUbicacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Titulo);
            Name = "CrearConsultorioForm";
            Text = "Registrar Consultorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label label2;
        private Label label3;
        private TextBox textUbicacion;
        private RadioButton btnRadioHabilitado;
        private RadioButton btnRadioDeshabilitado;
        private Button btnRegistrarConsultorio;
        private Button btnVolver;
    }
}