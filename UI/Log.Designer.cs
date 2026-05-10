namespace UI
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            button1 = new Button();
            button2 = new Button();
            labelUsuario = new Label();
            labelPassword = new Label();
            textUsuarioIngreso = new TextBox();
            textPasswordIngreso = new TextBox();
            labelRegistro = new Label();
            textPasswordRegistro = new TextBox();
            textUsuarioRegistro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(351, 155);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(351, 382);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(186, 51);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(498, 51);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textUsuarioIngreso
            // 
            textUsuarioIngreso.Location = new Point(186, 94);
            textUsuarioIngreso.Name = "textUsuarioIngreso";
            textUsuarioIngreso.Size = new Size(125, 27);
            textUsuarioIngreso.TabIndex = 4;
            // 
            // textPasswordIngreso
            // 
            textPasswordIngreso.Location = new Point(498, 94);
            textPasswordIngreso.Name = "textPasswordIngreso";
            textPasswordIngreso.Size = new Size(125, 27);
            textPasswordIngreso.TabIndex = 5;
            textPasswordIngreso.UseSystemPasswordChar = true;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Location = new Point(330, 216);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(140, 20);
            labelRegistro.TabIndex = 6;
            labelRegistro.Text = "Si no tienes usuario:";
            // 
            // textPasswordRegistro
            // 
            textPasswordRegistro.Location = new Point(498, 308);
            textPasswordRegistro.Name = "textPasswordRegistro";
            textPasswordRegistro.Size = new Size(125, 27);
            textPasswordRegistro.TabIndex = 10;
            // 
            // textUsuarioRegistro
            // 
            textUsuarioRegistro.Location = new Point(186, 308);
            textUsuarioRegistro.Name = "textUsuarioRegistro";
            textUsuarioRegistro.Size = new Size(125, 27);
            textUsuarioRegistro.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 265);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 265);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Usuario";
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textPasswordRegistro);
            Controls.Add(textUsuarioRegistro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelRegistro);
            Controls.Add(textPasswordIngreso);
            Controls.Add(textUsuarioIngreso);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Log";
            Text = "Log";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label labelUsuario;
        private Label labelPassword;
        private TextBox textUsuarioIngreso;
        private TextBox textPasswordIngreso;
        private Label labelRegistro;
        private TextBox textPasswordRegistro;
        private TextBox textUsuarioRegistro;
        private Label label1;
        private Label label2;
    }
}