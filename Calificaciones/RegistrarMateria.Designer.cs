namespace Calificaciones
{
    partial class RegistrarMateria
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
            this.btnSubirMateria = new System.Windows.Forms.Button();
            this.txtClaveMateria = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblDocenteEncargado = new System.Windows.Forms.Label();
            this.lblClaveMateria = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubirMateria
            // 
            this.btnSubirMateria.Location = new System.Drawing.Point(196, 165);
            this.btnSubirMateria.Name = "btnSubirMateria";
            this.btnSubirMateria.Size = new System.Drawing.Size(111, 29);
            this.btnSubirMateria.TabIndex = 13;
            this.btnSubirMateria.Text = "Agregar";
            this.btnSubirMateria.UseVisualStyleBackColor = true;
            this.btnSubirMateria.Click += new System.EventHandler(this.btnSubirMateria_Click);
            // 
            // txtClaveMateria
            // 
            this.txtClaveMateria.Location = new System.Drawing.Point(173, 81);
            this.txtClaveMateria.Name = "txtClaveMateria";
            this.txtClaveMateria.Size = new System.Drawing.Size(168, 22);
            this.txtClaveMateria.TabIndex = 12;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(173, 109);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(168, 22);
            this.txtNombreDocente.TabIndex = 11;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(173, 53);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(168, 22);
            this.txtMateria.TabIndex = 10;
            // 
            // lblDocenteEncargado
            // 
            this.lblDocenteEncargado.AutoSize = true;
            this.lblDocenteEncargado.Location = new System.Drawing.Point(32, 109);
            this.lblDocenteEncargado.Name = "lblDocenteEncargado";
            this.lblDocenteEncargado.Size = new System.Drawing.Size(127, 16);
            this.lblDocenteEncargado.TabIndex = 9;
            this.lblDocenteEncargado.Text = "Docente encargado";
            this.lblDocenteEncargado.Click += new System.EventHandler(this.lblDocenteEncargado_Click);
            // 
            // lblClaveMateria
            // 
            this.lblClaveMateria.AutoSize = true;
            this.lblClaveMateria.Location = new System.Drawing.Point(31, 84);
            this.lblClaveMateria.Name = "lblClaveMateria";
            this.lblClaveMateria.Size = new System.Drawing.Size(42, 16);
            this.lblClaveMateria.TabIndex = 8;
            this.lblClaveMateria.Text = "Clave";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(32, 56);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "Materia";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(173, 137);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(168, 22);
            this.txtCalificacion.TabIndex = 15;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(32, 137);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(76, 16);
            this.lblCalificacion.TabIndex = 14;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // RegistrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnSubirMateria);
            this.Controls.Add(this.txtClaveMateria);
            this.Controls.Add(this.txtNombreDocente);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblDocenteEncargado);
            this.Controls.Add(this.lblClaveMateria);
            this.Controls.Add(this.lblMateria);
            this.Name = "RegistrarMateria";
            this.Text = "Registrar Materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubirMateria;
        private System.Windows.Forms.TextBox txtClaveMateria;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblDocenteEncargado;
        private System.Windows.Forms.Label lblClaveMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblCalificacion;
    }
}