namespace Calificaciones
{
    partial class FormAlumno
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
            this.dgv_VistaAlumnos = new System.Windows.Forms.DataGridView();
            this.btnRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VistaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VistaAlumnos
            // 
            this.dgv_VistaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VistaAlumnos.Location = new System.Drawing.Point(54, 69);
            this.dgv_VistaAlumnos.Name = "dgv_VistaAlumnos";
            this.dgv_VistaAlumnos.RowHeadersWidth = 51;
            this.dgv_VistaAlumnos.RowTemplate.Height = 24;
            this.dgv_VistaAlumnos.Size = new System.Drawing.Size(847, 264);
            this.dgv_VistaAlumnos.TabIndex = 0;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(54, 339);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(150, 36);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrar Alumno\r\n";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.dgv_VistaAlumnos);
            this.Name = "FormAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VistaAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VistaAlumnos;
        private System.Windows.Forms.Button btnRegistro;
    }
}