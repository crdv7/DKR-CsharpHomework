using System;
using System.Collections.Generic;

namespace OrderManagement
{
    class OrderManagement
    {
/*        public List<OrderItem> InputItem()//商品明细输入函数
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
        public void Menu()
        {
            OrderService service = new OrderService();
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("请选择需要的服务:\n1.创建订单 2.删除订单 3.查询订单 4.修改订单 5.订单排序 6.显示订单");
                int input = 0;
                while (!int.TryParse(Console.ReadLine(), out input) && input < 0 && input > 6)
                {
                    Console.WriteLine("输入有误，请重新输入!");
                }
                switch (input)
                {
                    case 1:
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
                            service.CreateOrder(order); break;
                        }
                    case 2:
                        Console.WriteLine("请输入要删除的订单的订单号");
                        string id = Console.ReadLine();
                        service.DeleteOrder(id); break;
                    case 3:
                        {
                            Console.WriteLine("请选择查询方式:1.按订单号查询\t2.按客户名查询\t3.按客户电话查询");//选择查询方式，并按照订单总额排序显示
                            int input1 = 0;
                            while (!int.TryParse(Console.ReadLine(), out input))
                            {
                                Console.WriteLine("输入有误，请重新输入!");
                            }
                            switch (input1)
                            {
                                case 1: //通过订单号查询
                                    Console.WriteLine("请输入要查询的订单号");
                                    string searchid = Console.ReadLine();
                                    service.SearchOrderById(searchid);
                                    break;
                                case 2://通过客户名查询
                                    Console.WriteLine("请输入要查询的客户名");
                                    string clientname = Console.ReadLine();
                                    service.SearchOrderByName(clientname);
                                    break;
                                case 3://通过客户电话查询
                                    Console.WriteLine("请输入要查询的电话号码");
                                    string phonenumber = Console.ReadLine();
                                    service.SearchOrderByPhoneNumber(phonenumber);
                                    break;
                                default: throw new Exception("查询类型无效!");
                            }; break;
                        }
                    case 4:
                        {
                            Console.WriteLine("请输入您想修改的订单号:");//输入要修改的订单号
                            string modifyId = Console.ReadLine();
                            while (!service.orders.Exists(x => x.Id == modifyId))//检测订单号是否有效
                            {
                                Console.WriteLine("订单号不存在，请重新输入!");
                                modifyId = Console.ReadLine();
                            }
                            Console.WriteLine("请输入修改后的订单");
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
                            service.ModifyOrder(order);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("请选择排序方式:1.按照订单号排序\t2.按照订单总额排序\t3.按照创建时间排序");//选择排序方式
                            int sortInput = 0;
                            while (!int.TryParse(Console.ReadLine(), out sortInput))
                            {
                                Console.WriteLine("输入有误，请重新输入!");
                            }
                            switch (sortInput)
                            {

                                case 1:
                                    service.OrderSortById();
                                    service.orders.ForEach(order => Console.WriteLine(order)); break;
                                case 2:
                                    service.OrderSortByTotalPrice();
                                    service.orders.ForEach(order => Console.WriteLine(order)); break;
                                case 3:

                                    service.orders.ForEach(order => Console.WriteLine(order)); break;
                                default: throw new Exception("无效的排序方式!");
                            }
                            break;
                        }
                    case 6: service.orders.ForEach(order => Console.WriteLine(order)); break;
                    default: throw new Exception("出现错误！");
                }
                Console.WriteLine("输入n退出程序,或者输入其他继续.");
                if (Console.ReadLine() == "n") stop = true;
            }
        }*/
    }
}
