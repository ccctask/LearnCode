using System;

namespace day04练习随机数
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int mingj = 1,maxgj = 20;

            int minfy = 50, maxfy = 100;

            int relgj=random.Next(mingj, maxgj);
            Console.WriteLine("输出"+relgj);



            int relfy=random.Next(minfy, maxfy);
            Console.WriteLine("防御" + relfy);
            
        }
    }
}
