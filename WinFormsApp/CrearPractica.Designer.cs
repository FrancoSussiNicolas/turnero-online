namespace WinFormsApp
{
    partial class CrearPractica
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            nomPractica = new TextBox();
            descripcionPractica = new TextBox();
            btnCancelarPractica = new Button();
            btnRegistrarPractica = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(530, 34);
            label4.MaximumSize = new Size(0, 400);
            label4.Name = "label4";
            label4.Size = new Size(243, 32);
            label4.TabIndex = 5;
            label4.Text = "Registrar Práctica";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(451, 122);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(431, 179);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 7;
            label2.Text = "Descripción: ";
            // 
            // nomPractica
            // 
            nomPractica.Location = new Point(530, 121);
            nomPractica.Name = "nomPractica";
            nomPractica.Size = new Size(345, 23);
            nomPractica.TabIndex = 8;
            // 
            // descripcionPractica
            // 
            descripcionPractica.Location = new Point(530, 178);
            descripcionPractica.Multiline = true;
            descripcionPractica.Name = "descripcionPractica";
            descripcionPractica.Size = new Size(345, 70);
            descripcionPractica.TabIndex = 9;
            // 
            // btnCancelarPractica
            // 
            btnCancelarPractica.Location = new Point(738, 285);
            btnCancelarPractica.Name = "btnCancelarPractica";
            btnCancelarPractica.Size = new Size(151, 42);
            btnCancelarPractica.TabIndex = 11;
            btnCancelarPractica.Text = "Cancelar";
            btnCancelarPractica.UseVisualStyleBackColor = true;
            btnCancelarPractica.Click += btnCancelarPractica_Click;
            // 
            // btnRegistrarPractica
            // 
            btnRegistrarPractica.BackColor = SystemColors.ActiveCaption;
            btnRegistrarPractica.Location = new Point(502, 285);
            btnRegistrarPractica.Name = "btnRegistrarPractica";
            btnRegistrarPractica.Size = new Size(151, 42);
            btnRegistrarPractica.TabIndex = 10;
            btnRegistrarPractica.Text = "Registrar";
            btnRegistrarPractica.UseVisualStyleBackColor = false;
            btnRegistrarPractica.Click += btnRegistrarPractica_Click;
            // 
            // CrearPractica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 450);
            Controls.Add(btnCancelarPractica);
            Controls.Add(btnRegistrarPractica);
            Controls.Add(descripcionPractica);
            Controls.Add(nomPractica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "CrearPractica";
            Text = "Crear Práctica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox nomPractica;
        private TextBox descripcionPractica;
        private Button btnCancelarPractica;
        private Button btnRegistrarPractica;
    }
}