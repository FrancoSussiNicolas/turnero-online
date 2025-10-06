namespace WinFormsApp
{
    partial class PerfilProfesional
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnActualizar = new Button();
            label2 = new Label();
            txtApellidoNombre = new TextBox();
            label3 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtMatricula = new TextBox();
            label6 = new Label();
            txtEspecialidad = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 37);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "Perfil de Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = SystemColors.AppWorkspace;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(206, 365);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(99, 38);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(111, 92);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido y Nombre";
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Anchor = AnchorStyles.None;
            txtApellidoNombre.Location = new Point(112, 110);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(290, 23);
            txtApellidoNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(111, 155);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo Electrónico";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(111, 173);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(291, 23);
            txtMail.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(111, 218);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.None;
            txtMatricula.Location = new Point(111, 236);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(291, 23);
            txtMatricula.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(111, 281);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 10;
            label6.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Anchor = AnchorStyles.None;
            txtEspecialidad.Enabled = false;
            txtEspecialidad.Location = new Point(111, 299);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(291, 23);
            txtEspecialidad.TabIndex = 11;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PerfilProfesional
            // 
            AcceptButton = btnActualizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 446);
            Controls.Add(txtEspecialidad);
            Controls.Add(label6);
            Controls.Add(txtMatricula);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtApellidoNombre);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Name = "PerfilProfesional";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil de Profesional";
            Shown += PerfilProfesional_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnActualizar;
        private Label label2;
        private TextBox txtApellidoNombre;
        private Label label3;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtMatricula;
        private Label label6;
        private TextBox txtEspecialidad;
        private ErrorProvider errorProvider;
    }
}