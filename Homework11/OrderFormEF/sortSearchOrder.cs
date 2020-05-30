using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
namespace OrderSystem
{
    public partial class sortSearchOrder : Form
    {
        public String Keyword { get; set; }
        public sortSearchOrder()
        {
            InitializeComponent();;
            OrderbindingSource.DataSource = OrderService.QueryAllOrders();
            searchComboBox.SelectedIndex = 0;
            Inputtext.DataBindings.Add("Text", this, "Keyword");
        }
        private void sortSearchOrder_Load(object sender, EventArgs e)
        {

        }

        private void clientBinndingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OperateOrder form = new OperateOrder(new Order());
            if (form.ShowDialog() == DialogResult.OK)
            {
               OrderService.CreateOrder(form.CurrentOrder);
                searchAll();
            }
        }
        private void ModifyOrder()
        {
            Order order = OrderbindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改!");
                return;
            }
            order = OrderService.GetOrderById(order.Id);
            OperateOrder form = new OperateOrder(order);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderService.ModifyOrder(form.CurrentOrder);
                searchAll();
            }
        }
        private void searchAll()
        {
            OrderbindingSource.DataSource = OrderService.QueryAllOrders();
            OrderbindingSource.ResetBindings(false);
        }

        private void modifyOrderButton_Click(object sender, EventArgs e)
        {
            ModifyOrder();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            Order order = OrderbindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            OrderService.DeleteOrder(order.Id);
            searchAll();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result.Equals(DialogResult.OK))
            {
                string fileName = openFileDialog1.FileName;
                OrderService.Import(fileName);
                searchAll();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string fileName = saveFileDialog1.FileName;
                OrderService.Export(fileName);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchComboBox.SelectedIndex)
            {
                case 0:OrderbindingSource.DataSource = OrderService.QueryAllOrders();break;
                case 1:
                    List<Order> result = new List<Order>();
                    result.Add(OrderService.GetOrderById(Keyword));
                    OrderbindingSource.DataSource = result;break;
                case 2:OrderbindingSource.DataSource = OrderService.SearchByClientName(Keyword);
                    break;
                case 3:
                    double.TryParse(Keyword, out double totalPrice);
                    OrderbindingSource.DataSource = OrderService.SearchByTotalAmount(totalPrice);
                    break;
            }
            OrderbindingSource.ResetBindings(true);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<Order> orders = OrderService.QueryAllOrders();
            switch (sortcomboBox.SelectedIndex)
            {
                case 0:
                    orders.Sort();
                    OrderbindingSource.DataSource = orders; break;
                case 1:

                    orders.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));//通过总价排序
                    OrderbindingSource.DataSource = orders; break;
                case 2:
                    orders.Sort((o1, o2) => DateTime.Compare(o1.Ordertime, o2.Ordertime));//通过创建时间排序
                    OrderbindingSource.DataSource = orders; break;
            }
            OrderbindingSource.ResetBindings(true);
        }

        private void orderDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyOrder();
        }
    }
}
