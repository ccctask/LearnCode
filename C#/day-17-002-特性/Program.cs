using System;

namespace day17002特性
{
    class MainClass
    {
        [Obsolete("请使用新的方法 Newmethod")]
        public static void Oldmethod() { }

        [Obsolete("不能使用的方法",true)]
        public static void Badmethod() { }



        public static void Text1() { Console.WriteLine("text1"); }
        public static void Text2() { Console.WriteLine("text1"); }




        public static void Newmethod() { }
        public static void Main(string[] args)
        {
            Oldmethod();
            Badmethod();
        }
    }
}