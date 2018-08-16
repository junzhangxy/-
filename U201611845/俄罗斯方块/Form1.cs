using System;
using System.Windows.Forms;

namespace 俄罗斯方块
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game();
            pictureBox1.Height = Game.BlockImageHeight*Game.PlayingFieldHeight + 3;
            pictureBox1.Width = Game.BlockImageWidth*Game.PlayingFieldWidth + 3;
            pictureBox1.Invalidate(); //重画游戏面板区域
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "暂停游戏")
            {
                timer1.Enabled = false;
                button2.Text = "继续游戏";
            }
            else
            {
                timer1.Enabled = true;
                button2.Text = "暂停游戏";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //重画游戏面板
            if (game != null)
            {
                game.DrawPile(e.Graphics);
                game.DrawCurrentBlock(e.Graphics);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            ////重画下一个方块
            if (game != null) game.DrawNextBlock(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!game.DownCurrentBlock())
            {
                pictureBox1.Invalidate(); //重画游戏面板区域
                pictureBox2.Invalidate(); //重画下一个方块
            }
            lblScore.Text = game.score.ToString();
            if (game.over)
            {
                timer1.Enabled = false;
                MessageBox.Show("游戏结束,", "提示");
                button1.Enabled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys e)
            //重写ProcessCmdKey方法
        {
            if (button2.Text == "继续游戏") return true; //暂停时不响应键盘
            if (e == Keys.Up || e == Keys.Down || e == Keys.Space ||
                e == Keys.Left || e == Keys.Right)
            {
                MyKeyPress(this, new KeyPressEventArgs((char) e));
            }
            return true;
        }

        //然后在MyKeyPress方法中处理   
        private void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char) Keys.Up:
                    game.RotateCurrentBlock();
                    break;
                case (char) Keys.Down:
                    if (!game.DownCurrentBlock())
                        pictureBox1.Invalidate(); //重画游戏面板区域
                    break;
                case (char) Keys.Right:
                    game.MoveCurrentBlockSide(false);
                    break;
                case (char) Keys.Left:
                    game.MoveCurrentBlockSide(true);
                    break;
                case (char) Keys.Space:
                    button2.PerformClick();
                    break;
            }
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = 550 - Convert.ToInt16(comboBox1.Text)*50;
        }
    }
}