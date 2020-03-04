using System;
using System.Collections.Generic;
namespace FindPrimeNumber
{
    class Program
    {
        public const int MAX = 99999999;
        static List<int> results = new List<int>();
        static void Main(string[] args)
        {
            bool endApp = false; int n;
            while (!endApp)
            {
                Console.WriteLine("请输入一个大于1的正整数:");
                bool inputSuccess = int.TryParse(Console.ReadLine(), out n);
                while (!inputSuccess || n <= 1)
                {
                    Console.WriteLine("输入有误，请重新输入一个大于1的正整数!");
                    inputSuccess = int.TryParse(Console.ReadLine(), out n);
                }
                Console.WriteLine("n以内的质数为:", n);
                try
                {
                    FindPrimeNumber(n);
                    int i=0;
                    foreach (int result in results)
                    {
                        i++;
                        Console.Write(result + "\t");
                        if (i % 5 == 0) Console.WriteLine();
                    }
                    Console.Write("\n质数的总个数为："+results.Count);
                    results.Clear();
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
        static void FindPrimeNumber(int n)
        {
            bool[] isPrime = new bool[MAX];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }
            for(int i=2;i<=n;i++)
            {
                if(isPrime[i])
                {
                    results.Add(i);
                    for (int j = 2 * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }
    }
}
