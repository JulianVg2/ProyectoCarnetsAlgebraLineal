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
        string nuevoCodigo;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnetActual.Text;

            // Validación del formato y rango de años del carnet
            if (carnet.Length != 9)
            {
                MessageBox.Show("El formato del carnet es incorrecto. Debe tener 9 dígitos.");
                return;
            }

            string yearStr = carnet.Substring(0, 4);
            int year;
            if (!int.TryParse(yearStr, out year) || year < 2016 || year > 2024)
            {
                MessageBox.Show("El año en el carnet debe estar entre 2016 y 2024.");
                return;
            }

            // Continuar con la generación del código y la lógica existente
            int suma = 0;
            for (int i = 0; i < carnet.Length; i++)
            {
                suma += (i + 1) * int.Parse(carnet[i].ToString());
            }
            int digitoVerificacion = suma % 11;
            string digitoVerificacionStr = digitoVerificacion == 10 ? "X" : digitoVerificacion.ToString();

             nuevoCodigo = carnet + digitoVerificacionStr;
            string temporal = carnet + "*";

            // Mostramos el nuevo código en el cuadro de texto correspondiente
            txtCarnetNuevo.Text = temporal;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int digitoVerificacionAleatorio = rnd.Next(10); // Genera un número aleatorio entre 0 y 9
            string nuevoDigitoVerificacionStr = digitoVerificacionAleatorio == 10 ? "X" : digitoVerificacionAleatorio.ToString();

            // Actualiza el dígito de verificación en el nuevo código del carné
            nuevoCodigo = nuevoCodigo.Substring(0, nuevoCodigo.Length - 1) + nuevoDigitoVerificacionStr;

           


        }
        private void btnGenerarQr_Click(object sender, EventArgs e)
        {
            string carnet = nuevoCodigo;

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
