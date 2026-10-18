namespace EP_Grupo7
{
    partial class FrmRegistroReserva
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
            btnCancelar = new Button();
            btnRegistrar = new Button();
            cmbMetodoPago = new ComboBox();
            txtCantidadHuesped = new TextBox();
            txtDiaEstadia = new TextBox();
            lblMetodoPago = new Label();
            lblCantidadHuesped = new Label();
            lblTipoHabitacion = new Label();
            cmbTipoHabitacion = new ComboBox();
            lblDiaEstadia = new Label();
            lblTitulo = new Label();
            txtNumHabitacion = new TextBox();
            lblNumHabitacion = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 84);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(103, 300);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 84);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbMetodoPago.Location = new Point(239, 189);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(233, 23);
            cmbMetodoPago.TabIndex = 20;
            // 
            // txtCantidadHuesped
            // 
            txtCantidadHuesped.Location = new Point(239, 127);
            txtCantidadHuesped.Name = "txtCantidadHuesped";
            txtCantidadHuesped.Size = new Size(233, 23);
            txtCantidadHuesped.TabIndex = 19;
            // 
            // txtDiaEstadia
            // 
            txtDiaEstadia.Location = new Point(239, 54);
            txtDiaEstadia.Name = "txtDiaEstadia";
            txtDiaEstadia.Size = new Size(233, 23);
            txtDiaEstadia.TabIndex = 18;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 12F);
            lblMetodoPago.Location = new Point(9, 191);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(123, 21);
            lblMetodoPago.TabIndex = 17;
            lblMetodoPago.Text = "Método de Pago";
            // 
            // lblCantidadHuesped
            // 
            lblCantidadHuesped.AutoSize = true;
            lblCantidadHuesped.Font = new Font("Segoe UI", 12F);
            lblCantidadHuesped.Location = new Point(9, 127);
            lblCantidadHuesped.Name = "lblCantidadHuesped";
            lblCantidadHuesped.Size = new Size(176, 21);
            lblCantidadHuesped.TabIndex = 16;
            lblCantidadHuesped.Text = "Cantidad de Huéspedes:";
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Font = new Font("Segoe UI", 12F);
            lblTipoHabitacion.Location = new Point(9, 90);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(140, 21);
            lblTipoHabitacion.TabIndex = 15;
            lblTipoHabitacion.Text = "Tipo de habitación:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Individual", "Doble", "Matrimonial", "Familiar" });
            cmbTipoHabitacion.Location = new Point(239, 92);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(233, 23);
            cmbTipoHabitacion.TabIndex = 14;
            // 
            // lblDiaEstadia
            // 
            lblDiaEstadia.AutoSize = true;
            lblDiaEstadia.Font = new Font("Segoe UI", 12F);
            lblDiaEstadia.Location = new Point(9, 56);
            lblDiaEstadia.Name = "lblDiaEstadia";
            lblDiaEstadia.Size = new Size(117, 21);
            lblDiaEstadia.TabIndex = 13;
            lblDiaEstadia.Text = "Días de Estadía:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(119, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(216, 25);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "REGISTRO DE RESERVA";
            // 
            // txtNumHabitacion
            // 
            txtNumHabitacion.Location = new Point(239, 160);
            txtNumHabitacion.Name = "txtNumHabitacion";
            txtNumHabitacion.Size = new Size(233, 23);
            txtNumHabitacion.TabIndex = 27;
            // 
            // lblNumHabitacion
            // 
            lblNumHabitacion.AutoSize = true;
            lblNumHabitacion.Font = new Font("Segoe UI", 12F);
            lblNumHabitacion.Location = new Point(9, 160);
            lblNumHabitacion.Name = "lblNumHabitacion";
            lblNumHabitacion.Size = new Size(168, 21);
            lblNumHabitacion.TabIndex = 26;
            lblNumHabitacion.Text = "Número de habitación:";
            // 
            // FrmRegistroReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 405);
            Controls.Add(txtNumHabitacion);
            Controls.Add(lblNumHabitacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbMetodoPago);
            Controls.Add(txtCantidadHuesped);
            Controls.Add(txtDiaEstadia);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblCantidadHuesped);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(lblDiaEstadia);
            Controls.Add(lblTitulo);
            Name = "FrmRegistroReserva";
            Text = "Registro de Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private ComboBox cmbMetodoPago;
        private TextBox txtCantidadHuesped;
        private TextBox txtDiaEstadia;
        private Label lblMetodoPago;
        private Label lblCantidadHuesped;
        private Label lblTipoHabitacion;
        private ComboBox cmbTipoHabitacion;
        private Label lblDiaEstadia;
        private Label lblTitulo;
        private TextBox txtNumHabitacion;
        private Label lblNumHabitacion;
    }
}