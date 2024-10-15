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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        bool MenuExpand = false;
        private void T_Menu_Tick(object sender, EventArgs e)
        {
            // Definir las alturas máxima y mínima
            int maxHeight = 170; // Altura máxima deseada
            int minHeight = 50;  // Altura mínima deseada
            int increment = 10;  // Incremento en la altura

            if (MenuExpand == false)
            {
                // Expandir el menú
                FLP_MConntainer.Height += increment;
                if (FLP_MConntainer.Height >= maxHeight)
                {
                    FLP_MConntainer.Height = maxHeight; // Asegúrate de que no exceda la altura máxima
                    T_Menu.Stop();
                    MenuExpand = true;
                }
            }
            else
            {
                // Contraer el menú
                FLP_MConntainer.Height -= increment;
                if (FLP_MConntainer.Height <= minHeight)
                {
                    FLP_MConntainer.Height = minHeight; // Asegúrate de que no baje de la altura mínima
                    T_Menu.Stop();
                    MenuExpand = false;
                }
            }

        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            T_Menu.Start();// Inicia el temporizador al hacer clic
        }

        bool sideBarExpand = true;

        private void T_SB_Tick(object sender, EventArgs e)
        {
            // Si la barra lateral está expandida
            if (sideBarExpand)
            {
                FLP_Main.Width -= 10; // Contraer la barra
                if (FLP_Main.Width <= 50)
                {
                    FLP_Main.Width = 50;
                    sideBarExpand = false; // Cambia el estado a contraído
                    T_SB.Stop(); // Detén el temporizador
                }
            }
            else // Si la barra lateral está contraída
            {
                FLP_Main.Width += 10; // Expandir la barra
                if (FLP_Main.Width >= 200)
                {
                    FLP_Main.Width = 200;
                    sideBarExpand = true; // Cambia el estado a expandido
                    T_SB.Stop(); // Detén el temporizador
                }
            }
        }

        private void Btn_Opc_Click(object sender, EventArgs e)
        {
            T_SB.Start();// Inicia el temporizador al hacer clic
        }

        private void FLP_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
