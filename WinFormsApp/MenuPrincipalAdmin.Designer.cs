namespace WinFormsApp
{
    partial class MenuPrincipalAdmin
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
            AddObraSocial = new Button();
            button3 = new Button();
            crearTurnos = new Button();
            verTurnos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddObraSocial
            // 
            AddObraSocial.Location = new Point(409, 244);
            AddObraSocial.Name = "AddObraSocial";
            AddObraSocial.Size = new Size(134, 32);
            AddObraSocial.TabIndex = 9;
            AddObraSocial.Text = "Agregar Obra Social";
            AddObraSocial.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(253, 244);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // crearTurnos
            // 
            crearTurnos.Location = new Point(409, 179);
            crearTurnos.Name = "crearTurnos";
            crearTurnos.Size = new Size(134, 32);
            crearTurnos.TabIndex = 7;
            crearTurnos.Text = "Crear Turnos";
            crearTurnos.UseVisualStyleBackColor = true;
            // 
            // verTurnos
            // 
            verTurnos.Location = new Point(253, 179);
            verTurnos.Name = "verTurnos";
            verTurnos.Size = new Size(134, 32);
            verTurnos.TabIndex = 6;
            verTurnos.Text = "Ver Turnos";
            verTurnos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(294, 121);
            label1.Name = "label1";
            label1.Size = new Size(206, 17);
            label1.TabIndex = 5;
            label1.Text = "Menu Principal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddObraSocial);
            Controls.Add(button3);
            Controls.Add(crearTurnos);
            Controls.Add(verTurnos);
            Controls.Add(label1);
            Name = "MenuPrincipalAdmin";
            Text = "MenuPrincipalAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button AddObraSocial;
        private Button button3;
        private Button crearTurnos;
        private Button verTurnos;
        private Label label1;
    }
}