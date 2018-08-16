using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   
    public partial class Form1 : Form
    {
        string num1, num2;
        bool check = true;
        string str = "";
        public Form1()
        {
            InitializeComponent();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "+";
            check = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "-";
            check = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "*";
            check = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "/";
            check = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 += b.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            check = true;
            double Num1 = 0, Num2 = 0, Num3 = 0;
            Num1 = double.Parse(num1);
            Num2 = double.Parse(num2);
            switch (str)
            {
                case "+":
                    Num3 = Num1 + Num2;
                    break;
                case "-":
                    Num3 = Num1 - Num2;
                    break;
                case "*":
                    Num3 = Num1 * Num2;
                    break;
                case "/":
                    Num3 = Num1 / Num2;
                    break;
            }
            textBox2.Text = Num3.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            num1 = null;
            num2 = null;
            check = true;
        }

    }
}
