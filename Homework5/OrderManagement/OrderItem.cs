using System.Collections.Generic;
namespace OrderManagement
{
    public class OrderItem {
        public Product Products { get; } //商品
        public int buynum; //购物数量
        public OrderItem(Product product,int buynum)
        {
            Products = product;
            this.buynum = buynum;
        }
        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   item.Products.Name==Products.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1754240917;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(Products);
            hashCode = hashCode * -1521134295 + buynum.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return Products.ToString() + "\t购物数量:" + buynum+"\n";
        }
    }
}
