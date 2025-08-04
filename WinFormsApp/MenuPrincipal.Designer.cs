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
            pacienteBtn.Location = new Point(322, 160);
            pacienteBtn.Name = "pacienteBtn";
            pacienteBtn.Size = new Size(127, 47);
            pacienteBtn.TabIndex = 0;
            pacienteBtn.Text = " Pacientes";
            pacienteBtn.UseVisualStyleBackColor = true;
            pacienteBtn.Click += pacientesBtn_Click;
            // 
            // profesionalBtn
            // 
            profesionalBtn.Location = new Point(322, 224);
            profesionalBtn.Name = "profesionalBtn";
            profesionalBtn.Size = new Size(127, 47);
            profesionalBtn.TabIndex = 1;
            profesionalBtn.Text = "Profesionales";
            profesionalBtn.UseVisualStyleBackColor = true;
            profesionalBtn.Click += profesionalesBtn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(322, 123);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(profesionalBtn);
            Controls.Add(pacienteBtn);
            Name = "MenuPrincipal";
            Text = "Menu";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button pacienteBtn;
        private Button profesionalBtn;
        private Label label1;
    }
}
