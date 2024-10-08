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
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblClaveMateria = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubirMateria
            // 
            this.btnSubirMateria.Location = new System.Drawing.Point(190, 120);
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
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(173, 53);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(168, 22);
            this.txtMateria.TabIndex = 10;
            // 
            // lblClaveMateria
            // 
            this.lblClaveMateria.AutoSize = true;
            this.lblClaveMateria.Location = new System.Drawing.Point(88, 87);
            this.lblClaveMateria.Name = "lblClaveMateria";
            this.lblClaveMateria.Size = new System.Drawing.Size(42, 16);
            this.lblClaveMateria.TabIndex = 8;
            this.lblClaveMateria.Text = "Clave";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(89, 59);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "Materia";
            // 
            // RegistrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 203);
            this.Controls.Add(this.btnSubirMateria);
            this.Controls.Add(this.txtClaveMateria);
            this.Controls.Add(this.txtMateria);
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
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblClaveMateria;
        private System.Windows.Forms.Label lblMateria;
    }
}