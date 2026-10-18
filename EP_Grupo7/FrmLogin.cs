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
    public partial class FrmLogin : Form
    {
        private string rutaArchivo = "datos_usuarios_registrados.txt";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtNombreUsuario.Text.Trim();
            string contrasenaIngresada = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(contrasenaIngresada))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.",
                                "Campos Incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("No hay usuarios registrados aún en el sistema.",
                                "Error de Autenticación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            bool inicioSesionExitoso = false;

                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length >= 7)
                        {
                            string usuarioGuardado = datos[5].Trim();
                            string contrasenaGuardada = datos[6].Trim();

                            if (usuarioIngresado == usuarioGuardado && contrasenaIngresada == contrasenaGuardada)
                            {
                                inicioSesionExitoso = true;
                                break;
                            }
                        }
                    }
                }

                if (inicioSesionExitoso)
                {
                    MessageBox.Show($"¡Bienvenido(a), {usuarioIngresado}!",
                                                             "Acceso Concedido",
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Information);

                    FrmRegistroReserva frmRegistroReserva = new FrmRegistroReserva();
                    frmRegistroReserva.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                                    "Acceso Denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
        }
    }
