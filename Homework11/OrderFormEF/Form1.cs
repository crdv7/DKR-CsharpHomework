using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
namespace OrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 添加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperateOrder operateOrder = new OperateOrder();
            operateOrder.ShowDialog();
        }

        private void 订单查询与排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortSearchOrder sortSearchOrder = new sortSearchOrder();
            sortSearchOrder.ShowDialog();
        }
    }
}
