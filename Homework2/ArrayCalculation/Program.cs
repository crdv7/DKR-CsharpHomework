using System;
using System.Collections.Generic;
namespace ArrayCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; string s; double[] answer;bool endInput = false, endApp = false;
            while (!endApp)
            {
                List<int> num = new List<int>();
                Console.WriteLine("请输入一个整型数组");
                do
                {
                    Console.WriteLine("请输入第" + i + "个数,或输入n终止输入:");
                    s = Console.ReadLine();
                    if (s != "n")
                    {
                        endInput = false;
                        try
                        {
                            num.Add(int.Parse(s));
                            i++;
                        }
                        catch
                        {
                            Console.WriteLine("第" + i + "个数输入非法!请重新输入!");
                        }
                    }
                    else
                    {
                        endInput = true;
                    }
                } while (!endInput);
                answer = arrayCalculation(num);
                Console.WriteLine("数组的大小为:" + num.Count);
                Console.WriteLine($"最大值:{answer[0]},最小值:{answer[1]},总和:{answer[2]},平均值:{answer[3]}");
                Console.Write("输入n和回车退出程序，或者只按回车以继续.");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine();i=1;
            }
        }
        static double[] arrayCalculation(List<int> num)
        {
            double[] result = new double[4];
            result[0] = -99999999; result[1] = 99999999;
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] > result[0]) result[0] = num[i];//Max
                if (num[i] < result[1]) result[1] = num[i];//Min
                result[2] += num[i];//Sum
            }
            result[3]=result[2]/num.Count;//Ave
            return result;
        }
    }
}
