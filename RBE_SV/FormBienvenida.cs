﻿using System;
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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();

        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
             
            Lbl_Bienvenida.Text ="Bienvenido, a tu sistema de ventas.";

        }
    }
}
