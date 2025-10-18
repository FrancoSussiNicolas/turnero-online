namespace WinFormsApp
{
    partial class CrearProfesional
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancelar = new Button();
            textNombreCompleto = new TextBox();
            comboEspecialidad = new ComboBox();
            label3 = new Label();
            textEmail = new TextBox();
            textContrasenia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textMatricula = new TextBox();
            btnRegistrarProfesional = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(328, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 0;
            label1.Text = "Registrar Profesional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 81);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre y Apellido";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRegistrarProfesional, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 380);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 70);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = SystemColors.ActiveBorder;
            btnCancelar.Location = new Point(145, 16);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textNombreCompleto
            // 
            textNombreCompleto.Location = new Point(252, 112);
            textNombreCompleto.Name = "textNombreCompleto";
            textNombreCompleto.Size = new Size(243, 23);
            textNombreCompleto.TabIndex = 3;
            // 
            // comboEspecialidad
            // 
            comboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEspecialidad.FormattingEnabled = true;
            comboEspecialidad.Location = new Point(531, 278);
            comboEspecialidad.Name = "comboEspecialidad";
            comboEspecialidad.Size = new Size(167, 23);
            comboEspecialidad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 151);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(252, 187);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(243, 23);
            textEmail.TabIndex = 6;
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(252, 278);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.Size = new Size(243, 23);
            textContrasenia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(254, 241);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(531, 241);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 9;
            label5.Text = "Especialidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(531, 151);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 10;
            label6.Text = "Matricula";
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(531, 187);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(167, 23);
            textMatricula.TabIndex = 11;
            // 
            // btnRegistrarProfesional
            // 
            btnRegistrarProfesional.Anchor = AnchorStyles.None;
            btnRegistrarProfesional.BackColor = SystemColors.ActiveCaption;
            btnRegistrarProfesional.Location = new Point(545, 16);
            btnRegistrarProfesional.Name = "btnRegistrarProfesional";
            btnRegistrarProfesional.Size = new Size(110, 37);
            btnRegistrarProfesional.TabIndex = 8;
            btnRegistrarProfesional.Text = "Registrar";
            btnRegistrarProfesional.UseVisualStyleBackColor = false;
            btnRegistrarProfesional.Click += btnRegistrarProfesional_Click;
            // 
            // CrearProfesional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textMatricula);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textContrasenia);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(comboEspecialidad);
            Controls.Add(textNombreCompleto);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearProfesional";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Profesional";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textNombreCompleto;
        private ComboBox comboEspecialidad;
        private Button btnCancelar;
        private Label label3;
        private TextBox textEmail;
        private TextBox textContrasenia;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textMatricula;
        private Button btnRegistrarProfesional;
    }
}