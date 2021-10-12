using System;

namespace day07004类的使用
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vector3 play1 = new Vector3(10, 2, 5);
            Console.WriteLine(play1.ShowDate());
            Console.WriteLine(play1.data);
            play1.Onrun();



            // 属性 的 第一次试验


            play1.MyPropert = 600;  // set  value=600
            int tempdata = play1.MyPropert; //属性赋值 使tempdata   get到 value的600 

            // 属性的进阶

            play1.X = 100;
            float datax = play1.X;
            Console.WriteLine("属性设置 x字段，x= " + datax);

        }
    }
}
