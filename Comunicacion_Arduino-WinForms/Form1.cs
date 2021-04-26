using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_Arduino_WinForms
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Puerto;
        bool Cerrado = false;

        public Form1()
        {
            InitializeComponent();

            Puerto = new System.IO.Ports.SerialPort();  //Inicializacion del puerto serie
            Puerto.PortName = "COM3";   //Seleccion del puerto serie
            Puerto.BaudRate = 115200;   //Baudios de comunicacion
            Puerto.ReadTimeout = 500;   //Milisegundo hasta fin del tiempo de espera para recibir datos

            try
            {
                Puerto.Open();  //Abre la conexion del puerto serie
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Thread hilo = new Thread(EscucharSerial);
            hilo.Start();
        }

        private void EscucharSerial()
        {
            while(!Cerrado)
            {
                try
                {
                    string texto_serial = Puerto.ReadLine();

                    txtBox.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtBox.Text = texto_serial;
                        }
                    ));

                }
                catch { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerrado = true;
            if (Puerto.IsOpen)
                Puerto.Close();
        }
    }
}
