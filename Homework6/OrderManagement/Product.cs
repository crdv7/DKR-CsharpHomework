using System;
using System.Threading;
namespace OrderManagement
{
    public class Product {
        public string id; // 商品编号
        public string Name; // 名称
        public double Price { get; set; } // 价格
        public Product() { }
        public Product(string name, double price)
        {
            Random rd = new Random();
            id = "#" + rd.Next(100).ToString().PadLeft(2, '0');
            Name = name;
            Price = price;
            Thread.Sleep(100);
        }

        public override string ToString()
        {
            return string.Format("商品编号:{0}\t商品名:{1}\t商品价格:{2:C}", id, Name, Price);
        }
    }
}
