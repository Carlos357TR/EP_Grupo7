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
    public partial class FrmVerRegistros : Form
    {
        private string rutaArchivo = "datos_usuarios_registrados.txt";
        private string rutaArchivoReserva = "datos_reservas.txt";
        public FrmVerRegistros()
        {
            InitializeComponent();
        }

        private void CargarDatosEnGrid()
        {
            dgvRegistroUsuario.Rows.Clear();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] valores = linea.Split(',');

                        if (valores.Length >= 7)
                        {
                            dgvRegistroUsuario.Rows.Add(
                                valores[0], 
                                valores[1], 
                                valores[2], 
                                valores[3], 
                                valores[4], 
                                valores[5], 
                                valores[6]  
                            );
                        }
                    }
                }
            }
        }

        private void CargarDatosEnGrid1()
        {
            dgvRegistroReserva.Rows.Clear();

            if (File.Exists(rutaArchivoReserva))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoReserva);

                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] valores = linea.Split(',');

                        if (valores.Length >= 5)
                        {
                            dgvRegistroReserva.Rows.Add(
                                valores[0],
                                valores[1],
                                valores[2],
                                valores[3],
                                valores[4]
                            );
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatosEnGrid();
            CargarDatosEnGrid1();
            MessageBox.Show("Lista actualizada correctamente.",
                            "Actualizado", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }
    }
}