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
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnAlumno_Click(object sender, EventArgs e)
        {

            FormAlumno _alumno = new FormAlumno();
            _alumno.Show();

        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            FormMateria _materia = new FormMateria();
            _materia.Show();
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            FormMaestros _maestro = new FormMaestros();
            _maestro.Show();
        }

        private void btnRCalif_Click(object sender, EventArgs e)
        {
            FormCalificaciones _calif = new FormCalificaciones();
            _calif.Show();
        }
    }
}