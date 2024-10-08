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
    public partial class RegistrarAlumno : Form
    {
        public RegistrarAlumno()
        {
            InitializeComponent();
        }
        
        private void btnSubir_Click(object sender, EventArgs e)
        {

            Alumnos alumno = new Alumnos() 
            { 
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Matricula = txtMatricula.Text,
            };

            Response resp = Central.SubirAlumno(alumno);
            if (resp.Codigo == 1)
            {
                MessageBox.Show(resp.Mensaje, "Exito!");
            }
            else if (resp.Codigo == 2)
            {
                MessageBox.Show(resp.Mensaje, "Error!");
            }
        }
    }
}
