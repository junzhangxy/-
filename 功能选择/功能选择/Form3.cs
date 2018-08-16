using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 功能选择
{
    public partial class Form3 : Form
    {
        public Form3(Form1 form1)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double op1, op2, result;
            if (textBox1.Text == "" ||textBox2.Text == "")
            {
                MessageBox.Show(this, "error", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            op1 = double.Parse(textBox1.Text);
            op2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked)
            { result = op1 + op2; }
            else if (radioButton2.Checked)
            { result = op1 - op2; }
            else if (radioButton3.Checked)
            { result = op1 * op2; }
            else
            { result = op1 / op2; }
            textBox3.Text = result.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
