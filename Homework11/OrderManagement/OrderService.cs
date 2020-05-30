using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data.Entity;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Serialization;
using System.Security.AccessControl;
using System.Data.OleDb;
namespace OrderManagement
{
    public class OrderService
    {
        public OrderService(){}
        private static IQueryable<Order>AllOrders(OrderContext db)
        {
            return db.Orders.Include(o => o.Items.Select(i => i.Products)).Include("ClientInfo");
        }
        public static List<Order>QueryAllOrders()
        {
            using(var db=new OrderContext())
            {
                return AllOrders(db).ToList();
            }
        }
        public static Order GetOrderById(string id)
        {
            using(var db=new OrderContext())
            {
                return AllOrders(db).FirstOrDefault(o => o.Id == id);
            }
        }
        public static Order CreateOrder(Order order)//创建订单
        {
            try
            {
                using(var db=new OrderContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                return order;
            }catch(Exception e)
            {
                throw new ApplicationException($"添加出现错误:{e.Message}");
            }
        }
        public static void DeleteOrder(string id)//删除订单
        {
            try
            {
                using(var db=new OrderContext())
                {
                    var order = db.Orders.Include("Items").Where(ord => ord.Id == id).FirstOrDefault();
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException($"订单删除出现错误!");
            }
        }
        private static void RemoveItems(string orderId)
        {
            using(var db=new OrderContext())
            {
                var removeItems = db.OrderItems.Where(item => item.OrderId == orderId);
                db.OrderItems.RemoveRange(removeItems);
                db.SaveChanges();
            }
        }
        public static void ModifyOrder(Order neworder)//修改订单
        {
            RemoveItems(neworder.Id);
            using(var db=new OrderContext())
            {
                db.Entry(neworder).State = EntityState.Modified;
                db.OrderItems.AddRange(neworder.Items);
                db.SaveChanges();
            }
        }
        public static List<Order> SearchOrderByProductName(string name)
        {
            using(var db=new OrderContext())
            {
                var query = AllOrders(db).Where(o => o.Items.Count(i => i.ProductName == name) > 0);
                return query.ToList();
            }
        }
        public static List<Order> SearchByClientName(string name)
        {
            using(var db=new OrderContext())
            {
                var query = AllOrders(db).Where(o => o.ClientName == name);
                return query.ToList();
            }
        }
        public static object SearchByTotalAmount(double amout)
        {
            using(var db=new OrderContext())
            {
                return AllOrders(db).Where(o => o.Items.Sum(item => item.ProductPrice * item.Buynum) > amout).ToList();
            }
        }
        public static void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs,QueryAllOrders());
            }
        }
        public static List<Order> Import(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<Order> olist = (List<Order>)xmlSerializer.Deserialize(fs);
                olist.ForEach(order=>{
                    try
                    {
                        CreateOrder(order);
                    }
                    catch(Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                });
                return olist;
            }
        }
    }
}