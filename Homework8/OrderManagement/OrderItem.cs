using System;
using System.Collections.Generic;
namespace OrderManagement
{
    public class OrderItem 
    {
        public Product Products { get; set; } //商品
        //public String Id { get; set; }
       // public String Name { get; set; }
        //public double Price { get; set; }
        public String ProductName { get => Products != null ? this.Products.Name : "";}
        public double ProductPrice { get => Products != null ? this.Products.Price : 0.0;}
        public int Buynum { get; set; }//购物数量
        public String Id { get => Products != null ? this.Products.Id : ""; }
        public OrderItem() { Products = new Product(); }
        public OrderItem(Product product,int buynum)
        {
            Products = product;
            this.Buynum = buynum;
        }
        private double TotalPrice
        {
            get => Products == null ? 0.0 : ProductPrice * Buynum;
        }
        public override string ToString()
        {
            return string.Format("商品编号:{0}\t商品名:{1}\t商品价格:{2:C}\t商品数量\n", Id, ProductName, ProductPrice, Buynum);
        }
    }
}
