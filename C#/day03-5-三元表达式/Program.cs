using System;

namespace day035三元表达式
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            string toout = (num > 10)
                ? ">10"
                : "<10";
            Console.WriteLine(toout);
        }
    }
}
