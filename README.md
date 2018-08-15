# 简单的demo介绍
### 1.基本功能  
        此程序的功能是能实现两个数字之间的加减乘除.使用c#编写,窗
    口包含十个数字功能键，四个操作功能键，一个清零键和一个等于键。
    上方还有两个显示输入和输出框。
### 2.基本原理
        此程序是应用了winform简单易懂的控件功能，利用Button,
    Text-Box，GroupBOX和Label控件组成了点击窗口.其组成如下：
![1](window.png "窗口")  
 
        当点击数字功能键的时候会触发点击事件，此时事件内部会将所
    点击的button的text文本赋给输入显示框。其代码如下：
```c#
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
```  
        check是标志第一个数字还是第二个数字的布尔型变量，若是第
    一个数字其值就是true，第二个数字就是false。       
        当点击操作符功能键时会触发点击事件，此时事件内部会执行一
    段代码，例如点击'*'功能键时，代码如下：
```c#    
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            str = "*";
            check = false;
```
        执行这段代码后，字符串变量str会得到一个字符赋值，然后下
    面就通过str的变量的值来实现加减乘除。当点击等于键时，其代码如下：
```c#
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
            textBox2.Text = Num3.ToString()
```
        当点击清零键的时候，其代码如下：
```c#
            textBox1.Text = "";
            textBox2.Text = "";
            num1 = null;
            num2 = null;
            check = true;
```
### 3.总结
        此程序能实现简单的加减乘除功能，但是有不少限制，首先，只能适用于两个数字的
    加减乘除。其次，每次算完后只能按清零键，不然会出现bug。

