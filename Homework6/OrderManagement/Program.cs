/*
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
            OrderService orderService = new OrderService();
            Client client = new Client("dkr", "yy", "123");
            Client client1 = new Client("DDD", "DD", "222");
            Product milk = new Product("milk", 2.5);
            Product banana = new Product("banana", 1);
            Product egg = new Product("egg", 0.5);
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
            Order order2 = new Order(client1, items1);
            orderService.orders.Add(order1);
            orderService.orders.Add(order2);
            string path = "orders.xml";
            orderService.Export(path);
            orderService.Import(path);
            /*OrderManagement orderManagement = new OrderManagement();
            orderManagement.Menu();*/
            Console.ReadLine();
        }
    }
}
