/*using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            //声明变量并初始化为0
            double num1 = 0;double num2 = 0;
            Console.WriteLine("c#控制台计算器\r");
            Console.WriteLine("--------------\n");
            //请求用户输入第一个数据
            Console.WriteLine("请输入第一个数据，然后按回车继续");
            num1 = Convert.ToDouble(Console.ReadLine());
            //请求用户输入第二个数据
            Console.WriteLine("请输入第二个数据，然后按回车继续");
            num2 = Convert.ToDouble(Console.ReadLine());
            //请求用户选择一个运算符
            Console.WriteLine("请从以下选项中选择一个运算符");
            Console.WriteLine("\ta-加法");
            Console.WriteLine("\tb-减法");
            Console.WriteLine("\tc-乘法");
            Console.WriteLine("\td-除法");
            Console.Write("你的选择为？");
            //根据用户选择进行运算
            switch(Console.ReadLine())
            {
                case "a":Console.WriteLine($"结果为:{num1}+{num2}=" + (num1 + num2)); break;
                case "b":Console.WriteLine($"结果为:{num1}-{num2}=" + (num1 - num2)); break;
                case "c":Console.WriteLine($"结果为:{num1}*{num2}=" + (num1 * num2)); break;
                case "d"://直到用户输入不为0的除数为止
                    while(num2==0)
                    {
                        Console.WriteLine("请输入不为0的除数");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"结果为:{num1}/{num2}=" + (num1 / num2)); break;
            }
            //等待用户响应退出程序
            Console.WriteLine("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}*/
using System;
namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            switch(op)
            {
                case "+":return (num1 + num2);
                case "-":return (num1 - num2);
                case "*":return (num1 * num2); 
                case "/":if (num2 != 0)
                    {
                        return (num1 / num2);
                    }
                    else return double.NaN;
                default:return double.NaN;
            }
        }

    }
    class Program
    {
        static void Main(string[]args)
        {
            bool endCalculation = false;
            Console.WriteLine("C# Console Calculator\r");
            Console.WriteLine("---------------------\n");
            while(!endCalculation)
            {
                string inputNum1 = "";
                string inputNum2 = "";
                double result = 0;
                Console.Write("输入第一个数字，然后按回车键:");
                inputNum1 = Console.ReadLine();
                double num1 = 0;
                while(!double.TryParse(inputNum1,out num1))
                {
                    Console.Write("输入不合法，请重新输入:");
                    inputNum1 = Console.ReadLine();
                }
                Console.Write("输入第二个数字，然后按回车键:");
                inputNum2 = Console.ReadLine();
                double num2 = 0;
                while(!double.TryParse(inputNum2,out num2))
                {
                    Console.Write("输入不合法，请重新输入:");
                    inputNum2 = Console.ReadLine();
                }
                //请求用户选择一个运算符
                Console.WriteLine("请从以下选项中选择一个运算符");
                Console.WriteLine("\t+-加法");
                Console.WriteLine("\t--减法");
                Console.WriteLine("\t*-乘法");
                Console.WriteLine("\t/-除法");
                Console.Write("你的选择为？");
                string op = Console.ReadLine();
                try
                {
                    result = Calculator.DoOperation(num1, num2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("这个操作将会造成数学错误,造成的原因可能是除数为0等.");
                    }
                    else Console.WriteLine("结果为:{0:0.##}\n", result);
                }
                catch(Exception e)
                {
                    Console.WriteLine("运算中出现了一个异常.详细信息为:" + e.Message);
                }
                Console.WriteLine("---------------------\n");
                Console.Write("输入‘n’和回车来结束程序,或者按任意键继续:");
                if (Console.ReadLine() == "n") endCalculation = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}