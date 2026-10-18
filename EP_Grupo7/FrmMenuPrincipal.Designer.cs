namespace EP_Grupo7
{
    partial class FrmMenuPrincipal
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
            menuStrip1 = new MenuStrip();
            menuItemUsuario = new ToolStripMenuItem();
            subMenuIniciarSesion = new ToolStripMenuItem();
            subMenuRegistrar = new ToolStripMenuItem();
            menuItemRegistroReserva = new ToolStripMenuItem();
            menuItemVerRegistro = new ToolStripMenuItem();
            menuItemSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemUsuario, menuItemRegistroReserva, menuItemVerRegistro, menuItemSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(394, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemUsuario
            // 
            menuItemUsuario.DropDownItems.AddRange(new ToolStripItem[] { subMenuIniciarSesion, subMenuRegistrar });
            menuItemUsuario.Name = "menuItemUsuario";
            menuItemUsuario.Size = new Size(59, 20);
            menuItemUsuario.Text = "Usuario";
            // 
            // subMenuIniciarSesion
            // 
            subMenuIniciarSesion.Name = "subMenuIniciarSesion";
            subMenuIniciarSesion.Size = new Size(143, 22);
            subMenuIniciarSesion.Text = "Iniciar Sesión";
            subMenuIniciarSesion.Click += subMenuIniciarSesion_Click;
            // 
            // subMenuRegistrar
            // 
            subMenuRegistrar.Name = "subMenuRegistrar";
            subMenuRegistrar.Size = new Size(143, 22);
            subMenuRegistrar.Text = "Registrar";
            subMenuRegistrar.Click += subMenuRegistrar_Click;
            // 
            // menuItemRegistroReserva
            // 
            menuItemRegistroReserva.Name = "menuItemRegistroReserva";
            menuItemRegistroReserva.Size = new Size(118, 20);
            menuItemRegistroReserva.Text = "Registro de reserva";
            menuItemRegistroReserva.Click += menuItemRegistroReserva_Click;
            // 
            // menuItemVerRegistro
            // 
            menuItemVerRegistro.Name = "menuItemVerRegistro";
            menuItemVerRegistro.Size = new Size(83, 20);
            menuItemVerRegistro.Text = "Ver registros";
            menuItemVerRegistro.Click += menuItemVerRegistro_Click;
            // 
            // menuItemSalir
            // 
            menuItemSalir.Name = "menuItemSalir";
            menuItemSalir.Size = new Size(41, 20);
            menuItemSalir.Text = "Salir";
            menuItemSalir.Click += menuItemSalir_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 223);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemUsuario;
        private ToolStripMenuItem subMenuIniciarSesion;
        private ToolStripMenuItem subMenuRegistrar;
        private ToolStripMenuItem menuItemRegistroReserva;
        private ToolStripMenuItem menuItemVerRegistro;
        private ToolStripMenuItem menuItemSalir;
    }
}