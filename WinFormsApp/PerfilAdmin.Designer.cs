namespace WinFormsApp
{
    partial class PerfilAdmin
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
            txtMail = new TextBox();
            label3 = new Label();
            txtApellidoNombre = new TextBox();
            label2 = new Label();
            btnActualizar = new Button();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(112, 176);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(291, 23);
            txtMail.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(112, 158);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 16;
            label3.Text = "Correo Electrónico";
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Anchor = AnchorStyles.None;
            txtApellidoNombre.Location = new Point(113, 113);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(290, 23);
            txtApellidoNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(112, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido y Nombre";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.BackColor = SystemColors.AppWorkspace;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Location = new Point(207, 236);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(99, 38);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 40);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 12;
            label1.Text = "Perfil de Usuario";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PerfilAdmin
            // 
            AcceptButton = btnActualizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 314);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(txtApellidoNombre);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Name = "PerfilAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil de Administrador";
            Shown += PerfilAdmin_Shown;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMail;
        private Label label3;
        private TextBox txtApellidoNombre;
        private Label label2;
        private Button btnActualizar;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}