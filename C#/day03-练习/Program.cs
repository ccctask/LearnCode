using System;

namespace day03练习
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            Console.WriteLine("1:{0},2:{1}", num2, num1);
            Console.ReadKey();
        }
    }
}
