/*我先把周五的课堂作业贴出来。作业的代码量比较大一点，大家提前做好准备。
写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。
在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/
using System;
using System.Collections.Generic;
using System.Threading;
namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderManagement orderManagement = new OrderManagement();
            //orderManagement.Menu();
/*            OrderService orderService = new OrderService();
            Client client = new Client("dkr", "yy", "123");
            Client client1 = new Client("DDD", "DD", "222");
            Product milk = new Product("milk", 2.5);
            Thread.Sleep(100);
            Product banana = new Product("banana", 1);
            Thread.Sleep(100);
            Product egg = new Product("egg", 0.5);
            Thread.Sleep(100);
            Product rice = new Product("rice", 0.2);
            List<OrderItem> items = new List<OrderItem>
            {
                new OrderItem(milk, 10),
                new OrderItem(banana, 30)
            };
            Order order1 = new Order(client,items);
            List<OrderItem> items1 = new List<OrderItem>
            {
                new OrderItem(egg, 100),
                new OrderItem(rice, 2000)
            };
            Thread.Sleep(6000);
            Order order2 = new Order(client1, items1);
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            string path = @"D:\orders.xml";
            orderService.Export(path);
            orderService.Import(path);
            Console.ReadLine();*/
        }
    }
}
