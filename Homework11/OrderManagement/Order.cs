using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace OrderManagement
{
    public class Order:IComparable <Order>{
        [Key]
        public String Id { get; set; } // 订单编号
        public String ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client ClientInfo { get; set; }//客户信息
        public List<OrderItem> Items{ get; set; }
        public String ClientName { get; set; }
        public DateTime Ordertime { get; set; } // 下单时间
        public Order() {
            Id = Guid.NewGuid().ToString();
            Items = new List<OrderItem>();
            Ordertime = DateTime.Now;
        }
            public Order(Client client, List<OrderItem> items):this()
        {
            ClientInfo = client;
            Ordertime = DateTime.Now;
            if (items != null) Items = items;
        }
        public void AddOrderItem(OrderItem item)
        {
            if (Items.Contains(item))
                throw new ApplicationException($"添加错误,订单已存在！");
            Items.Add(item);
        }
        public void RemoveOrderItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double TotalPrice {
            get => Items == null ? 0 : Items.Sum(item => item.TotalPrice);
                } // 订单总价
        public override bool Equals(object obj)
        {
            return obj is Order order &&
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
           // hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderItems);
            return hashCode;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Id:{Id},client:{ClientInfo},orderTime:{Ordertime},totalPrice:{TotalPrice}");
            Items.ForEach(o => stringBuilder.Append("\n\t" + o));
            return stringBuilder.ToString();
        }
        public int CompareTo(Order order)
        {
            return Id.CompareTo(order.Id);
        }
    }
}
