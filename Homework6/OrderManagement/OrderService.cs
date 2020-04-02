using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
/*1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
2、对订单程序中OrderService的各个Public方法添加测试用例。
*/
namespace OrderManagement
{
    public class OrderService {
        public List<Order> orders = new List<Order>();
        public bool CreateOrder(Order order)//创建订单
        {
            if (orders.Contains(order))//保证订单不重复
            {
                Console.WriteLine("订单存在，重复！");
                return false;
            }
            else
            {
                orders.Add(order);//成功添加订单
                Console.WriteLine("订单创建成功！");
                return true;
            }
        }
        public void DeleteOrder(string id)//删除订单
        {
            try
            {
                for (int i = 0; i < orders.Count; i++)//通过订单号寻找订单并删除
                {
                    if (orders[i].Id == id)
                    {
                        orders.Remove(orders[i]);
                        Console.WriteLine("删除成功!");//删除成功
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("删除失败!出现异常:");//删除失败，显示异常
                Console.WriteLine(e.Message);
            }
        }
        public void ModifyOrder(Order neworder)//修改订单
        {
            try
            {
                int index = orders.FindIndex(x => x.Id ==neworder.Id);
                orders[index] = neworder;
            }catch(Exception e)
            {
                Console.WriteLine("修改失败！"+e.Message);
            }
        }
        public List<Order> SearchOrderById(string id)//查询订单
        {
            var result1 = orders.Where(x => x.Id == id);
            Order order = result1.FirstOrDefault();
            if (order != null)
            {
                Console.WriteLine(order);
            }
            else throw new Exception("无效的订单号:" + id + '\n');
            return result1.ToList();
        }
        public List<Order> SearchOrderByName(string name)
        {
            var result2 = from w in orders
                          where w.ClientInfo.Name == name
                          orderby w.TotalPrice
                          select w;
            List<Order> resultlist1 = result2.ToList();
            if (resultlist1 != null)
            {
                resultlist1.ForEach(r1 => Console.WriteLine(r1));
            }
            else throw new Exception("客户名不存在!\n");
            return resultlist1;
        }
        public List<Order> SearchOrderByPhoneNumber(string phonenumber)
        {
            var result3 = from r in orders
                          where r.ClientInfo.PhoneNumber == phonenumber
                          orderby r.TotalPrice
                          select r;
            List<Order> resultlist2 = result3.ToList();
            if (resultlist2 != null)
            {
                resultlist2.ForEach(r2 => Console.WriteLine(r2));
            }
            else throw new Exception("电话号码不存在!\n");
            return resultlist2;
        }
        public void OrderSortById()
        {
            orders.Sort();
        }
        public void OrderSortByTotalPrice()
        {
            orders.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));//通过总价排序
        }
        public void OrderSortByTime()
        {
            orders.Sort((o1, o2) => DateTime.Compare(o1.Ordertime, o2.Ordertime));//通过创建时间排序
        }
        public void Export(string filename)
        { 
            Console.WriteLine("original orders:");
            orders.ForEach(p => Console.WriteLine(p));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            Console.WriteLine("\nSerialized as XML");
            Console.WriteLine(File.ReadAllText("orders.xml"));
        }
        public List<Order> Import(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<Order> olist = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Deserialized from " + filename);
                olist.ForEach(o => Console.WriteLine(o));
                return olist;
            }
        }

    }
}
