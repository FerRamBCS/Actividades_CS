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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAlumno_Click(object sender, EventArgs e)
        {

            Alumno _alumno = new Alumno();
            _alumno.Show();

        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Materia _materia = new Materia();
            _materia.Show();
        }
    }
}
