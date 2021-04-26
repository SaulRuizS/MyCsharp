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

namespace SpaceFighter
{
    public partial class Window_Background : Form
    {
        private int Score;
        string serialDataIn, InputValueX, InputValueY, InputValueButton;
        sbyte IndexValueX, IndexValueY, IndexValueButton;
        int ButtonValue = 1, ValueX = 370, ValueY = 680;

        public Window_Background()
        {
            InitializeComponent();
        }

        private void Window_Background_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Window_Background_Load(object sender, EventArgs e)
        {
            serialPort.Open();
            Score = 0;
            ScorePoints.Text = Convert.ToString(Score);
            start();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                IndexValueButton = Convert.ToSByte(serialDataIn.IndexOf("B"));
                IndexValueX = Convert.ToSByte(serialDataIn.IndexOf("X"));
                IndexValueY = Convert.ToSByte(serialDataIn.IndexOf("Y"));

                InputValueButton = serialDataIn.Substring(0, IndexValueButton);
                InputValueX = serialDataIn.Substring(IndexValueButton + 1, (IndexValueX - IndexValueButton) - 1);
                InputValueY = serialDataIn.Substring(IndexValueX + 1, (IndexValueY - IndexValueX) - 1);

                ButtonValue = Convert.ToInt32(IndexValueButton);
                ValueX = Convert.ToInt32(InputValueX);
                ValueY = Convert.ToInt32(InputValueY);


                x_value_txt.Text = Convert.ToString(ValueX);
                y_value_txt.Text = Convert.ToString(ValueY);

                shipMovement();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void lazerShot()
        {
            Lazer.Visible = true;
        }
        void shipMovement()
        {
            SpaceShip.Left = ValueX;
            SpaceShip.Top = ValueY;
        }

        void start()
        {
            if (ButtonValue == 0)
            {
                StartMsg.Visible = false;
                //lazerShot();
            }
        }
        /*
        private void shipDestroyed()
        {
            if()
            {
                SpaceShip.Visible = false;
                Blast.Visible = true;
            }
        }
        */
        private void meteorDrop()
        {

        }

        private void meteorMovement()
        {

        }

    }
}
