using System;
namespace day1401委托的定义和使用
{
    public class Sit
    {
        private int A;
        private int B;

       
        public Sit(int a,int b)
        {
            A = a;
            B = b;
            Console.WriteLine("Sit 方法 里的A和B： " + A + B);
        }
        public static string Output()
        {
            return "my name is Output";
        }
    }
}
