namespace WinFormsApp
{
    partial class TurnoDetalle
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
            FechaTurno = new DateTimePicker();
            btnRegistrarTurno = new Button();
            btnCancelarTurno = new Button();
            label5 = new Label();
            label6 = new Label();
            comboConsultorio = new ComboBox();
            HoraTurno = new DateTimePicker();
            label7 = new Label();
            h1Turno = new Label();
            SuspendLayout();
            // 
            // FechaTurno
            // 
            FechaTurno.Anchor = AnchorStyles.None;
            FechaTurno.CustomFormat = " dd/MM/yyyy";
            FechaTurno.Format = DateTimePickerFormat.Custom;
            FechaTurno.Location = new Point(263, 183);
            FechaTurno.Margin = new Padding(3, 4, 3, 4);
            FechaTurno.MinDate = new DateTime(2025, 9, 29, 23, 52, 41, 0);
            FechaTurno.Name = "FechaTurno";
            FechaTurno.ShowUpDown = true;
            FechaTurno.Size = new Size(307, 27);
            FechaTurno.TabIndex = 1;
            FechaTurno.Value = new DateTime(2025, 10, 12, 0, 0, 0, 0);
            FechaTurno.ValueChanged += FechaTurno_ValueChanged;
            // 
            // btnRegistrarTurno
            // 
            btnRegistrarTurno.Anchor = AnchorStyles.None;
            btnRegistrarTurno.BackColor = SystemColors.ActiveCaption;
            btnRegistrarTurno.Cursor = Cursors.Hand;
            btnRegistrarTurno.Location = new Point(471, 384);
            btnRegistrarTurno.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarTurno.Name = "btnRegistrarTurno";
            btnRegistrarTurno.Size = new Size(173, 45);
            btnRegistrarTurno.TabIndex = 4;
            btnRegistrarTurno.Text = "Registrar";
            btnRegistrarTurno.UseVisualStyleBackColor = false;
            btnRegistrarTurno.Click += btnRegistrarTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Anchor = AnchorStyles.None;
            btnCancelarTurno.Cursor = Cursors.Hand;
            btnCancelarTurno.Location = new Point(149, 384);
            btnCancelarTurno.Margin = new Padding(3, 4, 3, 4);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(173, 45);
            btnCancelarTurno.TabIndex = 5;
            btnCancelarTurno.Text = "Cancelar";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(149, 184);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 9;
            label5.Text = "Fecha Turno:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(149, 301);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 10;
            label6.Text = "Consultorio:";
            // 
            // comboConsultorio
            // 
            comboConsultorio.Anchor = AnchorStyles.None;
            comboConsultorio.FormattingEnabled = true;
            comboConsultorio.Location = new Point(263, 300);
            comboConsultorio.Margin = new Padding(3, 4, 3, 4);
            comboConsultorio.Name = "comboConsultorio";
            comboConsultorio.Size = new Size(307, 28);
            comboConsultorio.TabIndex = 3;
            // 
            // HoraTurno
            // 
            HoraTurno.Anchor = AnchorStyles.None;
            HoraTurno.CustomFormat = " HH:mm";
            HoraTurno.Format = DateTimePickerFormat.Time;
            HoraTurno.Location = new Point(263, 241);
            HoraTurno.Margin = new Padding(3, 4, 3, 4);
            HoraTurno.MinDate = new DateTime(2025, 9, 29, 0, 0, 0, 0);
            HoraTurno.Name = "HoraTurno";
            HoraTurno.ShowUpDown = true;
            HoraTurno.Size = new Size(307, 27);
            HoraTurno.TabIndex = 2;
            HoraTurno.Value = new DateTime(2025, 9, 29, 0, 0, 0, 0);
            HoraTurno.ValueChanged += HoraTurno_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(149, 243);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 13;
            label7.Text = "Hora Turno:";
            // 
            // h1Turno
            // 
            h1Turno.Anchor = AnchorStyles.None;
            h1Turno.AutoSize = true;
            h1Turno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            h1Turno.Location = new Point(293, 100);
            h1Turno.Name = "h1Turno";
            h1Turno.Size = new Size(215, 37);
            h1Turno.TabIndex = 14;
            h1Turno.Text = "Registrar Turno";
            h1Turno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TurnoDetalle
            // 
            AcceptButton = btnRegistrarTurno;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(h1Turno);
            Controls.Add(label7);
            Controls.Add(HoraTurno);
            Controls.Add(comboConsultorio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancelarTurno);
            Controls.Add(btnRegistrarTurno);
            Controls.Add(FechaTurno);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TurnoDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear Turno";
            Load += TurnoDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker FechaTurno;
        private Button btnRegistrarTurno;
        private Button btnCancelarTurno;
        private Label label5;
        private Label label6;
        private ComboBox comboConsultorio;
        private DateTimePicker HoraTurno;
        private Label label7;
        private Label h1Turno;
    }
}