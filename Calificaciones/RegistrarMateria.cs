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
    public partial class RegistrarMateria : Form
    {
        public RegistrarMateria()
        {
            InitializeComponent();
        }








        //
        private void lblDocenteEncargado_Click(object sender, EventArgs e)
        {
            //MISSCLICK NO ESCRIBIR AQUI
        }
        //
        private void btnSubirMateria_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias() 
            { 
                NombreM = txtMateria.Text,
                ClaveM = txtClaveMateria.Text,
                CalificacionM = (float)Convert.ToDecimal(txtCalificacion.Text),
            };
            Central.SubirMateria(materia);
        }
    }
}
