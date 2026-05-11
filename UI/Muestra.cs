using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Muestra : Form
    {
        public Muestra()
        {
            InitializeComponent();
        }

        private void cancelarMuestra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarMuestra_Click(object sender, EventArgs e)
        {
            try
            {
                //guarda en variables los datos de muestra
                string titulo = TituloMuestra.Text;
                string descripcion = txtDescripcionMuestra.Text;
                DateTime fechaInicio = dateTimeInicio.Value;
                DateTime fechaCierre = dateTimeCierre.Value;

                //guarda en variables los datos de espacio junto con la muestra (el espacio es un componente/parte de la muestra)
                string nombreEsp = nombreEspacio.Text;
                string direccionEsp = direccionEspacio.Text;
                int capacidad = (int)numericCapacidad.Value;

                //validar coherencia entre fechas
                if (fechaCierre <= fechaInicio)
                {
                    MessageBox.Show("La fecha de cierre debe ser posterior a la de inicio.");
                    return;
                }

                MessageBox.Show("Muestra y Espacio guardados correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
