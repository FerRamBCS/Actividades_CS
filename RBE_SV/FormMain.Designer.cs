namespace RBE_SV
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.P_UpBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Opc = new System.Windows.Forms.PictureBox();
            this.P_Logout = new System.Windows.Forms.Panel();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.FLP_MConntainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btn_Consultas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_CPrecios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_CError = new System.Windows.Forms.Button();
            this.P_Ventas = new System.Windows.Forms.Panel();
            this.Btn_Ventas = new System.Windows.Forms.Button();
            this.P_Inventario = new System.Windows.Forms.Panel();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.P_Home = new System.Windows.Forms.Panel();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.FLP_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.P_Pedidos = new System.Windows.Forms.Panel();
            this.Btn_Pedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Usuarios = new System.Windows.Forms.Button();
            this.T_Menu = new System.Windows.Forms.Timer(this.components);
            this.T_SB = new System.Windows.Forms.Timer(this.components);
            this.P_UpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Opc)).BeginInit();
            this.P_Logout.SuspendLayout();
            this.FLP_MConntainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.P_Ventas.SuspendLayout();
            this.P_Inventario.SuspendLayout();
            this.P_Home.SuspendLayout();
            this.FLP_Main.SuspendLayout();
            this.P_Pedidos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_UpBar
            // 
            this.P_UpBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.P_UpBar.Controls.Add(this.label1);
            this.P_UpBar.Controls.Add(this.Btn_Opc);
            this.P_UpBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_UpBar.Location = new System.Drawing.Point(0, 0);
            this.P_UpBar.Name = "P_UpBar";
            this.P_UpBar.Size = new System.Drawing.Size(1087, 43);
            this.P_UpBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE VENTAS RAMIREZ BRAVO  EQUIPOS\r\n";
            // 
            // Btn_Opc
            // 
            this.Btn_Opc.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Opc.Image")));
            this.Btn_Opc.Location = new System.Drawing.Point(16, 8);
            this.Btn_Opc.Name = "Btn_Opc";
            this.Btn_Opc.Size = new System.Drawing.Size(37, 29);
            this.Btn_Opc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Btn_Opc.TabIndex = 1;
            this.Btn_Opc.TabStop = false;
            this.Btn_Opc.Click += new System.EventHandler(this.Btn_Opc_Click);
            // 
            // P_Logout
            // 
            this.P_Logout.Controls.Add(this.Btn_Logout);
            this.P_Logout.Location = new System.Drawing.Point(0, 421);
            this.P_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.P_Logout.Name = "P_Logout";
            this.P_Logout.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.P_Logout.Size = new System.Drawing.Size(330, 63);
            this.P_Logout.TabIndex = 5;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Logout.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logout.Image")));
            this.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Logout.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Logout.Size = new System.Drawing.Size(356, 85);
            this.Btn_Logout.TabIndex = 0;
            this.Btn_Logout.Text = "           Cerrar Sesión";
            this.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Logout.UseVisualStyleBackColor = false;
            // 
            // FLP_MConntainer
            // 
            this.FLP_MConntainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.FLP_MConntainer.Controls.Add(this.panel9);
            this.FLP_MConntainer.Controls.Add(this.panel6);
            this.FLP_MConntainer.Controls.Add(this.panel7);
            this.FLP_MConntainer.Location = new System.Drawing.Point(3, 299);
            this.FLP_MConntainer.Name = "FLP_MConntainer";
            this.FLP_MConntainer.Size = new System.Drawing.Size(330, 50);
            this.FLP_MConntainer.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Btn_Consultas);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel9.Size = new System.Drawing.Size(330, 63);
            this.panel9.TabIndex = 8;
            // 
            // Btn_Consultas
            // 
            this.Btn_Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Consultas.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Consultas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consultas.Image")));
            this.Btn_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultas.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Consultas.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Consultas.Name = "Btn_Consultas";
            this.Btn_Consultas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Consultas.Size = new System.Drawing.Size(356, 85);
            this.Btn_Consultas.TabIndex = 0;
            this.Btn_Consultas.Text = "           Consultas";
            this.Btn_Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultas.UseVisualStyleBackColor = false;
            this.Btn_Consultas.Click += new System.EventHandler(this.Btn_Consultas_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn_CPrecios);
            this.panel6.Location = new System.Drawing.Point(0, 63);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel6.Size = new System.Drawing.Size(330, 63);
            this.panel6.TabIndex = 9;
            // 
            // Btn_CPrecios
            // 
            this.Btn_CPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.Btn_CPrecios.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_CPrecios.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CPrecios.Image")));
            this.Btn_CPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CPrecios.Location = new System.Drawing.Point(-16, -7);
            this.Btn_CPrecios.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_CPrecios.Name = "Btn_CPrecios";
            this.Btn_CPrecios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_CPrecios.Size = new System.Drawing.Size(356, 85);
            this.Btn_CPrecios.TabIndex = 0;
            this.Btn_CPrecios.Text = "           Consultar precios";
            this.Btn_CPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CPrecios.UseVisualStyleBackColor = false;
            this.Btn_CPrecios.Click += new System.EventHandler(this.Btn_CPrecios_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Btn_CError);
            this.panel7.Location = new System.Drawing.Point(0, 126);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel7.Size = new System.Drawing.Size(330, 63);
            this.panel7.TabIndex = 9;
            // 
            // Btn_CError
            // 
            this.Btn_CError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.Btn_CError.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_CError.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CError.Image")));
            this.Btn_CError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CError.Location = new System.Drawing.Point(-16, -7);
            this.Btn_CError.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_CError.Name = "Btn_CError";
            this.Btn_CError.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_CError.Size = new System.Drawing.Size(356, 85);
            this.Btn_CError.TabIndex = 0;
            this.Btn_CError.Text = "           Consultar errores";
            this.Btn_CError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CError.UseVisualStyleBackColor = false;
            this.Btn_CError.Click += new System.EventHandler(this.Btn_CError_Click);
            // 
            // P_Ventas
            // 
            this.P_Ventas.Controls.Add(this.Btn_Ventas);
            this.P_Ventas.Location = new System.Drawing.Point(3, 92);
            this.P_Ventas.Name = "P_Ventas";
            this.P_Ventas.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.P_Ventas.Size = new System.Drawing.Size(330, 63);
            this.P_Ventas.TabIndex = 3;
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Ventas.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ventas.Image")));
            this.Btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Ventas.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Ventas.Size = new System.Drawing.Size(356, 85);
            this.Btn_Ventas.TabIndex = 0;
            this.Btn_Ventas.Text = "           Ventas";
            this.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.UseVisualStyleBackColor = false;
            this.Btn_Ventas.Click += new System.EventHandler(this.Btn_Ventas_Click);
            // 
            // P_Inventario
            // 
            this.P_Inventario.Controls.Add(this.Btn_Inventario);
            this.P_Inventario.Location = new System.Drawing.Point(3, 161);
            this.P_Inventario.Name = "P_Inventario";
            this.P_Inventario.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.P_Inventario.Size = new System.Drawing.Size(330, 63);
            this.P_Inventario.TabIndex = 4;
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Inventario.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Inventario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Inventario.Image")));
            this.Btn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inventario.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Inventario.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Inventario.Size = new System.Drawing.Size(356, 85);
            this.Btn_Inventario.TabIndex = 0;
            this.Btn_Inventario.Text = "           Inventario";
            this.Btn_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inventario.UseVisualStyleBackColor = false;
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // P_Home
            // 
            this.P_Home.Controls.Add(this.Btn_Home);
            this.P_Home.Location = new System.Drawing.Point(3, 23);
            this.P_Home.Name = "P_Home";
            this.P_Home.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.P_Home.Size = new System.Drawing.Size(330, 63);
            this.P_Home.TabIndex = 2;
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Home.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Image")));
            this.Btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Home.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Home.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Home.Size = new System.Drawing.Size(356, 85);
            this.Btn_Home.TabIndex = 0;
            this.Btn_Home.Text = "           Home";
            this.Btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // FLP_Main
            // 
            this.FLP_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.FLP_Main.Controls.Add(this.P_Home);
            this.FLP_Main.Controls.Add(this.P_Ventas);
            this.FLP_Main.Controls.Add(this.P_Inventario);
            this.FLP_Main.Controls.Add(this.P_Pedidos);
            this.FLP_Main.Controls.Add(this.FLP_MConntainer);
            this.FLP_Main.Controls.Add(this.panel1);
            this.FLP_Main.Controls.Add(this.P_Logout);
            this.FLP_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLP_Main.Location = new System.Drawing.Point(0, 43);
            this.FLP_Main.Name = "FLP_Main";
            this.FLP_Main.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.FLP_Main.Size = new System.Drawing.Size(200, 577);
            this.FLP_Main.TabIndex = 1;
            this.FLP_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.FLP_Main_Paint);
            // 
            // P_Pedidos
            // 
            this.P_Pedidos.Controls.Add(this.Btn_Pedidos);
            this.P_Pedidos.Location = new System.Drawing.Point(3, 230);
            this.P_Pedidos.Name = "P_Pedidos";
            this.P_Pedidos.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.P_Pedidos.Size = new System.Drawing.Size(330, 63);
            this.P_Pedidos.TabIndex = 4;
            // 
            // Btn_Pedidos
            // 
            this.Btn_Pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Pedidos.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pedidos.Image")));
            this.Btn_Pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pedidos.Location = new System.Drawing.Point(-11, -7);
            this.Btn_Pedidos.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Pedidos.Name = "Btn_Pedidos";
            this.Btn_Pedidos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Pedidos.Size = new System.Drawing.Size(356, 85);
            this.Btn_Pedidos.TabIndex = 0;
            this.Btn_Pedidos.Text = "           Pedidos";
            this.Btn_Pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pedidos.UseVisualStyleBackColor = false;
            this.Btn_Pedidos.Click += new System.EventHandler(this.Btn_Pedidos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Usuarios);
            this.panel1.Location = new System.Drawing.Point(3, 355);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(330, 63);
            this.panel1.TabIndex = 6;
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Btn_Usuarios.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Usuarios.Image")));
            this.Btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.Location = new System.Drawing.Point(-16, -7);
            this.Btn_Usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Btn_Usuarios.Size = new System.Drawing.Size(356, 85);
            this.Btn_Usuarios.TabIndex = 0;
            this.Btn_Usuarios.Text = "           Usuarios";
            this.Btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.UseVisualStyleBackColor = false;
            this.Btn_Usuarios.Click += new System.EventHandler(this.Btn_Usuarios_Click);
            // 
            // T_Menu
            // 
            this.T_Menu.Interval = 10;
            this.T_Menu.Tick += new System.EventHandler(this.T_Menu_Tick);
            // 
            // T_SB
            // 
            this.T_SB.Interval = 10;
            this.T_SB.Tick += new System.EventHandler(this.T_SB_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 620);
            this.Controls.Add(this.FLP_Main);
            this.Controls.Add(this.P_UpBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.P_UpBar.ResumeLayout(false);
            this.P_UpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Opc)).EndInit();
            this.P_Logout.ResumeLayout(false);
            this.FLP_MConntainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.P_Ventas.ResumeLayout(false);
            this.P_Inventario.ResumeLayout(false);
            this.P_Home.ResumeLayout(false);
            this.FLP_Main.ResumeLayout(false);
            this.P_Pedidos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_UpBar;
        private System.Windows.Forms.PictureBox Btn_Opc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Logout;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.FlowLayoutPanel FLP_MConntainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Btn_Consultas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn_CPrecios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btn_CError;
        private System.Windows.Forms.Panel P_Ventas;
        private System.Windows.Forms.Button Btn_Ventas;
        private System.Windows.Forms.Panel P_Inventario;
        private System.Windows.Forms.Button Btn_Inventario;
        private System.Windows.Forms.Panel P_Home;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.FlowLayoutPanel FLP_Main;
        private System.Windows.Forms.Timer T_Menu;
        private System.Windows.Forms.Timer T_SB;
        private System.Windows.Forms.Panel P_Pedidos;
        private System.Windows.Forms.Button Btn_Pedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Usuarios;
    }
}