using System;

namespace day05007数组
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //第一种 数组  赋值
            int[] scores={123,5,12,32,21};

            //不赋值 指定10个长度

            int[] scores1 = new int[10];

            //给长度 和值
            int[] scores2 = new int[3]{2,43,3};

            //访问数组

            Console.WriteLine(scores[1]);
        }
    }
}
