using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MonitorDeVariables
{
    public partial class ventana : Form
    {
        string serialDataIn, mpuDataX, mpuDataY, mpuDataZ, distData1, distData2, distData3, distData4, bateriaData;
        sbyte indiceDeX, indiceDeY, indiceDeZ, indiceDist1, indiceDist2, indiceDist3, indiceDist4, indiceBateria;

        public ventana()
        {
            InitializeComponent();
        }
        private void ventana_Load(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            baudRate.Text = "115200";
            bateria.Value = 0;
            porcentajeBateria.Text = Convert.ToString(0);
        }

        private void com_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Serial Port comunication 
            */
            string[] portLists = SerialPort.GetPortNames();
            com_port.Items.Clear();
            com_port.Items.AddRange(portLists);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = com_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudRate.Text);
                serialPort1.Open();

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                startButton.Enabled = true;
                stopButton.Enabled = false;
                bateria.Value = 0;
                porcentajeBateria.Text = Convert.ToString(0);
                textAnguloX.Text = "";
                textAnguloY.Text = "";
                textAnguloZ.Text = "";
                textDist1.Text = "";
                textDist2.Text = "";
                textDist3.Text = "";
                textDist4.Text = "";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void ventana_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indiceBateria = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indiceDeX = Convert.ToSByte(serialDataIn.IndexOf("X"));
                indiceDeY = Convert.ToSByte(serialDataIn.IndexOf("Y"));
                indiceDeZ = Convert.ToSByte(serialDataIn.IndexOf("Z"));
                indiceDist1 = Convert.ToSByte(serialDataIn.IndexOf("D1S"));
                indiceDist2 = Convert.ToSByte(serialDataIn.IndexOf("D2S"));
                indiceDist3 = Convert.ToSByte(serialDataIn.IndexOf("D3S"));
                indiceDist4 = Convert.ToSByte(serialDataIn.IndexOf("D4S"));

                bateriaData = serialDataIn.Substring(0, indiceBateria);
                mpuDataX = serialDataIn.Substring(indiceBateria + 1, (indiceDeX - indiceBateria) - 1);
                mpuDataY = serialDataIn.Substring(indiceDeX + 1, (indiceDeY - indiceDeX) - 1);
                mpuDataZ = serialDataIn.Substring(indiceDeY + 1, (indiceDeZ - indiceDeY) - 1);
                distData1 = serialDataIn.Substring(indiceDeZ + 1, (indiceDist1 - indiceDeZ) - 1);
                distData2 = serialDataIn.Substring(indiceDist1 + 1, (indiceDist2 - indiceDist1) - 1);
                distData3 = serialDataIn.Substring(indiceDist2 + 1, (indiceDist3 - indiceDist2) - 1);
                distData4 = serialDataIn.Substring(indiceDist3 + 1, (indiceDist4 - indiceDist3) - 1);

                porcentajeBateria.Text = Convert.ToString((100/4) * Convert.ToDouble(bateriaData));
                bateria.Value = (100 / 4) * ( Convert.ToInt32(Convert.ToDouble(bateriaData)));
                textAnguloX.Text = mpuDataX;
                textAnguloY.Text = mpuDataY;
                textAnguloZ.Text = mpuDataZ;
                textDist1.Text = distData1;
                textDist2.Text = distData2;
                textDist3.Text = distData3;
                textDist4.Text = distData4;

            }
            catch (Exception Error) 
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
