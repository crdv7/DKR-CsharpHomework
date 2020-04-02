using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        static readonly Client client1 = new Client("dkr", "yy", "123");
        static readonly Client client2 = new Client("DDD", "DD", "222");
        static readonly Product milk = new Product("milk", 2.5);
        static readonly Product banana = new Product("banana", 1);
        static readonly Product egg = new Product("egg", 0.5);
        static readonly Product rice = new Product("rice", 0.2);
        static readonly List<OrderItem> items1 = new List<OrderItem>
            {
                new OrderItem(milk, 10),
                new OrderItem(banana, 300)
            };
        static readonly Order order1 = new Order(client1, items1);
        static readonly List<OrderItem> items2 = new List<OrderItem>
            {
                new OrderItem(egg, 100),
                new OrderItem(rice, 2000)
            };
        static readonly Order order2 = new Order(client2, items2);
        static readonly List<OrderItem> items3 = new List<OrderItem>
        {
            new OrderItem(milk,20),
            new OrderItem(rice,1000),
            new OrderItem(banana,10)
        };
        static readonly Order order3 = new Order(client1, items3);
        static readonly Order order4 = new Order(client2, items3);
        OrderService orderService = new OrderService();
        [TestInitialize()]
        public void init()
        {
            orderService = new OrderService();
            orderService.CreateOrder(order1);
            orderService.CreateOrder(order2);
            orderService.CreateOrder(order3);
            orderService.Export("expected.xml");
        }
        [TestMethod()]
        public void CreateOrderTest()
        {
            orderService.CreateOrder(order4);
            Assert.AreEqual(4,orderService.orders.Count);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            orderService.DeleteOrder(order4.Id);
            Assert.AreEqual(3,orderService.orders.Count);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            orderService.CreateOrder(order1);
            Order order = new Order();
            order.Id = order1.Id;
            orderService.ModifyOrder(order);
            Assert.AreSame(order,orderService.orders[0]);
        }

        [TestMethod()]
        public void SearchOrderByIdTest()
        {
            List<Order> listId =new List<Order> { order1 };
            CollectionAssert.AreEqual(listId,orderService.SearchOrderById(order1.Id));
        }

        [TestMethod()]
        public void SearchOrderByNameTest()
        {
            List<Order> listName = new List<Order> { order3, order1 };
            CollectionAssert.AreEqual(listName,orderService.SearchOrderByName(client1.Name));
        }

        [TestMethod()]
        public void SearchOrderByPhoneNumberTest()
        {
            List<Order> listPhonenumber = new List<Order> { order2 };
            CollectionAssert.AreEqual(listPhonenumber,orderService.SearchOrderByPhoneNumber(client2.PhoneNumber));
        }

        [TestMethod()]
        public void OrderSortByIdTest()
        {;
            List<Order> resultorderId = new List<Order> { order1, order2, order3 };
            orderService.OrderSortById();
            CollectionAssert.AreEqual(resultorderId, orderService.orders);
        }

        [TestMethod()]
        public void OrderSortByTotalPriceTest()
        {
            List<Order> resultorderTotalPrice = new List<Order> {order3,order1,order2 };
            orderService.OrderSortByTotalPrice();
            CollectionAssert.AreEqual(resultorderTotalPrice,orderService.orders);
        }

        [TestMethod()]
        public void OrderSortByTimeTest()
        {
            List<Order> resultorderTime = new List<Order> { order1, order2, order3 };
            orderService.OrderSortByTime();
            CollectionAssert.AreEqual(resultorderTime, orderService.orders);
        }

        [TestMethod()]
        public void ExportTest()
        {
            string file = "orders.xml";
            orderService.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<string> expectLines = File.ReadLines("expected.xml").ToList();
            List<string> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            List<Order> listImport = orderService.Import("expected.xml");
            CollectionAssert.AreEqual(orderService.orders, listImport);
        }
    }
}