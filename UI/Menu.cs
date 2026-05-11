using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TrabajoIntegradorGestionDeExposiciones.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MuestraToolStripMenuItem.Enabled = false;
            ArtistaToolStripMenuItem.Enabled = false;
        }



        private void IngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Log ventanaLog = new Log())
            {
                if (ventanaLog.ShowDialog() == DialogResult.OK)
                {
                    this.MuestraToolStripMenuItem.Enabled = true;
                    this.ArtistaToolStripMenuItem.Enabled = true;

                    //Deshabilitar el botón de "Ingresar" para que no se vuelva a loguear estando logueado
                    this.IngresarToolStripMenuItem.Enabled = false;
                }
            }
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra el formulario principal; si es la ventana principal de la app, la aplicación terminará.
            Close();
        }

        private void InformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "InformeExposiciones.txt";
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine("--- REPORTE DE GESTOR DE EXPOSICIONES ---");
                writer.WriteLine("Fecha: " + DateTime.Now.ToString());
                writer.WriteLine("Total de Muestras Activas: 5");
                writer.WriteLine("Artistas Registrados: 12");
            }
            MessageBox.Show("Informe generado con éxito en la carpeta del programa.");
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // Crear la instancia principal, fijar la fuente y ejecutarla
            var mainForm = new Menu();
            mainForm.Font = new Font("Segoe UI", 9F);
            Application.Run(mainForm);
        }
    }
}
