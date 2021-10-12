using System;

namespace day02获取用户输入
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string inPut1 = Console.ReadLine();
            int num = Convert.ToInt32(inPut1);
            string inPut2 = Console.ReadLine();
            int num2 = Convert.ToInt32(inPut2);

            int he = num + num2;

            Console.WriteLine(num+"+"+num2+"="+he);
        }
    }
}
