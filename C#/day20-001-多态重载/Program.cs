using System;
using System.Collections.Generic;
using System.Text;
namespace day20001多态重载
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PrintHello();
        }


        //方法的重载   同名方法 根据使用的不通调用 不同的方法
        public static void PrintHello()
        {
            Console.WriteLine("Hellp");
        }
        public static void PrintHello(string Name)
        {
            Console.WriteLine("hello {0}", Name);
        }
    }
    class Complex
    {
        public int Number { get; set; }



        public static Complex pro
    }
}
