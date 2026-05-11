
namespace TrabajoIntegradorEnvios
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            muestraToolStripMenuItem = new ToolStripMenuItem();
            artistaToolStripMenuItem = new ToolStripMenuItem();
            obraToolStripMenuItem = new ToolStripMenuItem();
            cuadroToolStripMenuItem = new ToolStripMenuItem();
            informeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, crearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(224, 26);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += IngresarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { muestraToolStripMenuItem, artistaToolStripMenuItem, obraToolStripMenuItem, informeToolStripMenuItem });
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(58, 24);
            crearToolStripMenuItem.Text = "Crear";
            // 
            // muestraToolStripMenuItem
            // 
            muestraToolStripMenuItem.Name = "muestraToolStripMenuItem";
            muestraToolStripMenuItem.Size = new Size(224, 26);
            muestraToolStripMenuItem.Text = "Muestra";
            // 
            // artistaToolStripMenuItem
            // 
            artistaToolStripMenuItem.Name = "artistaToolStripMenuItem";
            artistaToolStripMenuItem.Size = new Size(224, 26);
            artistaToolStripMenuItem.Text = "Artista";
            // 
            // obraToolStripMenuItem
            // 
            obraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuadroToolStripMenuItem });
            obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            obraToolStripMenuItem.Size = new Size(224, 26);
            obraToolStripMenuItem.Text = "Obra";
            // 
            // cuadroToolStripMenuItem
            // 
            cuadroToolStripMenuItem.Name = "cuadroToolStripMenuItem";
            cuadroToolStripMenuItem.Size = new Size(224, 26);
            cuadroToolStripMenuItem.Text = "Cuadro";
            // 
            // informeToolStripMenuItem
            // 
            informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            informeToolStripMenuItem.Size = new Size(224, 26);
            informeToolStripMenuItem.Text = "Informe";
            informeToolStripMenuItem.Click += this.InformeToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 591);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Gestor Exposiciones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem muestraToolStripMenuItem;
        private ToolStripMenuItem artistaToolStripMenuItem;
        private ToolStripMenuItem obraToolStripMenuItem;
        private ToolStripMenuItem cuadroToolStripMenuItem;
        private ToolStripMenuItem informeToolStripMenuItem;
    }
}
