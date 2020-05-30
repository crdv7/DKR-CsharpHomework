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
            List<Product> products = ProductService.GetAll();
            if (products.Count == 0)
            {
                ProductService.Insert(new Product("milk", 2.5));
                ProductService.Insert(new Product("banana", 1.0));
                products = ProductService.GetAll();
            }
            productbindingSource.DataSource = products;
        }

        private void addItembutton_Click(object sender, EventArgs e)
        {
            double.TryParse(itemPriceInputtextBox.Text, out double price);
            Product product = new Product(inputProductNamecomboBox.Text,price);
            ProductService.Insert(product);
            int.TryParse(itemNumtextBox.Text, out int num);
            OrderItem = new OrderItem(product,num);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itembindingSource.ResetBindings(false);
        }

        private void inputProductNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product temp = inputProductNamecomboBox.SelectedItem as Product;
            itemPriceInputtextBox.Text = temp.Price.ToString();
        }
    }
}
