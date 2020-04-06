using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*将课本中例5-31的Cayley树绘图代码进行修改。
 * 添加一组控件用以调节树的绘制参数。
 * 参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、
 * 左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。
*/
namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double leng = 100;
        int n = 10;
        public Form1()
        {
            InitializeComponent();
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Blue, Name = "蓝色" });
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Red, Name = "红色" });
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Green, Name = "绿色" });
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Yellow, Name = "黄色" });
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Black, Name = "黑色" });
            comboBoxColor.Items.Add(new ColorName() { Color = Color.Purple, Name = "紫色" });
            comboBoxColor.SelectedIndex = 0;
        }
        class ColorName
        {
            public Color Color;
            public string Name;

            public override string ToString()
            {
                return Name;
            }
        }
            private void drawbutton_Click(object sender, EventArgs e)
        {
            int x = drawpanel.Width / 2;
            if (graphics == null) graphics = drawpanel.CreateGraphics();
            else graphics.Clear(Color.White);
            DrawCayleytree(n, x, 310, leng, -Math.PI / 2);
        }
        void DrawCayleytree(int n,double x0,double y0,double leng,double th) {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            DrawLine(x0, y0, x1, y1);
            DrawCayleytree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleytree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void DrawLine(double x0,double y0,double x1,double y1)
        {
            ColorName colorName = (ColorName)comboBoxColor.SelectedItem;
            Pen pen = new Pen(colorName.Color);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void hScrollBarper1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void numericUpDownleng_ValueChanged(object sender, EventArgs e)
        {
            leng = (double)numericUpDownleng.Value;
        }

        private void numericUpDownper2_ValueChanged(object sender, EventArgs e)
        {
            per2 = (double)numericUpDownper2.Value;
        }

        private void numericUpDownth1_ValueChanged(object sender, EventArgs e)
        {
            th1 = (double)numericUpDownth1.Value * Math.PI / 180;
        }

        private void numericUpDownth2_ValueChanged(object sender, EventArgs e)
        {
            th2 = (double)numericUpDownth2.Value * Math.PI / 180;
        }

        private void numericUpDownper1_ValueChanged(object sender, EventArgs e)
        {
            per1 = (double)numericUpDownper1.Value;
        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            n = (int)numericUpDownN.Value;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
