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
    public partial class OperateOrder : Form
    {
        public Order CurrentOrder{get;set;}
        public OperateOrder()
        {
            InitializeComponent();
            List<Client> clients = ClientService.GetAll();
            if(clients.Count==0)
            {
                ClientService.Add(new Client("dkr"));
                ClientService.Add(new Client("Sam"));
                clients = ClientService.GetAll();
            }
            ClientBindingSource.DataSource = clients;
        }
        public OperateOrder(Order order) : this()
        {
            CurrentOrder = order;
            OrderbindingSource.DataSource = CurrentOrder;
            CurrentOrder.ClientInfo = (Client)ClientBindingSource.Current;
            label1.Text = CurrentOrder.Ordertime.ToString();
            textBox1.Text = CurrentOrder.Id;
        }
 
        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            ItemEdit itemEditform = new ItemEdit(new OrderItem());
            try
            {
                if (itemEditform.ShowDialog() == DialogResult.OK)
                {
                    CurrentOrder.AddOrderItem(itemEditform.OrderItem);
                    ItembindingSource.ResetBindings(false);
                }
            }catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OperateOrder_Load(object sender, EventArgs e)
        {

        }
        private void ModifyItem()
        {
            OrderItem orderItem=ItembindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行修改!");
                return;
            }
            ItemEdit itemEdit = new ItemEdit(orderItem);
            if (itemEdit.ShowDialog() == DialogResult.OK)
            {
                ItembindingSource.ResetBindings(false);
            }
        }
        private void orderSaveButton_Click(object sender, EventArgs e)
        {
            //CurrentOrder.Items.ForEach(item => CurrentOrder.TotalPrice += (item.ProductPrice * item.Buynum));//计算订单总价
            CurrentOrder.ClientId = CurrentOrder.ClientInfo.ID;
            CurrentOrder.ClientName = clientNameComboBox.Text;
            CurrentOrder.ClientInfo = null;
            ClientService.Add(new Client(clientNameComboBox.Text));
            CurrentOrder.Items.ForEach(item =>
            {
                item.ProductId = item.Products.Id;
                item.Products = null;
                item.OrderId = CurrentOrder.Id;
            });
            this.Close();
        }

        private void itemsModifyButton_Click(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyItem();
        }

        private void itemsDeleteButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = ItembindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单进行删除!");
                return;
            }
            CurrentOrder.RemoveOrderItem(orderItem);
            ItembindingSource.ResetBindings(false);
        }
    }
}
