# 基于Winform的小demo简介
## 1.功能简介
    我做的这个小demo是一个窗口程序，一个主窗口（form1），三个子窗口（form2，form3，form4)。第一个窗口是功能选择界面，有三个功能供选择：日历、计算器和24点小游戏。点击对应的功能旋钮，就可以跳转到对应的子窗口。
### 1.日历
    对应form2，进入界面后可以查看当前年月日。
### 2.计算器
    对应form3，进入界面后可以计算两个数字的加减乘除运算：在前两个Textbox中分别输入一个数字，再选择一个运算符，点击calculate键即可在第三个Textbox中得到运算结果。
### 3.24点小游戏
    对应form4，进入界面后点击start，上方的四个Textbox会分别输出一个1~9之间的随机数，玩家用加、减、乘、除(可加括号，高级玩家也可用乘方开方与阶乘运算)把这四个数算成24。
## 2.功能实现
    主窗口功能选择界面主要要实现向子窗口的跳转，在设计器中添加button控件后双击button1（日历）进入代码界面，在花括号中进行编辑如下：

```c#
 private void button1_Click(object sender, EventArgs e)
        {
           Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        } 
```
    便可以实现向form2的跳转。button2，button3同理。
### 1.日历
    在设计器中添加一个DateTimePicker控件即可。
### 2.计算器
    需要一个Button发出运算指令，四个RadioButton对应加减乘除运算符和三个Textbox控件。在设计器中添加button控件后双击button1（日历）进入代码界面，在花括号中进行编辑如下，实现加减乘除运算：
 
```c#
 double op1, op2, result;
            if (textBox1.Text == "" ||textBox2.Text == "")
            { MessageBox.Show(this, "error", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;}
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
```

### 3.24点小游戏
    在设计器中添加button控件后双击button进入代码界面，在花括号中进行编辑，主要是生成四个随机数。
  ```c#
    private void button1_Click(object sender, EventArgs e)
        {
            Random rNum = new Random();
            int a= rNum.Next(1, 9),b= rNum.Next(1, 9),c= rNum.Next(1, 9),d= rNum.Next(1, 9);
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();
        }
 ```
## 3.界面展示：
### form1(功能选择）:
![功能选择](功能选择.png  "功能选择")
### form2（日历）:
![日历](日历.png "日历")
### form3（计算器）:
![计算器](计算器.png "计算器")
## form4（24点小游戏）:
![24点小游戏](24点.png "24点小游戏")