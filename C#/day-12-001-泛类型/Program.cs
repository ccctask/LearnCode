using System;

namespace day12001泛类型
{
    class MainClass
    {
        //泛型 方法
        public static string Fangfa<T1, A>(T1 d, A c)
        {
            return d + "" + c;
        }



        public static void Main(string[] args)
        {
            var text = new ClassFan<int,string,double>(1, 2);
            Console.WriteLine(text.add());
            //调用方法
            Console.WriteLine(Fangfa<int, int>(1, 3));
        }
    }
}
