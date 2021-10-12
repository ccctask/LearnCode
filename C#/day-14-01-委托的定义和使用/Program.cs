using System;

namespace day1401委托的定义和使用
{
    class MainClass

    {
        private delegate string GetAString();  //声明 委托，根据 代理的方法的类型
        private delegate void Text();
        public static void Main(string[] args)
        {
            /*
             * 什么是委托： 委托是 可以将 方法赋值给 变量。
             */

            int s = 10;
            int b = 20;

            GetAString Sstring = new GetAString(s.ToString); // Sstring 就等于 s.ToString
            string a = Sstring(); // 第一种 常用的调用方式。


            GetAString bString = b.ToString;  // 第二种赋值方法。 
            string monkey = bString.Invoke(); // 第二种 引用方法。



            //属性的复习
            Sit c = new Sit(2, 3);

            Console.WriteLine(c);

            GetAString myString = Sit.Output;
        }
    }
}
