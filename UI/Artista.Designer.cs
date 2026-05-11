namespace UI
{
    partial class Artista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNombreArtista = new TextBox();
            txtBioArtista = new TextBox();
            txtNacionalidadArtista = new TextBox();
            guardarArtista = new Button();
            cancelarArtista = new Button();
            SuspendLayout();
            // 
            // textNombreArtista
            // 
            textNombreArtista.Location = new Point(174, 33);
            textNombreArtista.Name = "textNombreArtista";
            textNombreArtista.PlaceholderText = "Escriba el nombre aquí";
            textNombreArtista.Size = new Size(368, 27);
            textNombreArtista.TabIndex = 0;
            // 
            // txtBioArtista
            // 
            txtBioArtista.Location = new Point(174, 201);
            txtBioArtista.Multiline = true;
            txtBioArtista.Name = "txtBioArtista";
            txtBioArtista.PlaceholderText = "Escriba la breve Bio del Artista aquí";
            txtBioArtista.ScrollBars = ScrollBars.Vertical;
            txtBioArtista.Size = new Size(368, 182);
            txtBioArtista.TabIndex = 1;
            // 
            // txtNacionalidadArtista
            // 
            txtNacionalidadArtista.Location = new Point(174, 111);
            txtNacionalidadArtista.Name = "txtNacionalidadArtista";
            txtNacionalidadArtista.PlaceholderText = "Escriba su nacionalidad aquí";
            txtNacionalidadArtista.Size = new Size(368, 27);
            txtNacionalidadArtista.TabIndex = 2;
            // 
            // guardarArtista
            // 
            guardarArtista.Location = new Point(609, 312);
            guardarArtista.Name = "guardarArtista";
            guardarArtista.Size = new Size(94, 29);
            guardarArtista.TabIndex = 3;
            guardarArtista.Text = "Guardar";
            guardarArtista.UseVisualStyleBackColor = true;
            // 
            // cancelarArtista
            // 
            cancelarArtista.Location = new Point(609, 380);
            cancelarArtista.Name = "cancelarArtista";
            cancelarArtista.Size = new Size(94, 29);
            cancelarArtista.TabIndex = 4;
            cancelarArtista.Text = "Cancelar";
            cancelarArtista.UseVisualStyleBackColor = true;
            cancelarArtista.Click += cancelarArtista_Click;
            // 
            // Artista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarArtista);
            Controls.Add(guardarArtista);
            Controls.Add(txtNacionalidadArtista);
            Controls.Add(txtBioArtista);
            Controls.Add(textNombreArtista);
            Name = "Artista";
            Text = "Artista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombreArtista;
        private TextBox txtBioArtista;
        private TextBox txtNacionalidadArtista;
        private Button guardarArtista;
        private Button cancelarArtista;
    }
}