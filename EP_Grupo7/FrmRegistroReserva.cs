using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EP_Grupo7
{
    public partial class FrmRegistroReserva : Form
    {
        private string rutaArchivoReserva = "datos_reservas.txt";

        public FrmRegistroReserva()
        {
            InitializeComponent();
        }

        void cancelar()
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro(a) de cancelar?",
                                                    "Mensaje de confirmación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
             if(string.IsNullOrWhiteSpace(txtDiaEstadia.Text) ||
                cmbTipoHabitacion.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtCantidadHuesped.Text) ||
                cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                                         "Campos Incompletos",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDiaEstadia.Text, out int dias) || dias < 1 || dias > 7)
            {
                MessageBox.Show("La cantidad de días de estadía debe ser un número entre 1 y 7.",
                                                         "Días Inválidos",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                txtCantidadHuesped.Focus();
                return;
            }

            if (!int.TryParse(txtCantidadHuesped.Text, out int huespedes) || huespedes < 1 || huespedes > 5)
            {
                MessageBox.Show("La cantidad de huéspedes debe ser un número entre 1 y 5.",
                                                         "Huéspedes Inválidos",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                txtCantidadHuesped.Focus();
                return;
            }

            if (!int.TryParse(txtNumHabitacion.Text, out int num) || num < 1 || num > 50)
            {
                MessageBox.Show("El número de habitación debe ser un número entre 1 y 50.",
                                                         "Número Inválidos",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                txtCantidadHuesped.Focus();
                return;
            }

            string tipoHabitacion = cmbTipoHabitacion.Text;
            string metodoPago = cmbMetodoPago.Text;

                string nuevaLinea = $"{dias},{tipoHabitacion},{huespedes},{num},{metodoPago}";
                File.AppendAllText(rutaArchivoReserva, nuevaLinea + Environment.NewLine);

                MessageBox.Show("¡Reserva registrada con éxito!",
                                                         "Registro Completo",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Information);
            }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}