using System;
using System.Text.RegularExpressions;

namespace text
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 分组操作符

            string desk = Console.ReadLine();
            string girl = @"(ab\w{2}){2}";

            Console.WriteLine(Regex.Replace(desk, girl, "9999"));
           

        }
    }
}
