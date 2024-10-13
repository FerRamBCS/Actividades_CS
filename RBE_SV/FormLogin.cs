using RBE_SV.Entidades;
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
    public partial class FRM_login : Form
    {
        public FRM_login()
        {
            InitializeComponent();
        }

        private void Lbl_Bienvenidamssg_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios()
            {
                Usuario = Txt_Usuario.Text,
                Contra = Txt_Contra.Text,
            };
            Response response = Central.IniciarSesion(usuarios);

            if (response.Codigo == 1)
            {
                MessageBox.Show(response.Mensaje, "Inicio Exitoso");
                // Instanciar el Form menu
                FormMain _Menu = new FormMain();
                _Menu.Show();

                //Oculta el login
                this.Hide();

            }
            else if (response.Codigo == 2)
            {
                MessageBox.Show(response.Mensaje, "Error De inicio");
            }

        }

    }

}
