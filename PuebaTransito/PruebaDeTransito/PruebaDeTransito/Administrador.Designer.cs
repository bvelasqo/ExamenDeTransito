namespace PruebaDeTransito
{
    partial class Administrador
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
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnResultados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Location = new System.Drawing.Point(118, 26);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(85, 60);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.BtnEYR_Click);
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.Location = new System.Drawing.Point(320, 26);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(85, 60);
            this.btnPreguntas.TabIndex = 1;
            this.btnPreguntas.Text = "Gestion de preguntas";
            this.btnPreguntas.UseVisualStyleBackColor = true;
            this.btnPreguntas.Click += new System.EventHandler(this.BtnPreguntas_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 104);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.Size = new System.Drawing.Size(524, 241);
            this.dgvEstudiantes.TabIndex = 2;
            this.dgvEstudiantes.Visible = false;
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(220, 26);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(85, 60);
            this.btnResultados.TabIndex = 3;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // Administrador
            // 
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(567, 368);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnPreguntas);
            this.Controls.Add(this.btnEstudiantes);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnResultados;
    }
}