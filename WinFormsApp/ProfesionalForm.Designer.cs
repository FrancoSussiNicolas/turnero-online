namespace WinFormsApp
{
    partial class ProfesionalForm
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
            ProfesionalesDataGridView = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProfesionalesDataGridView
            // 
            ProfesionalesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfesionalesDataGridView.Location = new Point(12, 11);
            ProfesionalesDataGridView.Margin = new Padding(3, 2, 3, 2);
            ProfesionalesDataGridView.Name = "ProfesionalesDataGridView";
            ProfesionalesDataGridView.RowHeadersWidth = 51;
            ProfesionalesDataGridView.Size = new Size(1091, 495);
            ProfesionalesDataGridView.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(502, 531);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 37);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ProfesionalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 598);
            Controls.Add(btnVolver);
            Controls.Add(ProfesionalesDataGridView);
            Name = "ProfesionalForm";
            Text = "Profesionales";
            ((System.ComponentModel.ISupportInitialize)ProfesionalesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ProfesionalesDataGridView;
        private Button btnVolver;
    }
}