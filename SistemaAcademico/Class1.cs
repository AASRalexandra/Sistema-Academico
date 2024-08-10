using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura el entorno para la aplicación de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lanza el formulario principal de la aplicación (Formulario1)
            Application.Run(new Formulario1());
        }
    }
}

