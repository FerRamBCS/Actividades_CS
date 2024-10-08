namespace Calificaciones
{
    partial class RegistrarMaestro
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
            this.btnSubirMaestro = new System.Windows.Forms.Button();
            this.txtApellidoMaestro = new System.Windows.Forms.TextBox();
            this.txtMatriculaMaestro = new System.Windows.Forms.TextBox();
            this.txtNombreMaestro = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubirMaestro
            // 
            this.btnSubirMaestro.Location = new System.Drawing.Point(273, 147);
            this.btnSubirMaestro.Name = "btnSubirMaestro";
            this.btnSubirMaestro.Size = new System.Drawing.Size(90, 33);
            this.btnSubirMaestro.TabIndex = 13;
            this.btnSubirMaestro.Text = "Agregar";
            this.btnSubirMaestro.UseVisualStyleBackColor = true;
            this.btnSubirMaestro.Click += new System.EventHandler(this.btnSubirMaestro_Click);
            // 
            // txtApellidoMaestro
            // 
            this.txtApellidoMaestro.Location = new System.Drawing.Point(236, 91);
            this.txtApellidoMaestro.Name = "txtApellidoMaestro";
            this.txtApellidoMaestro.Size = new System.Drawing.Size(168, 22);
            this.txtApellidoMaestro.TabIndex = 12;
            // 
            // txtMatriculaMaestro
            // 
            this.txtMatriculaMaestro.Location = new System.Drawing.Point(236, 119);
            this.txtMatriculaMaestro.Name = "txtMatriculaMaestro";
            this.txtMatriculaMaestro.Size = new System.Drawing.Size(168, 22);
            this.txtMatriculaMaestro.TabIndex = 11;
            // 
            // txtNombreMaestro
            // 
            this.txtNombreMaestro.Location = new System.Drawing.Point(236, 63);
            this.txtNombreMaestro.Name = "txtNombreMaestro";
            this.txtNombreMaestro.Size = new System.Drawing.Size(168, 22);
            this.txtNombreMaestro.TabIndex = 10;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(129, 125);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 9;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(133, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(134, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // RegistrarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 291);
            this.Controls.Add(this.btnSubirMaestro);
            this.Controls.Add(this.txtApellidoMaestro);
            this.Controls.Add(this.txtMatriculaMaestro);
            this.Controls.Add(this.txtNombreMaestro);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "RegistrarMaestro";
            this.Text = "Registrar Maestro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubirMaestro;
        private System.Windows.Forms.TextBox txtApellidoMaestro;
        private System.Windows.Forms.TextBox txtMatriculaMaestro;
        private System.Windows.Forms.TextBox txtNombreMaestro;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}