using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Ca1:Add_
    {
        public override void Add()
        {
            Console.WriteLine("请输入第一个整数:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("两数之和结果为:{0}", a + b);
        }
        public override void Sub()
        {
            Console.WriteLine("请输入第一个整数:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("两数之差结果为:{0}", a - b);
        }
        public void Mul()
        {
            Console.WriteLine("请输入第一个整数:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("两数之积结果为:{0}", a * b);
        }
        public void Div()
        {
            Console.WriteLine("请输入第一个整数:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int b = int.Parse(Console.ReadLine());
            if (b != 0)
                Console.WriteLine("两数相除结果为:{0}", (double)a / b);
            else
                Console.WriteLine("除数不能为0！请重新输入！");
        }
        public void Equals()
        {
            Console.WriteLine("请输入第一个整数:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.WriteLine("两数相等！");
            else
                Console.WriteLine("两数不相等！");
        }
        //public void mod()
        //{
        //    Console.WriteLine("请输入第一个整数:");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("请输入第二个整数:");
        //    int b = int.Parse(Console.ReadLine());
        //    Int64 x = a % b;
        //    Console.WriteLine("进行取余运算的结果为:{0}" , x);
        //}
        //public void with()
        //{
        //    Console.WriteLine("请输入第一个整数:");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("请输入第二个整数:");
        //    int b = int.Parse(Console.ReadLine());
        //    Int64 y = a & b;
        //    Console.WriteLine("进行加法运算的结果为:{0}", y);
        //}
    }
}
