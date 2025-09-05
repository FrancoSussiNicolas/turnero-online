namespace WinFormsApp
{
    partial class CrearEspecialidad
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
            label1 = new Label();
            label2 = new Label();
            inputDescripcion = new TextBox();
            btnCancelarTurno = new Button();
            btnRegistrarTurno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Descripión:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(221, 37);
            label2.TabIndex = 1;
            label2.Text = "Crear Especialidad";
            // 
            // inputDescripcion
            // 
            inputDescripcion.Location = new Point(143, 108);
            inputDescripcion.Multiline = true;
            inputDescripcion.Name = "inputDescripcion";
            inputDescripcion.Size = new Size(461, 114);
            inputDescripcion.TabIndex = 2;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Location = new Point(431, 265);
            btnCancelarTurno.Margin = new Padding(3, 4, 3, 4);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(173, 45);
            btnCancelarTurno.TabIndex = 8;
            btnCancelarTurno.Text = "Cancelar";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // btnRegistrarTurno
            // 
            btnRegistrarTurno.BackColor = SystemColors.ActiveCaption;
            btnRegistrarTurno.Location = new Point(143, 265);
            btnRegistrarTurno.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarTurno.Name = "btnRegistrarTurno";
            btnRegistrarTurno.Size = new Size(173, 45);
            btnRegistrarTurno.TabIndex = 7;
            btnRegistrarTurno.Text = "Registrar";
            btnRegistrarTurno.UseVisualStyleBackColor = false;
            btnRegistrarTurno.Click += btnRegistrarTurno_Click;
            // 
            // CrearEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarTurno);
            Controls.Add(btnRegistrarTurno);
            Controls.Add(inputDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearEspecialidad";
            Text = "CrearEspecialidad";
            WindowState = FormWindowState.Maximized;
            Load += CrearEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputDescripcion;
        private Button btnCancelarTurno;
        private Button btnRegistrarTurno;
    }
}