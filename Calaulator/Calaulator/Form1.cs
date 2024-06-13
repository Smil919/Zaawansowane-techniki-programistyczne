using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calaulator
{
    public partial class Kalkulator : Form
    {

        string sign;
        double num1;
        double num2;
        bool StartNewNumber = true;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBt_Click("1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberBt_Click("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberBt_Click("8");
        }

        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            this.sign = sign;
            StartNewNumber = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "Cannot be devided by 0";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);
                    }
                    break;
            }
            sign = String.Empty;
            StartNewNumber = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberBt_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberBt_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberBt_Click("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberBt_Click("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberBt_Click("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberBt_Click("9");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberBt_Click("0");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operation("+");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            StartNewNumber = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
                StartNewNumber = false;
            }
        }
        private void NumberBt_Click(string number)
        {
            if (StartNewNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                StartNewNumber = false;
            }
        }

        
    }
}