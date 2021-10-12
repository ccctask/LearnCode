using System;

namespace day15002委托拓展
{
    class MainClass
    {
static void Text1()
        {
            Console.WriteLine("Text1");
        }
        static void Text2()
        {
            Console.WriteLine("Text2");
        }


        public static void Main(string[] args)
        {
           //多播委托
            Action a = Text1;
            a += Text2;

            a();
            a -= Text2;
            a();


            //遍历多播委托里的方法

            Delegate[] @delegate = a.GetInvocationList();

            foreach(Delegate point in @delegate)
            {
                point.DynamicInvoke();
            }
        }
    }
}
