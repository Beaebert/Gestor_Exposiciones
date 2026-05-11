using System.Windows.Forms;
using System.Drawing;
using UI;

namespace TrabajoIntegradorEnvios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void IngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log ventanaLogin = new Log(); //Toma el formulario Log y asigna a ventanaLogin
            ventanaLogin.MdiParent = this; //dice que el formulario Menu es el padre que lo contiene
            ventanaLogin.Show();   //muestra

            using (Log ventanaLog = new Log())
            {
                if (ventanaLogin.ShowDialog() == DialogResult.OK)
                {
                    this.menuMuestras.Enabled = true;
                    this.menuArtistas.Enabled = true;

                    //Deshabilitar el botón de "Ingresar" para que no se vuelva a loguear estando logueado
                    this.ingresarToolStripMenuItem.Enabled = false;
                }
            }
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
