namespace UI
{
    partial class Muestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muestra));
            groupBox1 = new GroupBox();
            Espacio = new GroupBox();
            TituloMuestra = new TextBox();
            nombreEspacio = new TextBox();
            txtDescripcionMuestra = new TextBox();
            direccionEspacio = new TextBox();
            numericCapacidad = new NumericUpDown();
            dateTimeInicio = new DateTimePicker();
            dateTimeCierre = new DateTimePicker();
            FechaInicio = new Label();
            FechaCierre = new Label();
            CapacidadEspacio = new Label();
            guardarMuestra = new Button();
            cancelarMuestra = new Button();
            groupBox1.SuspendLayout();
            Espacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FechaCierre);
            groupBox1.Controls.Add(FechaInicio);
            groupBox1.Controls.Add(dateTimeCierre);
            groupBox1.Controls.Add(dateTimeInicio);
            groupBox1.Controls.Add(txtDescripcionMuestra);
            groupBox1.Controls.Add(TituloMuestra);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Muestra";
            // 
            // Espacio
            // 
            Espacio.Controls.Add(CapacidadEspacio);
            Espacio.Controls.Add(numericCapacidad);
            Espacio.Controls.Add(direccionEspacio);
            Espacio.Controls.Add(nombreEspacio);
            Espacio.Location = new Point(23, 251);
            Espacio.Name = "Espacio";
            Espacio.Size = new Size(589, 200);
            Espacio.TabIndex = 1;
            Espacio.TabStop = false;
            Espacio.Text = "Espacio";
            // 
            // TituloMuestra
            // 
            TituloMuestra.Location = new Point(16, 37);
            TituloMuestra.Name = "TituloMuestra";
            TituloMuestra.PlaceholderText = "Escriba el Titulo aquí";
            TituloMuestra.Size = new Size(226, 27);
            TituloMuestra.TabIndex = 0;
            // 
            // nombreEspacio
            // 
            nombreEspacio.Location = new Point(16, 44);
            nombreEspacio.Name = "nombreEspacio";
            nombreEspacio.PlaceholderText = "Escriba el nombre del lugar aquí";
            nombreEspacio.Size = new Size(380, 27);
            nombreEspacio.TabIndex = 1;
            // 
            // txtDescripcionMuestra
            // 
            txtDescripcionMuestra.Location = new Point(16, 100);
            txtDescripcionMuestra.Multiline = true;
            txtDescripcionMuestra.Name = "txtDescripcionMuestra";
            txtDescripcionMuestra.PlaceholderText = "Escriba la descripción de la muestra aquí";
            txtDescripcionMuestra.ScrollBars = ScrollBars.Vertical;
            txtDescripcionMuestra.Size = new Size(521, 81);
            txtDescripcionMuestra.TabIndex = 1;
            // 
            // direccionEspacio
            // 
            direccionEspacio.Location = new Point(16, 114);
            direccionEspacio.Name = "direccionEspacio";
            direccionEspacio.PlaceholderText = "Escriba la dirección aquí";
            direccionEspacio.Size = new Size(380, 27);
            direccionEspacio.TabIndex = 2;
            // 
            // numericCapacidad
            // 
            numericCapacidad.Location = new Point(428, 114);
            numericCapacidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericCapacidad.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericCapacidad.Name = "numericCapacidad";
            numericCapacidad.Size = new Size(150, 27);
            numericCapacidad.TabIndex = 3;
            numericCapacidad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(552, 46);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(306, 27);
            dateTimeInicio.TabIndex = 2;
            // 
            // dateTimeCierre
            // 
            dateTimeCierre.Location = new Point(552, 122);
            dateTimeCierre.Name = "dateTimeCierre";
            dateTimeCierre.Size = new Size(306, 27);
            dateTimeCierre.TabIndex = 3;
            // 
            // FechaInicio
            // 
            FechaInicio.AutoSize = true;
            FechaInicio.Location = new Point(620, 23);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(108, 20);
            FechaInicio.TabIndex = 4;
            FechaInicio.Text = "Fecha de Inicio";
            // 
            // FechaCierre
            // 
            FechaCierre.AutoSize = true;
            FechaCierre.Location = new Point(620, 88);
            FechaCierre.Name = "FechaCierre";
            FechaCierre.Size = new Size(111, 20);
            FechaCierre.TabIndex = 5;
            FechaCierre.Text = "Fecha de Cierre";
            // 
            // CapacidadEspacio
            // 
            CapacidadEspacio.AutoSize = true;
            CapacidadEspacio.Location = new Point(416, 80);
            CapacidadEspacio.Name = "CapacidadEspacio";
            CapacidadEspacio.Size = new Size(162, 20);
            CapacidadEspacio.TabIndex = 6;
            CapacidadEspacio.Text = "Capacidad de Personas";
            // 
            // guardarMuestra
            // 
            guardarMuestra.Location = new Point(720, 293);
            guardarMuestra.Name = "guardarMuestra";
            guardarMuestra.Size = new Size(94, 29);
            guardarMuestra.TabIndex = 2;
            guardarMuestra.Text = "Guardar";
            guardarMuestra.UseVisualStyleBackColor = true;
            // 
            // cancelarMuestra
            // 
            cancelarMuestra.Location = new Point(720, 375);
            cancelarMuestra.Name = "cancelarMuestra";
            cancelarMuestra.Size = new Size(94, 29);
            cancelarMuestra.TabIndex = 3;
            cancelarMuestra.Text = "Cancelar";
            cancelarMuestra.UseVisualStyleBackColor = true;
            cancelarMuestra.Click += cancelarMuestra_Click;
            // 
            // Muestra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 526);
            Controls.Add(cancelarMuestra);
            Controls.Add(guardarMuestra);
            Controls.Add(Espacio);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Muestra";
            Text = "Muestra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Espacio.ResumeLayout(false);
            Espacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox Espacio;
        private TextBox TituloMuestra;
        private TextBox txtDescripcionMuestra;
        private TextBox direccionEspacio;
        private TextBox nombreEspacio;
        private Label FechaCierre;
        private Label FechaInicio;
        private DateTimePicker dateTimeCierre;
        private DateTimePicker dateTimeInicio;
        private Label CapacidadEspacio;
        private NumericUpDown numericCapacidad;
        private Button guardarMuestra;
        private Button cancelarMuestra;
    }
}