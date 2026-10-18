using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EP_Grupo7
{
    public partial class FrmRegister : Form
    {
        private string rutaArchivo = "datos_usuarios_registrados.txt";
        public FrmRegister()
        {
            InitializeComponent();
        }

        private bool ValidarDNI()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
                return false;

            string patron = @"^\d{8}$";
            return Regex.IsMatch(txtDNI.Text, patron);
        }

        private bool ValidarTelefono()
        {
            if (string.IsNullOrWhiteSpace(txtNumeroTelefonico.Text))
                return false;

            string patron = @"^\d{9}$";
            return Regex.IsMatch(txtNumeroTelefonico.Text, patron);
        }

        private bool ValidarNombreUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
                return false;

            string patron = @"^[A-Z][a-z]+$";
            return Regex.IsMatch(txtNombreUsuario.Text,patron);
        }

        private bool ValidarContrasena()
        {
            if (string.IsNullOrEmpty(txtContrasena.Text) || txtContrasena.Text.Length != 8)
                return false;

            bool tieneMayuscula = txtContrasena.Text.Any(char.IsUpper);
            bool tieneMinuscula = txtContrasena.Text.Any(char.IsLower);
            bool tieneSimbolo = txtContrasena.Text.Any(ch => !char.IsLetterOrDigit(ch));

            return tieneMayuscula && tieneMinuscula && tieneSimbolo;
        }
        void cancelar()
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro(a) de cancelar?",
                                                     "Confirmar salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtNumeroTelefonico.Text) ||
                string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtConfirmarContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", 
                                "Campos Incompletos", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDNI())
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.",
                                 "DNI Inválido",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarTelefono())
            {
                MessageBox.Show("El número telefónico debe tener exactamente 9 dígitos numéricos.",
                                 "Teléfono Inválido",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarNombreUsuario())
            {
                MessageBox.Show("El nombre de usuario debe iniciar con mayúscula, tener minúsculas y no incluir símbolos.", 
                                "Usuario Inválido", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }
            
            if (!ValidarContrasena())
            {
                MessageBox.Show("La contraseña debe tener 8 caracteres, al menos una mayúscula, una minúscula y un símbolo.", 
                                "Contraseña Inválida", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }


            string nuevaLinea = $"{txtNombre.Text.Trim()},{txtApellido.Text.Trim()},{txtDNI.Text.Trim()},{txtNumeroTelefonico.Text.Trim()},{txtCorreoElectronico.Text.Trim()},{txtNombreUsuario.Text.Trim()},{txtContrasena.Text.Trim()}";
    
            File.AppendAllText(rutaArchivo, nuevaLinea + Environment.NewLine);

            MessageBox.Show("¡Datos guardados con éxito!", "Registro Completo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
    }
}
