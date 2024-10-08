namespace Calificaciones
{
    partial class FormMaestros
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
            this.dgvMaestros = new System.Windows.Forms.DataGridView();
            this.btnRMaestro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaestros
            // 
            this.dgvMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaestros.Location = new System.Drawing.Point(54, 89);
            this.dgvMaestros.Name = "dgvMaestros";
            this.dgvMaestros.RowHeadersWidth = 51;
            this.dgvMaestros.RowTemplate.Height = 24;
            this.dgvMaestros.Size = new System.Drawing.Size(811, 251);
            this.dgvMaestros.TabIndex = 0;
            // 
            // btnRMaestro
            // 
            this.btnRMaestro.Location = new System.Drawing.Point(54, 346);
            this.btnRMaestro.Name = "btnRMaestro";
            this.btnRMaestro.Size = new System.Drawing.Size(151, 31);
            this.btnRMaestro.TabIndex = 1;
            this.btnRMaestro.Text = "Registrar Maestro";
            this.btnRMaestro.UseVisualStyleBackColor = true;
            this.btnRMaestro.Click += new System.EventHandler(this.btnRMaestro_Click);
            // 
            // FormMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.btnRMaestro);
            this.Controls.Add(this.dgvMaestros);
            this.Name = "FormMaestros";
            this.Text = "Maestros";
            this.Load += new System.EventHandler(this.FormMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaestros;
        private System.Windows.Forms.Button btnRMaestro;
    }
}