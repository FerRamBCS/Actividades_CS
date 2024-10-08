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
    public partial class FormAlumno : Form
    {
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistrarAlumno _registrarAlumno = new RegistrarAlumno();
            _registrarAlumno.Show();
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            dgv_VistaAlumnos.DataSource = Central.CargarAlumnos();
        }
    }
}
