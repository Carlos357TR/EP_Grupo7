namespace EP_Grupo7
{
    partial class FrmRegister
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
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            txtConfirmarContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtNumeroTelefonico = new TextBox();
            txtNombre = new TextBox();
            lblCorreoElectronico = new Label();
            lblNumeroTelefonico = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(182, 241);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(272, 23);
            txtNombreUsuario.TabIndex = 37;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(12, 243);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(148, 21);
            lblNombreUsuario.TabIndex = 36;
            lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(182, 323);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(272, 23);
            txtConfirmarContrasena.TabIndex = 35;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.Location = new Point(12, 325);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(164, 21);
            lblConfirmarContrasena.TabIndex = 34;
            lblConfirmarContrasena.Text = "Confirmar contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(182, 281);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(272, 23);
            txtContrasena.TabIndex = 33;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = SystemColors.ControlText;
            lblContrasena.Location = new Point(12, 283);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(92, 21);
            lblContrasena.TabIndex = 32;
            lblContrasena.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(247, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 110);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(67, 382);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(148, 110);
            btnRegistrar.TabIndex = 30;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(180, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(274, 23);
            txtApellido.TabIndex = 29;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(180, 129);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(274, 23);
            txtDNI.TabIndex = 28;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(182, 205);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(272, 23);
            txtCorreoElectronico.TabIndex = 27;
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.Location = new Point(180, 168);
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.Size = new Size(274, 23);
            txtNumeroTelefonico.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(180, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(274, 23);
            txtNombre.TabIndex = 25;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Font = new Font("Segoe UI", 12F);
            lblCorreoElectronico.ForeColor = SystemColors.ControlText;
            lblCorreoElectronico.Location = new Point(12, 205);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(141, 21);
            lblCorreoElectronico.TabIndex = 24;
            lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblNumeroTelefonico
            // 
            lblNumeroTelefonico.AutoSize = true;
            lblNumeroTelefonico.Font = new Font("Segoe UI", 12F);
            lblNumeroTelefonico.ForeColor = SystemColors.ControlText;
            lblNumeroTelefonico.Location = new Point(10, 168);
            lblNumeroTelefonico.Name = "lblNumeroTelefonico";
            lblNumeroTelefonico.Size = new Size(143, 21);
            lblNumeroTelefonico.TabIndex = 23;
            lblNumeroTelefonico.Text = "Número telefónico:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 12F);
            lblDNI.ForeColor = SystemColors.ControlText;
            lblDNI.Location = new Point(10, 129);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 21);
            lblDNI.TabIndex = 22;
            lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.ForeColor = SystemColors.ControlText;
            lblApellido.Location = new Point(10, 95);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 21);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(10, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(125, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 25);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "REGISTRO DE USUARIOS";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 532);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNumeroTelefonico);
            Controls.Add(txtNombre);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblNumeroTelefonico);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmRegister";
            Text = "Registrar Nuevo Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private TextBox txtConfirmarContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtCorreoElectronico;
        private TextBox txtNumeroTelefonico;
        private TextBox txtNombre;
        private Label lblCorreoElectronico;
        private Label lblNumeroTelefonico;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTitulo;
    }
}