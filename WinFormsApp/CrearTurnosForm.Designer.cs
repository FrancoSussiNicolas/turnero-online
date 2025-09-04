namespace WinFormsApp
{
    partial class CrearTurnosForm
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
            FechaTurno = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnRegistrarTurno = new Button();
            btnCancelarTurno = new Button();
            label5 = new Label();
            label6 = new Label();
            comboConsultorio = new ComboBox();
            HoraTurno = new DateTimePicker();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // FechaTurno
            // 
            FechaTurno.CustomFormat = " dd/MM/yyyy";
            FechaTurno.Format = DateTimePickerFormat.Custom;
            FechaTurno.Location = new Point(305, 62);
            FechaTurno.MinDate = new DateTime(2025, 9, 4, 17, 55, 8, 0);
            FechaTurno.Name = "FechaTurno";
            FechaTurno.ShowUpDown = true;
            FechaTurno.Size = new Size(269, 23);
            FechaTurno.TabIndex = 2;
            FechaTurno.Value = new DateTime(2025, 9, 4, 17, 55, 8, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 24);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(305, 11);
            label4.MaximumSize = new Size(0, 400);
            label4.Name = "label4";
            label4.Size = new Size(243, 32);
            label4.TabIndex = 4;
            label4.Text = "Registrar Turno";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarTurno
            // 
            btnRegistrarTurno.BackColor = SystemColors.ActiveCaption;
            btnRegistrarTurno.Location = new Point(205, 203);
            btnRegistrarTurno.Name = "btnRegistrarTurno";
            btnRegistrarTurno.Size = new Size(151, 34);
            btnRegistrarTurno.TabIndex = 5;
            btnRegistrarTurno.Text = "Registrar";
            btnRegistrarTurno.UseVisualStyleBackColor = false;
            btnRegistrarTurno.Click += btnRegistrarTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Location = new Point(459, 203);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(151, 34);
            btnCancelarTurno.TabIndex = 6;
            btnCancelarTurno.Text = "Cancelar";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(205, 62);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 9;
            label5.Text = "Fecha Turno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(205, 154);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 10;
            label6.Text = "Consultorio:";
            // 
            // comboConsultorio
            // 
            comboConsultorio.FormattingEnabled = true;
            comboConsultorio.Location = new Point(305, 150);
            comboConsultorio.Name = "comboConsultorio";
            comboConsultorio.Size = new Size(269, 23);
            comboConsultorio.TabIndex = 11;
            comboConsultorio.SelectedIndexChanged += comboConsultorio_SelectedIndexChanged;
            // 
            // HoraTurno
            // 
            HoraTurno.CustomFormat = " HH:mm";
            HoraTurno.Enabled = false;
            HoraTurno.Format = DateTimePickerFormat.Custom;
            HoraTurno.Location = new Point(305, 106);
            HoraTurno.MinDate = new DateTime(2025, 9, 4, 17, 55, 8, 0);
            HoraTurno.Name = "HoraTurno";
            HoraTurno.ShowUpDown = true;
            HoraTurno.Size = new Size(269, 23);
            HoraTurno.TabIndex = 12;
            HoraTurno.Value = new DateTime(2025, 9, 4, 17, 55, 8, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(205, 110);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 13;
            label7.Text = "Hora Turno:";
            // 
            // CrearTurnosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 260);
            Controls.Add(label7);
            Controls.Add(HoraTurno);
            Controls.Add(comboConsultorio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancelarTurno);
            Controls.Add(btnRegistrarTurno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FechaTurno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearTurnosForm";
            Text = "Crear Turno";
            Load += CrearTurnosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker FechaTurno;
        private Label label3;
        private Label label4;
        private Button btnRegistrarTurno;
        private Button btnCancelarTurno;
        private Label label5;
        private Label label6;
        private ComboBox comboConsultorio;
        private DateTimePicker HoraTurno;
        private Label label7;
    }
}