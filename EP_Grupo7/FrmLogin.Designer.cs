namespace EP_Grupo7
{
    partial class FrmLogin
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
            btnIngresar = new Button();
            txtNombreUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            lblNombreUsuario = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(144, 150);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(91, 83);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(164, 53);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(198, 23);
            txtNombreUsuario.TabIndex = 10;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(164, 94);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(198, 23);
            txtContrasena.TabIndex = 9;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 12F);
            lblContrasena.Location = new Point(8, 96);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(92, 21);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F);
            lblNombreUsuario.Location = new Point(8, 55);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(150, 21);
            lblNombreUsuario.TabIndex = 7;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(104, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 25);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "INICIO DE SESIÓN";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 266);
            Controls.Add(btnIngresar);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblTitulo);
            Name = "FrmLogin";
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Label lblNombreUsuario;
        private Label lblTitulo;
    }
}