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
            label1 = new Label();
            verTurnos = new Button();
            crearTurnos = new Button();
            button3 = new Button();
            AddObraSocial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 17);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // verTurnos
            // 
            verTurnos.Location = new Point(188, 84);
            verTurnos.Name = "verTurnos";
            verTurnos.Size = new Size(134, 32);
            verTurnos.TabIndex = 1;
            verTurnos.Text = "Ver Turnos";
            verTurnos.UseVisualStyleBackColor = true;
            verTurnos.Click += btnverTurnos_Click;
            // 
            // crearTurnos
            // 
            crearTurnos.Location = new Point(344, 84);
            crearTurnos.Name = "crearTurnos";
            crearTurnos.Size = new Size(134, 32);
            crearTurnos.TabIndex = 2;
            crearTurnos.Text = "Crear Turnos";
            crearTurnos.UseVisualStyleBackColor = true;
            crearTurnos.Click += btncrearTurnos_Click;
            // 
            // button3
            // 
            button3.Location = new Point(188, 149);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddObraSocial
            // 
            AddObraSocial.Location = new Point(344, 149);
            AddObraSocial.Name = "AddObraSocial";
            AddObraSocial.Size = new Size(134, 32);
            AddObraSocial.TabIndex = 4;
            AddObraSocial.Text = "Agregar Obra Social";
            AddObraSocial.UseVisualStyleBackColor = true;
            AddObraSocial.Click += btnAddObraSocial_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(AddObraSocial);
            Controls.Add(button3);
            Controls.Add(crearTurnos);
            Controls.Add(verTurnos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "Menu";
            Load += MenuPrincipal_Load;
            Shown += MenuPrincipal_Shown;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button verTurnos;
        private Button crearTurnos;
        private Button button3;
        private Button AddObraSocial;
    }
}
