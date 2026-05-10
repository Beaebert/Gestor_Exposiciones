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
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
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

                    // Para control, se puede deshabilitar el botón de "Ingresar" para que no se vuelva a loguear estando logueado
                    this.ingresarToolStripMenuItem.Enabled = false;
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
