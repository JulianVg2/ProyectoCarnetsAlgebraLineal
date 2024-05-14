using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCarnetsAlgebraLineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnetActual.Text;
            if (carnet.Length != 9)
            {
                MessageBox.Show("El formato del carnet es incorrecto. Debe tener 9 dígitos.");
                return;
            }

            int suma = 0;
            for (int i = 0; i < carnet.Length; i++)
            {
                suma += (i + 1) * int.Parse(carnet[i].ToString());
            }
            int digitoVerificacion = suma % 11;
            string digitoVerificacionStr = digitoVerificacion == 10 ? "X" : digitoVerificacion.ToString();

            string nuevoCodigo = carnet + digitoVerificacionStr;

            // Mostramos el nuevo código en el cuadro de texto correspondiente
            txtCarnetNuevo.Text = nuevoCodigo;

        }

        private void btnGenerarQr_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnetNuevo.Text;

            var qrWriter = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    Height = 300,
                    Width = 300
                }
            };

            var bitmap = qrWriter.Write(carnet);
            pictureBox1.Image = bitmap;
        }

        }
    

}
