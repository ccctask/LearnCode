using System;

namespace day15003委托练习
{
    class MainClass
    {
        //定义一个 委托类型
        public delegate void PeopleGreeting(string name);


        //两个 要被委托的 方法
        static void EnglishGreeting(string name)
        {
            Console.WriteLine("good moining:"+name);
        }
        static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好：" + name);
        }



        public static void Main(string[] args)
        {


            //一个主要调用的方法。
            void ToGreeting(string name,PeopleGreeting people)
            {
                people(name);
            }

            // 调用
            ToGreeting("黎明",ChineseGreeting);

            //good 默写 成功。 





            void t1(string name, Action<string> action)
            {
                action(name);
            }
            t1("action", EnglishGreeting);


        }
    }
}
