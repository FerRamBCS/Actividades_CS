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
    /*
        TAREA 
        En la pantalla de alumnos crear el metodo para cargar alumnos usando Central
        En la pantalla de materias crear el diseño de la pantalla con sus botones y cualquier elemento
        En  la pantalla de materias crear formulario para dar de alta materias y usar central
        En la pantalla de materia crear los metodos que sean necesarios
     */
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
            Materia _materia = new Materia();
            _materia.Show();
        }
    }
}