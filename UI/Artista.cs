using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Artista : Form
    {
        public Artista()
        {
            InitializeComponent();
        }

        private void cancelarArtista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarArtista_Click(object sender, EventArgs e)
        {
            try
            {
                //toma los datos
                string nombre = textNombreArtista.Text;
                string nacionalidad = txtNacionalidadArtista.Text;
                string bio = txtBioArtista.Text;

                //valida que este el nombre escrito
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del artista es obligatorio.");
                    return;
                }

               
                MessageBox.Show("Artista guardado correctamente.");
                this.Close(); // Cierra la ventana tras el éxito
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
