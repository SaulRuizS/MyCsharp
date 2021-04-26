using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly int charslim = 9999;
        string text1,text2,result;
        double val1,val2,op;
        bool sum,rest,div,mult;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DigitsBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculator Operations Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btnc_Click(object sender, EventArgs e)
        {
            digitsBox.Text = "";
        }

        private void Btnsum_Click(object sender, EventArgs e)
        {
            Conv1();
            sum = true;
            div = false;
            mult = false;
            rest = false;
        }

        private void Btnrest_Click(object sender, EventArgs e)
        {
            Conv1();
            rest = true;
            div = false;
            mult = false;
            sum = false;
        }

        private void Btnmult_Click(object sender, EventArgs e)
        {
            Conv1();
            mult = true;
            sum = false;
            div = false;
            rest = false;
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            Conv1();
            div = true;
            mult = false;
            sum = false;
            rest = false;
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            if (sum)
            {
                Conv2();
                op = val1 + val2;
            }
            else if(rest)
            {
                Conv2();
                op = val1 - val2;

            }
            else if(div)
            {
                Conv2();
                op = val1/val2;
            }
            else if(mult)
            {
                Conv2();
                op = val1 * val2;
            }

            result = Convert.ToString(op);
            digitsBox.Text = result;
        }

        private void Conv1() 
        {
            text1 = digitsBox.Text;
            val1 = double.Parse(text1);
            digitsBox.Text = "";
        }

        private void Conv2()
        {
            text2 = digitsBox.Text;
            val2 = double.Parse(text2);
        }

        /// <summary>
        /// Calculator Chars Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + "9";
            }
        }

        private void Btndot_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim)
            {
                digitsBox.Text = digitsBox.Text + ".";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (digitsBox.TextLength <= charslim) {
                digitsBox.Text = digitsBox.Text + "0";
            }
        }

    }
}
