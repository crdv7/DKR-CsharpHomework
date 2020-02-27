using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_operator_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            while (!double.TryParse(Num1.Text, out num1) || !double.TryParse(Num2.Text, out num2))
            {
                Warning.Text = "输入的数据有误！";
                return;
            }
            switch(OperatorBox.Text)
            {
                case "+":Result.Text = $"{num1 + num2}";break;
                case "-":Result.Text = $"{num1 - num2}";break;
                case "*":Result.Text = $"{num1 * num2}";break;
                case "/":if (num2 == 0)
                        Warning.Text = "除数为0,请重新输入!";
                    else
                        Result.Text = $"{num1 / num2}";break;
                default:Warning.Text = "请选择一个运算符!";break;
            }
        }
    }
}
