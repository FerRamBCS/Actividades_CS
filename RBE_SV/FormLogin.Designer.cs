namespace RBE_SV
{
    partial class FRM_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_login));
            this.P_Login = new System.Windows.Forms.Panel();
            this.Lbl_Bienvenidamssg = new System.Windows.Forms.Label();
            this.PB_ILogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Contra = new System.Windows.Forms.Label();
            this.Txt_Contra = new System.Windows.Forms.TextBox();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.P_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ILogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Login
            // 
            this.P_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.P_Login.Controls.Add(this.Lbl_Bienvenidamssg);
            this.P_Login.Controls.Add(this.PB_ILogin);
            this.P_Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Login.Location = new System.Drawing.Point(0, 0);
            this.P_Login.Name = "P_Login";
            this.P_Login.Size = new System.Drawing.Size(234, 325);
            this.P_Login.TabIndex = 0;
            // 
            // Lbl_Bienvenidamssg
            // 
            this.Lbl_Bienvenidamssg.AutoSize = true;
            this.Lbl_Bienvenidamssg.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienvenidamssg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Bienvenidamssg.Location = new System.Drawing.Point(61, 185);
            this.Lbl_Bienvenidamssg.Name = "Lbl_Bienvenidamssg";
            this.Lbl_Bienvenidamssg.Size = new System.Drawing.Size(109, 24);
            this.Lbl_Bienvenidamssg.TabIndex = 1;
            this.Lbl_Bienvenidamssg.Text = "Bienvenido";
            this.Lbl_Bienvenidamssg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Bienvenidamssg.Click += new System.EventHandler(this.Lbl_Bienvenidamssg_Click);
            // 
            // PB_ILogin
            // 
            this.PB_ILogin.Image = ((System.Drawing.Image)(resources.GetObject("PB_ILogin.Image")));
            this.PB_ILogin.Location = new System.Drawing.Point(31, 61);
            this.PB_ILogin.Name = "PB_ILogin";
            this.PB_ILogin.Size = new System.Drawing.Size(147, 108);
            this.PB_ILogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ILogin.TabIndex = 0;
            this.PB_ILogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(387, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniciar Sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(289, 139);
            this.Txt_Usuario.Multiline = true;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(312, 30);
            this.Txt_Usuario.TabIndex = 3;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Usuario.Location = new System.Drawing.Point(295, 112);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(80, 24);
            this.Lbl_Usuario.TabIndex = 4;
            this.Lbl_Usuario.Text = "Usuario";
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Contra
            // 
            this.Lbl_Contra.AutoSize = true;
            this.Lbl_Contra.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Contra.Location = new System.Drawing.Point(295, 177);
            this.Lbl_Contra.Name = "Lbl_Contra";
            this.Lbl_Contra.Size = new System.Drawing.Size(114, 24);
            this.Lbl_Contra.TabIndex = 6;
            this.Lbl_Contra.Text = "Contraseña";
            this.Lbl_Contra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_Contra
            // 
            this.Txt_Contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.Txt_Contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Contra.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contra.Location = new System.Drawing.Point(289, 204);
            this.Txt_Contra.Multiline = true;
            this.Txt_Contra.Name = "Txt_Contra";
            this.Txt_Contra.Size = new System.Drawing.Size(312, 30);
            this.Txt_Contra.TabIndex = 5;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Location = new System.Drawing.Point(357, 257);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(162, 33);
            this.Btn_inicio.TabIndex = 7;
            this.Btn_inicio.Text = "Iniciar Sesión";
            this.Btn_inicio.UseVisualStyleBackColor = true;
            this.Btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(569, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FRM_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(185)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(666, 325);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.Lbl_Contra);
            this.Controls.Add(this.Txt_Contra);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión Ramírez Bravo Equipos";
            this.TopMost = true;
            this.P_Login.ResumeLayout(false);
            this.P_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ILogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_Login;
        private System.Windows.Forms.PictureBox PB_ILogin;
        private System.Windows.Forms.Label Lbl_Bienvenidamssg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Contra;
        private System.Windows.Forms.TextBox Txt_Contra;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

