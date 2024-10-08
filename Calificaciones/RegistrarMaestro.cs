using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class RegistrarMaestro : Form
    {
        public RegistrarMaestro()
        {
            InitializeComponent();
        }

        private void btnSubirMaestro_Click(object sender, EventArgs e)
        {
            Maestros maestro = new Maestros()
            {
                NombreMaestro = txtNombreMaestro.Text,
                ApellidoMaestro = txtApellidoMaestro.Text,
                MatriculaMaestro = txtMatriculaMaestro.Text,
            }; 
            Response resp = Central.SubirMaestro(maestro);
            if (resp.Codigo == 1)
            {
                MessageBox.Show(resp.Mensaje, "Éxito!");
            }
            else if (resp.Codigo == 2)
            {
                MessageBox.Show(resp.Mensaje, "Error!");
            }
        }
    }
}
