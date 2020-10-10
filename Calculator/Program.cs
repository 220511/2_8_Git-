using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要进行的运算符号（+，-，*，/）:");
            Ca1 ca1 = new Ca1();
            Ca2 ca2 = new Ca2();
            string c = Console.ReadLine();
            if (c == "+")
            {
                ca1.Add();
                ca1.Equals();
                ca2.Add();
                //ca1.mod();
                //ca1.with();
            }
            else if (c == "-")
            {
                ca1.Sub();
                ca1.Equals();
                ca2.Sub();
                //ca1.mod();
                //ca1.with();
            }
            else if (c == "*")
            {
                ca1.Mul();
                ca1.Equals();
                //ca1.mod();
                //ca1.with();
            }
            else if (c == "/")
            {
                ca1.Div();
                ca1.Equals();
                //ca1.mod();
                //ca1.with();
            }
           
        }
    }
}
