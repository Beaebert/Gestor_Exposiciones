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
    }
}
