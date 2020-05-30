using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderManagement
{
    public class OrderItem 
    {
        [Key]
        public String Id { get; set; }
        public string ProductId { get; set; }//商品ID
        [ForeignKey("ProductId")]
        public Product Products { get; set; } //商品
        public String ProductName { get => Products != null ? this.Products.Name : "";}
        public double ProductPrice { get => Products != null ? this.Products.Price : 0.0;}
        public int Buynum { get; set; }//购物数量
        public string OrderId { get; set; }
        public OrderItem() { Id = Guid.NewGuid().ToString(); }
        public OrderItem(Product product,int buynum):this()
        {
            Products = product;
            this.Buynum = buynum;
        }
        public double TotalPrice
        {
            get => Products == null ? 0.0 : ProductPrice * Buynum;
        }
        public override string ToString()
        {
            return string.Format("商品编号:{0}\t商品名:{1}\t商品价格:{2:C}\t商品数量\n", Id, ProductName, ProductPrice, Buynum);
        }
    }
}
