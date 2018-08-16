using System;
using System.Drawing;



namespace 俄罗斯方块
{
    public class Block
    {
        private readonly int ID; //方块部件的ID
        private short height;
        private short left;
        public int[,] shape; //存储方块部件的形状，０为空白，１为有砖块
        private short top;
        private short width;

        public Block() //构造函数
        {
            Random randomGenerator = new Random();
            int randomBlock = randomGenerator.Next(1, 5); //产生1—4的数
            ID = randomBlock;
            switch (ID)
            {
                case 1: //横条形
                    Width = 4;
                    Height = 1;
                    Top = 0;
                    Left = 3;
                    shape = new int[Width,Height];
                    shape[0, 0] = 1;
                    shape[1, 0] = 1;
                    shape[2, 0] = 1;
                    shape[3, 0] = 1;
                    break;
                case 2: //正方形
                    Width = 2;
                    Height = 2;
                    Top = 0;
                    Left = 4;
                    // Creates the new shape for this block.
                    shape = new int[Width,Height];
                    shape[0, 0] = 1;
                    shape[0, 1] = 1;
                    shape[1, 0] = 1;
                    shape[1, 1] = 1;
                    break;
                case 3: //Ｔ形
                    Width = 3;
                    Height = 3;
                    Top = 0;
                    Left = 4;
                    // Creates the new shape for this block.
                    shape = new int[Width,Height];
                    shape[0, 0] = 1;
                    shape[1, 0] = 1;
                    shape[2, 0] = 1;
                    shape[1, 1] = 1;
                    shape[1, 2] = 1;
                    break;
                case 4: //L形
                    Width = 2;
                    Height = 3;
                    Top = 0;
                    Left = 4;
                    // Creates the new shape for this block.
                    shape = new int[Width,Height];
                    shape[0, 0] = 1;
                    shape[0, 1] = 1;
                    shape[0, 2] = 1;
                    shape[1, 2] = 1;
                    break;
            }
        }

        public short Width //Width属性
        {
            get { return width; }
            set { width = value; }
        }

        public short Height //Height属性
        {
            get { return height; }
            set { height = value; }
        }

        public short Top //Top属性
        {
            get { return top; }
            set { top = value; }
        }

        public short Left //Left属性
        {
            get { return left; }
            set { left = value; }
        }

        public void Draw(Graphics g)
        {
            Image brickImage = Image.FromFile("image/block0.gif");
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (shape[i, j] == 1) //黑色格子
                    {
                        //得到绘制这个格子的在游戏面板中的矩形区域
                        Rectangle rect = new Rectangle((Left + i)*Game.BlockImageWidth, (Top + j)*Game.BlockImageHeight,
                                                       Game.BlockImageWidth, Game.BlockImageHeight);
                        g.DrawImage(brickImage, rect);
                    }
                }
            }
        }
    }

//class Block
}