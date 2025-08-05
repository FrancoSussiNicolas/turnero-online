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
            emailTextBox.Location = new Point(145, 91);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(356, 23);
            emailTextBox.TabIndex = 0;
            // 
            // sexoTextBox
            // 
            sexoTextBox.Location = new Point(331, 247);
            sexoTextBox.Margin = new Padding(3, 2, 3, 2);
            sexoTextBox.Name = "sexoTextBox";
            sexoTextBox.Size = new Size(168, 23);
            sexoTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(145, 302);
            telefonoTextBox.Margin = new Padding(3, 2, 3, 2);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(354, 23);
            telefonoTextBox.TabIndex = 3;
            // 
            // fechaNacTextBox
            // 
            fechaNacTextBox.Location = new Point(522, 144);
            fechaNacTextBox.Margin = new Padding(3, 2, 3, 2);
            fechaNacTextBox.Name = "fechaNacTextBox";
            fechaNacTextBox.Size = new Size(116, 23);
            fechaNacTextBox.TabIndex = 4;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(143, 144);
            contraseniaTextBox.Margin = new Padding(3, 2, 3, 2);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(356, 23);
            contraseniaTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(143, 193);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(356, 23);
            nombreTextBox.TabIndex = 6;
            // 
            // dniTextBox
            // 
            dniTextBox.Location = new Point(143, 247);
            dniTextBox.Margin = new Padding(3, 2, 3, 2);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(183, 23);
            dniTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 48);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "Registrar Paciente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 73);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 173);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellido y Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 225);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 12;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 227);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Sexo";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new Point(526, 125);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(103, 15);
            fechaNacLabel.TabIndex = 14;
            fechaNacLabel.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 285);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 15;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(145, 125);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 16;
            label9.Text = "Contraseña";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(274, 350);
            aceptarButton.Margin = new Padding(3, 2, 3, 2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(82, 22);
            aceptarButton.TabIndex = 17;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(481, 350);
            cancelarButton.Margin = new Padding(3, 2, 3, 2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(82, 22);
            cancelarButton.TabIndex = 18;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(522, 90);
            idTextBox.Margin = new Padding(3, 2, 3, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(110, 23);
            idTextBox.TabIndex = 20;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(522, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 21;
            idLabel.Text = "Id";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PacienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 454);
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
            Margin = new Padding(3, 2, 3, 2);
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