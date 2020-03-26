using System;
using System.Collections.Generic;
namespace OrderManagement
{
    public class Order:IComparable {
        public string Id { get; } // 订单编号
        public double TotalPrice { get; set; } // 订单总价
        public Client ClientInfo {get;}//客户信息
        public DateTime Ordertime { get; } // 下单时间
        public List<OrderItem> orderItems;//订单商品明细
        public Order(Client client, List<OrderItem> items)
        {
            Random rd = new Random();
            Id = DateTime.Now.ToString("yyyyMMddHHmmss") + rd.Next(100000).ToString().PadLeft(5, '0');//根据下单时间随机生成订单号
            items.ForEach(item => TotalPrice += (item.Products.Price * item.buynum));//计算订单总价
            ClientInfo = client;
            Ordertime = DateTime.Now;
            orderItems = items;
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   Id == order.Id &&
                   Ordertime == order.Ordertime;
        }
        public override int GetHashCode()
        {
            var hashCode = -36634138;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(ClientInfo);
            hashCode = hashCode * -1521134295 + Ordertime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderItems);
            return hashCode;
        }
        public override string ToString()
        {
            string itemInfo=null;
            for(int i=0;i<orderItems.Count;i++)
            {
                itemInfo+=orderItems[i].ToString();
            }
            return string.Format("订单号:{0:d}\t订单总额:{1:C}\n" + ClientInfo.ToString() +
                "\n下单时间:{2:F}\n订单明细:\n"+itemInfo,
                Id, TotalPrice, Ordertime.ToString("R"));
        }
        public int CompareTo(object obj)
        {
            return Id.CompareTo(obj);
        }
    }
}
