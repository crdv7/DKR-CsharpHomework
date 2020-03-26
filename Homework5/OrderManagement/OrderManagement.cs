using System;
namespace OrderManagement
{
    class OrderManagement
    {
        public void Menu()
        {
            OrderService service = new OrderService();
            bool stop = false;
            while (!stop) {
                Console.WriteLine("请选择需要的服务:\n1.创建订单 2.删除订单 3.查询订单 4.修改订单 5.订单排序 6.显示订单");
                int input = 0;
                while (!int.TryParse(Console.ReadLine(), out input) && input < 0 && input > 6)
                {
                    Console.WriteLine("输入有误，请重新输入!");
                }
                switch (input)
                {
                    case 1: service.CreateOrder(); break;
                    case 2: service.DeleteOrder(); break;
                    case 3: service.SearchOrder(); break;
                    case 4: service.ModifyOrder(); break;
                    case 5: service.OrderSort(); break;
                    case 6: service.ShowOrderInfo(); break;
                    default: throw new Exception("出现错误！");
                }
                Console.WriteLine("输入n退出程序,或者输入其他继续.");
                if (Console.ReadLine() == "n") stop = true;
            }
        }
    }
}
