using System;
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
    public partial class Formulario5 : Form
    {
        public Formulario5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int eva1, eva2, eva3, As, NF;

            eva1 = Convert.ToInt32(txtEva1.Text);
            eva2 = Convert.ToInt32(txtEva2.Text);
            eva3 = Convert.ToInt32(txtEva3.Text);
            As = Convert.ToInt32(txtAS.Text);
            NF = Convert.ToInt32(txtNF.Text);

            NF = (eva1 + eva2 + eva3 + As)/4;
            txtNF.Text = Convert.ToString(NF);


        }
    }
}
