using OrderManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class ItemEdit : Form
    {
        public OrderItem OrderItem { get; set; }
        public ItemEdit()
        {
            InitializeComponent();
        }
        public ItemEdit(OrderItem item) : this()
        {
            this.OrderItem = item;
            this.itembindingSource.DataSource = item;
        }

        private void addItembutton_Click(object sender, EventArgs e)
        {
            double.TryParse(itemPriceInputtextBox.Text, out double price);
            Product product = new Product(itemNameInputtextBox.Text,price);
            int.TryParse(itemNumtextBox.Text, out int num);
            OrderItem = new OrderItem(product,num);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itembindingSource.ResetBindings(false);
        }
    }
}
