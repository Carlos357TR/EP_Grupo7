namespace EP_Grupo7
{
    partial class FrmVerRegistros
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
            dgvRegistroUsuario = new DataGridView();
            dgvNombre = new DataGridViewTextBoxColumn();
            dgvApellido = new DataGridViewTextBoxColumn();
            dgvDNI = new DataGridViewTextBoxColumn();
            dgvNumeroTelefonico = new DataGridViewTextBoxColumn();
            dgvCorreoElectronico = new DataGridViewTextBoxColumn();
            dgvNombreUsuario = new DataGridViewTextBoxColumn();
            dgvContrasena = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            dgvRegistroReserva = new DataGridView();
            lblTitulo = new Label();
            dgvDiaEstadia = new DataGridViewTextBoxColumn();
            dgvTipoHabitacion = new DataGridViewTextBoxColumn();
            dgvCantidadHuesped = new DataGridViewTextBoxColumn();
            dgvNumHabitacion = new DataGridViewTextBoxColumn();
            dgvMetodoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroReserva).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistroUsuario
            // 
            dgvRegistroUsuario.AllowUserToAddRows = false;
            dgvRegistroUsuario.AllowUserToDeleteRows = false;
            dgvRegistroUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroUsuario.Columns.AddRange(new DataGridViewColumn[] { dgvNombre, dgvApellido, dgvDNI, dgvNumeroTelefonico, dgvCorreoElectronico, dgvNombreUsuario, dgvContrasena });
            dgvRegistroUsuario.Location = new Point(12, 50);
            dgvRegistroUsuario.Name = "dgvRegistroUsuario";
            dgvRegistroUsuario.ReadOnly = true;
            dgvRegistroUsuario.Size = new Size(743, 150);
            dgvRegistroUsuario.TabIndex = 39;
            // 
            // dgvNombre
            // 
            dgvNombre.HeaderText = "Nombres:";
            dgvNombre.Name = "dgvNombre";
            dgvNombre.ReadOnly = true;
            // 
            // dgvApellido
            // 
            dgvApellido.HeaderText = "Apellidos:";
            dgvApellido.Name = "dgvApellido";
            dgvApellido.ReadOnly = true;
            // 
            // dgvDNI
            // 
            dgvDNI.HeaderText = "DNI:";
            dgvDNI.Name = "dgvDNI";
            dgvDNI.ReadOnly = true;
            // 
            // dgvNumeroTelefonico
            // 
            dgvNumeroTelefonico.HeaderText = "Número Telefónico:";
            dgvNumeroTelefonico.Name = "dgvNumeroTelefonico";
            dgvNumeroTelefonico.ReadOnly = true;
            // 
            // dgvCorreoElectronico
            // 
            dgvCorreoElectronico.HeaderText = "Correo Electrónico:";
            dgvCorreoElectronico.Name = "dgvCorreoElectronico";
            dgvCorreoElectronico.ReadOnly = true;
            // 
            // dgvNombreUsuario
            // 
            dgvNombreUsuario.HeaderText = "Nombre de Usuario:";
            dgvNombreUsuario.Name = "dgvNombreUsuario";
            dgvNombreUsuario.ReadOnly = true;
            // 
            // dgvContrasena
            // 
            dgvContrasena.HeaderText = "Contraseña:";
            dgvContrasena.Name = "dgvContrasena";
            dgvContrasena.ReadOnly = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(252, 397);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(251, 115);
            btnActualizar.TabIndex = 40;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // dgvRegistroReserva
            // 
            dgvRegistroReserva.AllowUserToAddRows = false;
            dgvRegistroReserva.AllowUserToDeleteRows = false;
            dgvRegistroReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroReserva.Columns.AddRange(new DataGridViewColumn[] { dgvDiaEstadia, dgvTipoHabitacion, dgvCantidadHuesped, dgvNumHabitacion, dgvMetodoPago });
            dgvRegistroReserva.Location = new Point(12, 223);
            dgvRegistroReserva.Name = "dgvRegistroReserva";
            dgvRegistroReserva.ReadOnly = true;
            dgvRegistroReserva.Size = new Size(543, 150);
            dgvRegistroReserva.TabIndex = 41;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(314, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 25);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "REGISTROS";
            // 
            // dgvDiaEstadia
            // 
            dgvDiaEstadia.HeaderText = "Días de Estadía:";
            dgvDiaEstadia.Name = "dgvDiaEstadia";
            dgvDiaEstadia.ReadOnly = true;
            // 
            // dgvTipoHabitacion
            // 
            dgvTipoHabitacion.HeaderText = "Tipo de Habitación:";
            dgvTipoHabitacion.Name = "dgvTipoHabitacion";
            dgvTipoHabitacion.ReadOnly = true;
            // 
            // dgvCantidadHuesped
            // 
            dgvCantidadHuesped.HeaderText = "Cantidad de huéspedes:";
            dgvCantidadHuesped.Name = "dgvCantidadHuesped";
            dgvCantidadHuesped.ReadOnly = true;
            // 
            // dgvNumHabitacion
            // 
            dgvNumHabitacion.HeaderText = "Número de habitación:";
            dgvNumHabitacion.Name = "dgvNumHabitacion";
            dgvNumHabitacion.ReadOnly = true;
            // 
            // dgvMetodoPago
            // 
            dgvMetodoPago.HeaderText = "Método de Pago:";
            dgvMetodoPago.Name = "dgvMetodoPago";
            dgvMetodoPago.ReadOnly = true;
            // 
            // FrmVerRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 532);
            Controls.Add(lblTitulo);
            Controls.Add(dgvRegistroReserva);
            Controls.Add(btnActualizar);
            Controls.Add(dgvRegistroUsuario);
            Name = "FrmVerRegistros";
            Text = "Ver Registros";
            ((System.ComponentModel.ISupportInitialize)dgvRegistroUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistroUsuario;
        private DataGridViewTextBoxColumn dgvNombre;
        private DataGridViewTextBoxColumn dgvApellido;
        private DataGridViewTextBoxColumn dgvDNI;
        private DataGridViewTextBoxColumn dgvNumeroTelefonico;
        private DataGridViewTextBoxColumn dgvCorreoElectronico;
        private DataGridViewTextBoxColumn dgvNombreUsuario;
        private DataGridViewTextBoxColumn dgvContrasena;
        private Button btnActualizar;
        private DataGridView dgvRegistroReserva;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn dgvDiaEstadia;
        private DataGridViewTextBoxColumn dgvTipoHabitacion;
        private DataGridViewTextBoxColumn dgvCantidadHuesped;
        private DataGridViewTextBoxColumn dgvNumHabitacion;
        private DataGridViewTextBoxColumn dgvMetodoPago;
    }
}