using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EP_Grupo7
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void subMenuIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void subMenuRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegistroNuevoUsuario = new FrmRegister();
            frmRegistroNuevoUsuario.MdiParent = this;
            frmRegistroNuevoUsuario.Show();
        }

        private void menuItemRegistroReserva_Click(object sender, EventArgs e)
        {
            FrmRegistroReserva frmRegistrarReserva = new FrmRegistroReserva();
            frmRegistrarReserva.MdiParent = this;
            frmRegistrarReserva.Show();
        }

        private void menuItemVerRegistro_Click(object sender, EventArgs e)
        {
            FrmVerRegistros frmVerRegistros = new FrmVerRegistros();
            frmVerRegistros.MdiParent = this;
            frmVerRegistros.Show();
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro(a) de salir?",
                                                     "Confirmar salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
