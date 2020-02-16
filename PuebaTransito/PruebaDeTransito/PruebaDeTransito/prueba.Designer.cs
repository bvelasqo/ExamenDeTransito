namespace PruebaDeTransito
{
    partial class prueba
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.PXImagen = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.PXImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(4, 4);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(161, 63);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "¿Qué significa la siguiente señal de tránsito?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPregunta.Visible = false;
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Location = new System.Drawing.Point(4, 107);
            this.cbxOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(163, 27);
            this.cbxOpciones.TabIndex = 2;
            this.cbxOpciones.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(42, 175);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(78, 34);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(66, 90);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(208, 85);
            this.btnComenzar.TabIndex = 6;
            this.btnComenzar.Text = "Comenzar prueba";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.ForeColor = System.Drawing.Color.Blue;
            this.lblOpciones.Location = new System.Drawing.Point(53, 84);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(67, 19);
            this.lblOpciones.TabIndex = 7;
            this.lblOpciones.Text = "Opciones";
            this.lblOpciones.Visible = false;
            // 
            // PXImagen
            // 
            this.PXImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PXImagen.Location = new System.Drawing.Point(4, 4);
            this.PXImagen.Margin = new System.Windows.Forms.Padding(4);
            this.PXImagen.Name = "PXImagen";
            this.PXImagen.Size = new System.Drawing.Size(328, 284);
            this.PXImagen.TabIndex = 5;
            this.PXImagen.TabStop = false;
            this.PXImagen.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPregunta);
            this.splitContainer1.Panel1.Controls.Add(this.cbxOpciones);
            this.splitContainer1.Panel1.Controls.Add(this.btnSiguiente);
            this.splitContainer1.Panel1.Controls.Add(this.lblOpciones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PXImagen);
            this.splitContainer1.Panel2.Controls.Add(this.btnComenzar);
            this.splitContainer1.Size = new System.Drawing.Size(521, 309);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 8;
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(521, 309);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "prueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prueba";
            ((System.ComponentModel.ISupportInitialize)(this.PXImagen)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.ComboBox cbxOpciones;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox PXImagen;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}