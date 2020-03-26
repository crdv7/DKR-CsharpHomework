using System;
using System.Collections.Generic;
using System.Linq;
namespace OrderManagement
{
    public class OrderService {
        List<Order> orders = new List<Order>();
        public List<OrderItem> InputItem()//商品明细输入函数
        {
            List<OrderItem> items = new List<OrderItem>();
            bool input = true;
            while (input)
            {
                Console.WriteLine("请输入商品名:");
                string itemname = Console.ReadLine();
                Console.WriteLine("请输入单价:");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("价格输入有误!请重新输入!");
                }
                Console.WriteLine("请输入购买数量:");
                int buynum;
                while (!int.TryParse(Console.ReadLine(), out buynum))
                {
                    Console.WriteLine("数量输入有误!请重新输入!");
                }
                OrderItem item = new OrderItem(new Product(itemname, price), buynum);
                if (!items.Contains(item))//保证订单明细不重复
                    items.Add(item);
                else
                    Console.WriteLine("重复添加商品!");
                Console.WriteLine("输入n结束商品明细输入入,或按其他键继续输入商品.");
                if (Console.ReadLine() == "n") input = false;
            }
            return items;
        }
        public bool CreateOrder()//创建订单
        {
            Console.WriteLine("请输入您的用户名:");
            string clientname = Console.ReadLine();
            Console.WriteLine("请输入您的送货地址:");
            string address = Console.ReadLine();
            Console.WriteLine("请输入您的电话号码:");
            string phonenumber = Console.ReadLine();
            Client client = new Client(clientname, address, phonenumber);
            Console.WriteLine("请输入商品明细");
            List<OrderItem> items = InputItem();
            Order order = new Order(client, items);
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
        public void DeleteOrder()//删除订单
        {
            string id = Console.ReadLine();
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
        public void ModifyOrder()//修改订单
        {
            Console.WriteLine("请输入您想修改的订单号:");//输入要修改的订单号
            string id=Console.ReadLine();
            while(!orders.Exists(x=>x.Id==id))//检测订单号是否有效
            {
                Console.WriteLine("订单号不存在，请重新输入!");
                id = Console.ReadLine();
            }
            int index = orders.FindIndex(x=>x.Id==id);//找到要修改订单的索引
            Console.WriteLine("请选择您要修改的内容:\n1.送货地址 2.电话号码 3.商品明细");//选择修改方式
            int input = 0;
            while(!int.TryParse(Console.ReadLine(),out input)&&input<0&&input>3)
            {
                Console.WriteLine("输入有误，请重新输入");
            }
            switch(input){
                case 1:
                    try
                    {
                        Console.WriteLine("请输入修改后的送货地址");
                        orders[index].ClientInfo.Address = Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }break;
                case 2:
                    try {
                        Console.WriteLine("请输入修改后的电话号码");
                        orders[index].ClientInfo.PhoneNumber = Console.ReadLine();
                    } catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    } break;
                case 3:
                    try
                    {
                        orders[index].orderItems.Clear();
                        orders[index].orderItems=InputItem();
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }break;
                default:throw new Exception("无效的修改方式!");
            }
        }
        public void SearchOrder()//查询订单
        {
            Console.WriteLine("请选择查询方式:1.按订单号查询\t2.按客户名查询\t3.按客户电话查询");//选择查询方式，并按照订单总额排序显示
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("输入有误，请重新输入!");
            }
            switch (input)
            {
                case 1: //通过订单号查询
                    Console.WriteLine("请输入要查询的订单号");
                    string id = Console.ReadLine();
                    var result1 = orders.Where(x => x.Id == id);
                    Order order = result1.FirstOrDefault();
                    if (order != null)
                    {
                        Console.WriteLine(order);
                    }
                    else throw new Exception("无效的订单号:" + id + '\n');
                    break;
                case 2://通过客户名查询
                    Console.WriteLine("请输入要查询的客户名");
                    string clientname = Console.ReadLine();
                    var result2 = from w in orders
                                  where w.ClientInfo.Name == clientname
                                  orderby w.TotalPrice
                                  select w;
                    List<Order> resultlist1 = result2.ToList();
                    if (resultlist1 != null)
                    {
                        resultlist1.ForEach(r1 => Console.WriteLine(r1));
                    }
                    else throw new Exception("客户名不存在!\n");
                    break;
                case 3://通过客户电话查询
                    Console.WriteLine("请输入要查询的电话号码");
                    string phonenumber = Console.ReadLine();
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
                    break;
                default:throw new Exception("查询类型无效!");
            }
        }
        public void OrderSort()//订单排序
        {
            Console.WriteLine("请选择排序方式:1.按照订单号排序\t2.按照订单总额排序\t3.按照创建时间排序");//选择排序方式
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("输入有误，请重新输入!");
            }
            switch (input)
            {

                case 1:
                    orders.Sort();
                    ShowOrderInfo(); break;//通过订单号排序
                case 2:
                    orders.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));//通过总价排序
                    ShowOrderInfo(); break;
                case 3:
                    orders.Sort((o1, o2) => int.Parse(o1.Ordertime.ToString()) - int.Parse(o2.Ordertime.ToString()));//通过创建时间排序
                    ShowOrderInfo(); break;
                default:throw new Exception("无效的排序方式!");
            }
        }
        public void ShowOrderInfo()
        {
            orders.ForEach(order => Console.WriteLine(order));
        }
    }
}
