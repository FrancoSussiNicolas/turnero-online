namespace DesktopApp
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
            pacienteBtn.Location = new Point(307, 137);
            pacienteBtn.Name = "pacienteBtn";
            pacienteBtn.Size = new Size(144, 50);
            pacienteBtn.TabIndex = 0;
            pacienteBtn.Text = "Pacientes";
            pacienteBtn.UseVisualStyleBackColor = true;
            pacienteBtn.Click += this.pacienteBtn_Click;
            // 
            // profesionalBtn
            // 
            profesionalBtn.Location = new Point(307, 193);
            profesionalBtn.Name = "profesionalBtn";
            profesionalBtn.Size = new Size(144, 50);
            profesionalBtn.TabIndex = 1;
            profesionalBtn.Text = "Profesional";
            profesionalBtn.UseVisualStyleBackColor = true;
            profesionalBtn.Click += this.profesionalBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 100);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pacienteBtn;
        private Button profesionalBtn;
        private Label label1;
    }
}
