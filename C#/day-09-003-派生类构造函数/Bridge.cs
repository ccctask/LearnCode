using System;
namespace day09003派生类构造函数
{
    public class Bridge
    {
        protected int z; // 相当于 private 如果不被继承，  
        private int x;
        public static  int v1;

        public static void Staticff(){
            Console.WriteLine("tis is static ");
        }
        public Bridge(int x)
        {
            this.x = x;
            Console.WriteLine("Bridge X coming");
        }

    }
}
