namespace Calificaciones
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnMaestro = new System.Windows.Forms.Button();
            this.btnRCalif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMateria
            // 
            this.btnMateria.Location = new System.Drawing.Point(142, 116);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(75, 23);
            this.btnMateria.TabIndex = 0;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(331, 116);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnMaestro
            // 
            this.btnMaestro.Location = new System.Drawing.Point(240, 116);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(75, 23);
            this.btnMaestro.TabIndex = 2;
            this.btnMaestro.Text = "Maestro";
            this.btnMaestro.UseVisualStyleBackColor = true;
            this.btnMaestro.Click += new System.EventHandler(this.btnMaestro_Click);
            // 
            // btnRCalif
            // 
            this.btnRCalif.Location = new System.Drawing.Point(189, 145);
            this.btnRCalif.Name = "btnRCalif";
            this.btnRCalif.Size = new System.Drawing.Size(180, 23);
            this.btnRCalif.TabIndex = 3;
            this.btnRCalif.Text = "Registrar Calificaciones";
            this.btnRCalif.UseVisualStyleBackColor = true;
            this.btnRCalif.Click += new System.EventHandler(this.btnRCalif_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 255);
            this.Controls.Add(this.btnRCalif);
            this.Controls.Add(this.btnMaestro);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnMateria);
            this.Name = "MainForm";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnMaestro;
        private System.Windows.Forms.Button btnRCalif;
    }
}

