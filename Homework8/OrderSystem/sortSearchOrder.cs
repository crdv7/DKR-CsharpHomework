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
        OrderService orderService;
        public String Keyword { get; set; }
        public sortSearchOrder()
        {
            InitializeComponent();
            orderService = new OrderService();
            Client client = new Client("dkr", "yy", "123");
            Client client1 = new Client("DDD", "DD", "222");
            Product milk = new Product("milk", 2.5);
            Thread.Sleep(100);
            Product banana = new Product("banana", 1);
            Thread.Sleep(100);
            Product egg = new Product("egg", 0.5);
            Thread.Sleep(100);
            Product rice = new Product("rice", 0.2);
            List<OrderItem> items = new List<OrderItem>
            {
                new OrderItem(milk, 10),
                new OrderItem(banana, 30)
            };
            Order order1 = new Order(client, items);
            List<OrderItem> items1 = new List<OrderItem>
            {
                new OrderItem(egg, 100),
                new OrderItem(rice, 2000)
            };
            Thread.Sleep(600);
            Order order2 = new Order(client1, items1);
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            OrderbindingSource.DataSource = orderService.Orders;
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
                orderService.CreateOrder(form.CurrentOrder);
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
            OperateOrder form = new OperateOrder(order);
            if (form.ShowDialog() == DialogResult.OK)
            {
                orderService.ModifyOrder(form.CurrentOrder);
                searchAll();
            }
        }
        private void searchAll()
        {
            OrderbindingSource.DataSource = orderService.Orders;
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
            orderService.DeleteOrder(order.Id);
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
                orderService.Import(fileName);
                searchAll();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchComboBox.SelectedIndex)
            {
                case 0:OrderbindingSource.DataSource = orderService.Orders;break;
                case 1:
                    List<Order> result = orderService.SearchOrderById(Keyword);
                    OrderbindingSource.DataSource = result;break;
                case 2:OrderbindingSource.DataSource = orderService.SearchOrderByName(Keyword);
                    break;
                case 3:
                    double.TryParse(Keyword, out double totalPrice);
                    OrderbindingSource.DataSource = orderService.SearchByTotalAmount(totalPrice);
                    break;
            }
            OrderbindingSource.ResetBindings(true);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            switch (sortcomboBox.SelectedIndex)
            {
                case 0:
                    orderService.OrderSortById();
                    OrderbindingSource.DataSource = orderService.Orders; break;
                case 1:
                    orderService.OrderSortByTotalPrice();
                    OrderbindingSource.DataSource = orderService.Orders; break;
                case 2:
                    orderService.OrderSortByTime();
                    OrderbindingSource.DataSource = orderService.Orders; break;
            }
            OrderbindingSource.ResetBindings(true);
        }

        private void orderDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyOrder();
        }
    }
}
