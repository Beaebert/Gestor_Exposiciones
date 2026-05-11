using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UI;

namespace TrabajoIntegradorGestionDeExposiciones.UI
{
    partial class Menu : Form
    {
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            ArchivoToolStripMenuItem = new ToolStripMenuItem();
            IngresarToolStripMenuItem = new ToolStripMenuItem();
            SalirToolStripMenuItem = new ToolStripMenuItem();
            CrearToolStripMenuItem = new ToolStripMenuItem();
            MuestraToolStripMenuItem = new ToolStripMenuItem();
            ArtistaToolStripMenuItem = new ToolStripMenuItem();
            ObraToolStripMenuItem = new ToolStripMenuItem();
            CuadroToolStripMenuItem = new ToolStripMenuItem();
            InformeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ArchivoToolStripMenuItem, CrearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1141, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            ArchivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { IngresarToolStripMenuItem, SalirToolStripMenuItem });
            ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            ArchivoToolStripMenuItem.Size = new Size(73, 24);
            ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // IngresarToolStripMenuItem
            // 
            IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem";
            IngresarToolStripMenuItem.Size = new Size(224, 26);
            IngresarToolStripMenuItem.Text = "Ingresar";
            IngresarToolStripMenuItem.Click += IngresarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            SalirToolStripMenuItem.Size = new Size(224, 26);
            SalirToolStripMenuItem.Text = "Salir";
            SalirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            // 
            // CrearToolStripMenuItem
            // 
            CrearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MuestraToolStripMenuItem, ArtistaToolStripMenuItem, ObraToolStripMenuItem, InformeToolStripMenuItem });
            CrearToolStripMenuItem.Name = "CrearToolStripMenuItem";
            CrearToolStripMenuItem.Size = new Size(58, 24);
            CrearToolStripMenuItem.Text = "Crear";
            // 
            // MuestraToolStripMenuItem
            // 
            MuestraToolStripMenuItem.Name = "MuestraToolStripMenuItem";
            MuestraToolStripMenuItem.Size = new Size(224, 26);
            MuestraToolStripMenuItem.Text = "Muestra";
            // 
            // artistaToolStripMenuItem
            // 
            ArtistaToolStripMenuItem.Name = "ArtistaToolStripMenuItem";
            ArtistaToolStripMenuItem.Size = new Size(224, 26);
            ArtistaToolStripMenuItem.Text = "Artista";
            // 
            // ObraToolStripMenuItem
            // 
            ObraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CuadroToolStripMenuItem });
            ObraToolStripMenuItem.Name = "ObraToolStripMenuItem";
            ObraToolStripMenuItem.Size = new Size(224, 26);
            ObraToolStripMenuItem.Text = "Obra";
            // 
            // CuadroToolStripMenuItem
            // 
            CuadroToolStripMenuItem.Name = "CuadroToolStripMenuItem";
            CuadroToolStripMenuItem.Size = new Size(224, 26);
            CuadroToolStripMenuItem.Text = "Cuadro";
            // 
            // informeToolStripMenuItem
            // 
            InformeToolStripMenuItem.Name = "InformeToolStripMenuItem";
            InformeToolStripMenuItem.Size = new Size(224, 26);
            InformeToolStripMenuItem.Text = "Informe";
            InformeToolStripMenuItem.Click += this.InformeToolStripMenuItem_Click;
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
        private ToolStripMenuItem ArchivoToolStripMenuItem;
        private ToolStripMenuItem IngresarToolStripMenuItem;
        private ToolStripMenuItem SalirToolStripMenuItem;
        private ToolStripMenuItem CrearToolStripMenuItem;
        private ToolStripMenuItem MuestraToolStripMenuItem;
        private ToolStripMenuItem ArtistaToolStripMenuItem;
        private ToolStripMenuItem ObraToolStripMenuItem;
        private ToolStripMenuItem CuadroToolStripMenuItem;
        private ToolStripMenuItem InformeToolStripMenuItem;
    }
}
