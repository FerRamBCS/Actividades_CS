﻿namespace RBE_SV
{
    partial class FormBienvenida
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
            this.Lbl_Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Bienvenida
            // 
            this.Lbl_Bienvenida.AutoSize = true;
            this.Lbl_Bienvenida.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienvenida.Location = new System.Drawing.Point(266, 197);
            this.Lbl_Bienvenida.Name = "Lbl_Bienvenida";
            this.Lbl_Bienvenida.Size = new System.Drawing.Size(261, 28);
            this.Lbl_Bienvenida.TabIndex = 1;
            this.Lbl_Bienvenida.Text = "Bienvendo a tu sistema de venta";
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBienvenida";
            this.Text = "FormBienvenida";
            this.Load += new System.EventHandler(this.FormBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Bienvenida;
    }
}