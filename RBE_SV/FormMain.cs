using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBE_SV
{
    public partial class FormMain : Form
    {
        //Declara los form 
        FormBienvenida formBienvenida;
        FormVentas formVentas;
        FormInventario formInventario;
        FormPedidos formPedidos;
        FormConError formConError;
        FormConPrecios formConPrecios;

        public FormMain()
        {
            InitializeComponent();
            mdiprop();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mdiprop()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private const int MaxHeightMenu = 170;
        private const int MinHeightMenu = 50;
        private const int MaxWidthSidebar = 200;
        private const int MinWidthSidebar = 50;
        private const int Incremento = 10;

        bool menuExpandido = false;
        bool sidebarExpandida = true;

        private void T_Menu_Tick(object sender, EventArgs e)
        {
            if (!menuExpandido)
            {
                // Expandir el menú
                FLP_MConntainer.Height += Incremento;
                if (FLP_MConntainer.Height >= MaxHeightMenu)
                {
                    FLP_MConntainer.Height = MaxHeightMenu;
                    T_Menu.Stop();
                    menuExpandido = true;
                }
            }
            else
            {
                // Contraer el menú
                FLP_MConntainer.Height -= Incremento;
                if (FLP_MConntainer.Height <= MinHeightMenu)
                {
                    FLP_MConntainer.Height = MinHeightMenu;
                    T_Menu.Stop();
                    menuExpandido = false;
                }
            }
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            T_Menu.Start(); // Iniciar el temporizador al hacer clic
        }

        private void T_SB_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida)
            {
                // Contraer la barra lateral
                FLP_Main.Width -= Incremento;
                if (FLP_Main.Width <= MinWidthSidebar)
                {
                    FLP_Main.Width = MinWidthSidebar;
                    sidebarExpandida = false;
                    T_SB.Stop();
                }
            }
            else
            {
                // Expandir la barra lateral
                FLP_Main.Width += Incremento;
                if (FLP_Main.Width >= MaxWidthSidebar)
                {
                    FLP_Main.Width = MaxWidthSidebar;
                    sidebarExpandida = true;
                    T_SB.Stop();
                    ActualizarAnchosPaneles();
                }
            }
        }

        private void Btn_Opc_Click(object sender, EventArgs e)
        {
            T_SB.Start(); // Iniciar el temporizador al hacer clic
        }

        private void ActualizarAnchosPaneles()
        {
            int nuevoAncho = FLP_Main.Width;
            P_Home.Width = nuevoAncho;
            P_Ventas.Width = nuevoAncho;
            P_Inventario.Width = nuevoAncho;
            P_Pedidos.Width = nuevoAncho;
            FLP_MConntainer.Width = nuevoAncho;
            P_Logout.Width = nuevoAncho;
        }
        private void FLP_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if (formBienvenida == null)
            {
                formBienvenida = new FormBienvenida();
                formBienvenida.FormClosed += formBienvenida_FormClosed;
                formBienvenida.MdiParent = this;
                formBienvenida.Dock = DockStyle.Fill;
                formBienvenida.Show();
            }
            else
            {
                formBienvenida.Activate();
            }
        }

        private void formBienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            formBienvenida = null;
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            if (formVentas == null)
            {
                formVentas = new FormVentas();
                formVentas.FormClosed += FormVentas_FormClosed;
                formVentas.MdiParent = this;
                formVentas.Dock = DockStyle.Fill;
                formVentas.Show();
            }
            else 
            { 
                formVentas.Activate(); 
            }
        }

        private void FormVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formVentas = null;
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            if (formInventario == null)
            {
                formInventario = new FormInventario();
                formInventario.FormClosed += FormInventario_FormClosed;
                formInventario.MdiParent= this;
                formVentas.Dock = DockStyle.Fill;
                formInventario.Show();
            }
            else
            {
                formInventario.Activate();
            }
        }

        private void FormInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInventario = null;
        }

        private void Btn_Pedidos_Click(object sender, EventArgs e)
        {
            if(formPedidos == null)
            {
                formPedidos = new FormPedidos();
                formPedidos.FormClosed += FormPedidos_FormClosed;
                formPedidos.MdiParent = this;
                formPedidos.Dock = DockStyle.Fill;
                formPedidos.Show();
            }
            else 
            {
                formPedidos.Activate(); 
            }
        }

        private void FormPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPedidos = null;
        }

        private void Btn_CPrecios_Click(object sender, EventArgs e)
        {
            if (formConPrecios == null)
            {
                formConPrecios = new FormConPrecios();
                formConPrecios.FormClosed += FormConPrecios_FormClosed;
                formConPrecios.MdiParent = this;
                formConPrecios.Dock = DockStyle.Fill;
                formConPrecios.Show();
            }
            else
            {
                formConPrecios.Activate(); 
            }
        }

        private void FormConPrecios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formConPrecios = null;
        }

        private void Btn_CError_Click(object sender, EventArgs e)
        {
            if (formConError == null)
            {
                formConError = new FormConError();
                formConError.FormClosed += FormConPrecios_FormClosed;
                formConError.MdiParent = this;
                formConError.Dock = DockStyle.Fill;
                formConError.Show();
            }
            else
            {
                formConError.Activate();
            }
        }

        private void FormConError_FormClosed(object sender, FormClosedEventArgs e)
        {
            formConError.Show();
        }
    }
}
