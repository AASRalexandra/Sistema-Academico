﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Formulario5 form = new Formulario5();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Formulario5 form = new Formulario5();
            form.Show();
        }
    }
}
