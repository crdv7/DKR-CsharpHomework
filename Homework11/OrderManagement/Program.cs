using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using Org.BouncyCastle.Math.EC;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var db=new OrderContext())
                {
                    var order = db.OrderItems.FirstOrDefault();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
