using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderManagement
{
    public class Product {
        [Key]
        public String Id { get; set; }// 商品编号
        public String Name { get; set; } // 名称
        public double Price { get; set; } // 价格
        public Product() { 
        }
        public Product(string name, double price)
        {
            Id = Guid.NewGuid().ToString();
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
