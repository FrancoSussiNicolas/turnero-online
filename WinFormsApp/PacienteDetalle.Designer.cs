namespace WinFormsApp
{
    partial class PacienteDetalle
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
            emailTextBox = new TextBox();
            sexoTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            fechaNacTextBox = new TextBox();
            contraseniaTextBox = new TextBox();
            nombreTextBox = new TextBox();
            dniTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            fechaNacLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            idTextBox = new TextBox();
            idLabel = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(79, 82);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(406, 27);
            emailTextBox.TabIndex = 0;
            // 
            // sexoTextBox
            // 
            sexoTextBox.Location = new Point(294, 278);
            sexoTextBox.Name = "sexoTextBox";
            sexoTextBox.Size = new Size(191, 27);
            sexoTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(81, 351);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(404, 27);
            telefonoTextBox.TabIndex = 3;
            // 
            // fechaNacTextBox
            // 
            fechaNacTextBox.Location = new Point(512, 140);
            fechaNacTextBox.Name = "fechaNacTextBox";
            fechaNacTextBox.Size = new Size(132, 27);
            fechaNacTextBox.TabIndex = 4;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(79, 140);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(406, 27);
            contraseniaTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(79, 206);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(406, 27);
            nombreTextBox.TabIndex = 6;
            // 
            // dniTextBox
            // 
            dniTextBox.Location = new Point(79, 278);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(209, 27);
            dniTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "Registrar Paciente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 59);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 179);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido y Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 248);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 250);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 13;
            label6.Text = "Sexo";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new Point(516, 114);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(128, 20);
            fechaNacLabel.TabIndex = 14;
            fechaNacLabel.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 328);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 15;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 112);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 16;
            label9.Text = "Contraseña";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(228, 415);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(94, 29);
            aceptarButton.TabIndex = 17;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(465, 415);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(94, 29);
            cancelarButton.TabIndex = 18;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(516, 82);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 20;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(516, 59);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 20);
            idLabel.TabIndex = 21;
            idLabel.Text = "Id:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PacienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(fechaNacLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dniTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(contraseniaTextBox);
            Controls.Add(fechaNacTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(sexoTextBox);
            Controls.Add(emailTextBox);
            Name = "PacienteDetalle";
            Text = "PacienteDetalle";
            Load += PacienteDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTextBox;
        private TextBox sexoTextBox;
        private TextBox telefonoTextBox;
        private TextBox fechaNacTextBox;
        private TextBox contraseniaTextBox;
        private TextBox nombreTextBox;
        private TextBox dniTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label fechaNacLabel;
        private Label label8;
        private Label label9;
        private Button aceptarButton;
        private Button cancelarButton;
        private TextBox idTextBox;
        private Label idLabel;
        private ErrorProvider errorProvider;
    }
}