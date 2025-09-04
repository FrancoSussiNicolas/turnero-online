namespace WinFormsApp
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pacienteBtn = new Button();
            profesionalBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // pacienteBtn
            // 
            pacienteBtn.Location = new Point(282, 120);
            pacienteBtn.Margin = new Padding(3, 2, 3, 2);
            pacienteBtn.Name = "pacienteBtn";
            pacienteBtn.Size = new Size(111, 35);
            pacienteBtn.TabIndex = 0;
            pacienteBtn.Text = " Pacientes";
            pacienteBtn.UseVisualStyleBackColor = true;
            pacienteBtn.Click += pacientesBtn_Click;
            // 
            // profesionalBtn
            // 
            profesionalBtn.Location = new Point(282, 168);
            profesionalBtn.Margin = new Padding(3, 2, 3, 2);
            profesionalBtn.Name = "profesionalBtn";
            profesionalBtn.Size = new Size(111, 35);
            profesionalBtn.TabIndex = 1;
            profesionalBtn.Text = "Profesionales";
            profesionalBtn.UseVisualStyleBackColor = true;
            profesionalBtn.Click += profesionalesBtn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(282, 92);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(profesionalBtn);
            Controls.Add(pacienteBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "Menu";
            Load += MenuPrincipal_Load;
            Shown += MenuPrincipal_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button pacienteBtn;
        private Button profesionalBtn;
        private Label label1;
    }
}
