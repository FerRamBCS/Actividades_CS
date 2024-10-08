namespace Calificaciones
{
    partial class FormCalificaciones
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
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnSCalif = new System.Windows.Forms.Button();
            this.dgvCalificacion = new System.Windows.Forms.DataGridView();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCalifcacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(73, 76);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(187, 24);
            this.cbNombre.TabIndex = 0;
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(285, 76);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(187, 24);
            this.cbMateria.TabIndex = 1;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(499, 78);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(187, 22);
            this.txtCalificacion.TabIndex = 2;
            // 
            // btnSCalif
            // 
            this.btnSCalif.Location = new System.Drawing.Point(73, 135);
            this.btnSCalif.Name = "btnSCalif";
            this.btnSCalif.Size = new System.Drawing.Size(75, 23);
            this.btnSCalif.TabIndex = 3;
            this.btnSCalif.Text = "Registrar";
            this.btnSCalif.UseVisualStyleBackColor = true;
            this.btnSCalif.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCalificacion
            // 
            this.dgvCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificacion.Location = new System.Drawing.Point(73, 189);
            this.dgvCalificacion.Name = "dgvCalificacion";
            this.dgvCalificacion.RowHeadersWidth = 51;
            this.dgvCalificacion.RowTemplate.Height = 24;
            this.dgvCalificacion.Size = new System.Drawing.Size(712, 150);
            this.dgvCalificacion.TabIndex = 4;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(70, 57);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(56, 16);
            this.lblAlumno.TabIndex = 5;
            this.lblAlumno.Text = "Nombre";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(282, 57);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 6;
            this.lblMateria.Text = "Materia";
            // 
            // lblCalifcacion
            // 
            this.lblCalifcacion.AutoSize = true;
            this.lblCalifcacion.Location = new System.Drawing.Point(496, 57);
            this.lblCalifcacion.Name = "lblCalifcacion";
            this.lblCalifcacion.Size = new System.Drawing.Size(76, 16);
            this.lblCalifcacion.TabIndex = 7;
            this.lblCalifcacion.Text = "Calificacion";
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.lblCalifcacion);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.dgvCalificacion);
            this.Controls.Add(this.btnSCalif);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbNombre);
            this.Name = "FormCalificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.FormCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnSCalif;
        private System.Windows.Forms.DataGridView dgvCalificacion;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCalifcacion;
    }
}