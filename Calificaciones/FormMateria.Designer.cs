namespace Calificaciones
{
    partial class FormMateria
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
            this.dgv_VistaMateria = new System.Windows.Forms.DataGridView();
            this.btnRmateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VistaMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VistaMateria
            // 
            this.dgv_VistaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VistaMateria.Location = new System.Drawing.Point(12, 69);
            this.dgv_VistaMateria.Name = "dgv_VistaMateria";
            this.dgv_VistaMateria.RowHeadersWidth = 51;
            this.dgv_VistaMateria.RowTemplate.Height = 24;
            this.dgv_VistaMateria.Size = new System.Drawing.Size(847, 228);
            this.dgv_VistaMateria.TabIndex = 0;
            // 
            // btnRmateria
            // 
            this.btnRmateria.Location = new System.Drawing.Point(12, 303);
            this.btnRmateria.Name = "btnRmateria";
            this.btnRmateria.Size = new System.Drawing.Size(137, 28);
            this.btnRmateria.TabIndex = 1;
            this.btnRmateria.Text = "Registrar Materia";
            this.btnRmateria.UseVisualStyleBackColor = true;
            this.btnRmateria.Click += new System.EventHandler(this.btnRmateria_Click);
            // 
            // FormMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.btnRmateria);
            this.Controls.Add(this.dgv_VistaMateria);
            this.Name = "FormMateria";
            this.Text = "FormMateria";
            this.Load += new System.EventHandler(this.FormMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VistaMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VistaMateria;
        private System.Windows.Forms.Button btnRmateria;
    }
}