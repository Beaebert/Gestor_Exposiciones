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
