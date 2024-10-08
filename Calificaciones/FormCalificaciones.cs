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
    public partial class FormCalificaciones : Form
    {
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alumnoId = Convert.ToInt32(cbNombre.SelectedValue);
            int materiaId = Convert.ToInt32(cbMateria.SelectedValue);
            decimal calificacion = Convert.ToDecimal(txtCalificacion.Text);

            Response resp = Central.SubirCalificacion(alumnoId, materiaId, calificacion);
            if (resp.Codigo == 1)
            {
                MessageBox.Show(resp.Mensaje, "Éxito!");
            }
            else
            {
                MessageBox.Show(resp.Mensaje, "Error!");
            }
        }

        private void FormCalificaciones_Load(object sender, EventArgs e)
        {
            // Cargar calificaciones en el DataGridView
            dgvCalificacion.DataSource = Central.CargarCalificaciones();

            // Cargar alumnos en el ComboBox cbNombre
            DataTable dtAlumnos = Central.CargarAlumnos();
            cbNombre.DataSource = dtAlumnos;
            cbNombre.DisplayMember = "Nombre"; // Asumiendo que la columna se llama "Nombre" en la tabla de alumnos
            cbNombre.ValueMember = "Id";       // El valor asociado será el Id del alumno

            // Cargar materias en el ComboBox cbMateria
            DataTable dtMaterias = Central.CargarMaterias();
            cbMateria.DataSource = dtMaterias;
            cbMateria.DisplayMember = "Nombre"; // Asumiendo que la columna se llama "Nombre" en la tabla de materias
            cbMateria.ValueMember = "Id";       // El valor asociado será el Id de la materia
        }
    }
}
