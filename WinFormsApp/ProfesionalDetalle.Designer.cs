namespace WinFormsApp
{
    partial class ProfesionalDetalle
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
            idLabel = new Label();
            idTextBox = new TextBox();
            cancelarButton = new Button();
            aceptarButton = new Button();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nombreTextBox = new TextBox();
            contraseniaTextBox = new TextBox();
            emailTextBox = new TextBox();
            label4 = new Label();
            matriculaTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(528, 79);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 40;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(528, 96);
            idTextBox.Margin = new Padding(3, 2, 3, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(110, 23);
            idTextBox.TabIndex = 39;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(479, 323);
            cancelarButton.Margin = new Padding(3, 2, 3, 2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(82, 22);
            cancelarButton.TabIndex = 38;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click_1;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(272, 323);
            aceptarButton.Margin = new Padding(3, 2, 3, 2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(82, 22);
            aceptarButton.TabIndex = 37;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(151, 134);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 36;
            label9.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 193);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 31;
            label3.Text = "Apellido y Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 78);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 30;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 48);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 29;
            label1.Text = "Registrar Profesional";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(149, 213);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(356, 23);
            nombreTextBox.TabIndex = 27;
            // 
            // contraseniaTextBox
            // 
            contraseniaTextBox.Location = new Point(149, 153);
            contraseniaTextBox.Margin = new Padding(3, 2, 3, 2);
            contraseniaTextBox.Name = "contraseniaTextBox";
            contraseniaTextBox.Size = new Size(356, 23);
            contraseniaTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(149, 96);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(356, 23);
            emailTextBox.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 254);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 41;
            label4.Text = "Matricula";
            // 
            // matriculaTextBox
            // 
            matriculaTextBox.Location = new Point(149, 272);
            matriculaTextBox.Name = "matriculaTextBox";
            matriculaTextBox.Size = new Size(356, 23);
            matriculaTextBox.TabIndex = 42;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ProfesionalDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(matriculaTextBox);
            Controls.Add(label4);
            Controls.Add(idLabel);
            Controls.Add(idTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombreTextBox);
            Controls.Add(contraseniaTextBox);
            Controls.Add(emailTextBox);
            Name = "ProfesionalDetalle";
            Text = "ProfesionalDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private Button cancelarButton;
        private Button aceptarButton;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nombreTextBox;
        private TextBox contraseniaTextBox;
        private TextBox emailTextBox;
        private Label label4;
        private TextBox matriculaTextBox;
        private ErrorProvider errorProvider;
    }
}