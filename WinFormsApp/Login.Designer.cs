namespace WinFormsApp
{
    partial class Login
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
            lnkOlvidaPass = new LinkLabel();
            txtPass = new TextBox();
            txtMail = new TextBox();
            btnIngresar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            errorProvider = new ErrorProvider(components);
            checkBoxPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Location = new Point(138, 212);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(119, 15);
            lnkOlvidaPass.TabIndex = 13;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            lnkOlvidaPass.LinkClicked += lnkOlvidaPass_LinkClicked;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(161, 167);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(187, 23);
            txtPass.TabIndex = 12;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(161, 128);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(187, 23);
            txtMail.TabIndex = 11;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(146, 255);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(104, 30);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 170);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 131);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 8;
            label2.Text = "Correo Electrónico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 71);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 7;
            label1.Text = "¡Bienvenido al Sistema!\r\nPor favor ingrese sus credenciales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Location = new Point(119, 169);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(42, 19);
            checkBoxPassword.TabIndex = 14;
            checkBoxPassword.Text = "Ver";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // Login
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 361);
            Controls.Add(checkBoxPassword);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(txtPass);
            Controls.Add(txtMail);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkOlvidaPass;
        private TextBox txtPass;
        private TextBox txtMail;
        private Button btnIngresar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ErrorProvider errorProvider;
        private CheckBox checkBoxPassword;
    }
}