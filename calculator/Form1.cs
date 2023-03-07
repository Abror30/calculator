using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        double res;
        string option;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            option  = "+";                  // when the user enters + operator 
            num1 = double.Parse(textBox1.Text); // it converts first number and sends it to the add method
            
            textBox.Clear(); // clears the textbox for second num2 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);
            
            textBox.Clear();
        }
        private void mulitply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void remainder_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            if (option.Equals("+")) 
                res = num1 + num2;
            
            if (option.Equals("-")) 
                res = num1 - num2;
   
            if (option.Equals("*")) 
                res = num1 * num2;

            if (option.Equals("/")) 
                res = num1 / num2;

            if (option.Equals("%")) 
                res = num1 % num2;

            textBox1.Text = res + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Clearing all numbers when user enters Clear Button
            textBox1.Clear();
            res = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
