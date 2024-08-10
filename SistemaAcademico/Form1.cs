using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, direccion, provincia, sector, email;
            int telefono, celular, id, matricula;


            nombre = Convert.ToString(txtNombre.Text);
            apellido = Convert.ToString(txtApellido.Text);
            direccion = Convert.ToString(txtDireccion.Text);
            provincia = Convert.ToString(txtProvincia.Text);
            sector = Convert.ToString(txtSector.Text);
            email = Convert.ToString(txtEmail.Text);

            telefono = Convert.ToInt32(txtTelefono.Text);
            celular = Convert.ToInt32(txtCelular.Text);
            id = Convert.ToInt32(txtID.Text);
            matricula = Convert.ToInt32(txtMatricula.Text);


            Formulario2 form = new Formulario2();
            form.Show();





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Formulario2 form = new Formulario2();
            form.Show();
        }
    }
}
