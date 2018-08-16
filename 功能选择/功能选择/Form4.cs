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
    public partial class Form4 : Form
    {
        public Form4(Form1 form1)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rNum = new Random();
            int a= rNum.Next(1, 9),b= rNum.Next(1, 9),c= rNum.Next(1, 9),d= rNum.Next(1, 9);
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
