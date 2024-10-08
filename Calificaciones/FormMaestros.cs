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
    public partial class FormMaestros : Form
    {
        public FormMaestros()
        {
            InitializeComponent();
        }

        private void btnRMaestro_Click(object sender, EventArgs e)
        {
            RegistrarMaestro _registrarMaestro = new RegistrarMaestro();
            _registrarMaestro.Show();
        }

        private void FormMaestros_Load(object sender, EventArgs e)
        {
            dgvMaestros.DataSource = Central.CargarMaestros();
        }
    }
}
