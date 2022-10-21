namespace WindowsLab
{
    partial class Vectores1A
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
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(114, 175);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(153, 23);
            this.btnResultados.TabIndex = 0;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(114, 109);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(153, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Vectores1A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 365);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnResultados);
            this.Name = "Vectores1A";
            this.Text = "Vectores1A";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnCargar;
    }
}