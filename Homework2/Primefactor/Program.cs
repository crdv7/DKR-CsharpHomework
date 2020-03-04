using System;
using System.Collections.Generic;
namespace Primefactor
{
    class Primenumber
    {
        static List<int> results = new List<int>();
        static void Main(string[] args)
        {
            bool endApp = false;
            int n;
            while (!endApp)
            {
                Console.WriteLine("请输入一个正整数:");
                bool inputSuccess = int.TryParse(Console.ReadLine(), out n);
                while (!inputSuccess || n <= 0)
                {
                    Console.WriteLine("输入有误，请重新输入一个正整数!");
                    inputSuccess = int.TryParse(Console.ReadLine(), out n);
                }
                Console.WriteLine("n的所有素数因子为:", n);
                try
                {
                    FindPrimeFactor(n);
                    foreach (int result in results)
                    {
                        Console.Write(result+"\t");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("出现异常:" + e.Message);
                }
                Console.Write("\n输入n和回车退出程序，或者只按回车以继续.");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine();
            }
        }
        public static void FindPrimeFactor(int n)
        {
            for(int i=2;i<n;i++)
            {
                while(n%i==0&&i!=n)
                {
                    results.Add(i);
                    n /= i;
                }
            }
            results.Add(n);
        }
    }
}
