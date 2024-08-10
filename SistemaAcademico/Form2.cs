using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAcademico
{
    public partial class Formulario2 : Form
    {
        public string NombreCurso { get; set; }
        public string Nivel { get; set; }
        public Formulario2()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Formulario3 form = new Formulario3();
            form.Show();

        }

        private void Formulario2_Load(object sender, EventArgs e)
        {
            
        }
    
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Formulario2 form = new Formulario2();
            form.Show();



        }
    }
}
