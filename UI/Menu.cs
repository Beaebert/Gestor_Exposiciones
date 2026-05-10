using System.Windows.Forms;
using System.Drawing;

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
            var ingresarForm = new Ingresar();
            ingresarForm.ShowDialog();
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
