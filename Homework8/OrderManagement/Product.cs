using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Product {
        public String Id { get; set; }// 商品编号
        public String Name { get; set; } // 名称
        public double Price { get; set; } // 价格
        public Product() { }
        public Product(string name, double price)
        {
            Random rd = new Random();
            Id = "#" + rd.Next(100).ToString().PadLeft(2, '0');
            Name = name;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Id == product.Id &&
                   Name == product.Name &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = -479135040;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
