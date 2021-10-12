using System;

namespace day15001委托和事件深度学习
{
    //定义一个委托
     public delegate void GreetingDelegate(string name);

   
    class MainClass
    {

        //定义一个枚举  判断  国籍。
        enum People { 
            English,
            Chinese,
        }

        //定义一个委托 “方法！！！”、
        private static void GreetPeople1(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name); //调用的时候  MakeGreeting = 方法 EnglishGreeting/ChineseGreeting
        }



        public static void Main(string[] args)
        {

            //实现，不同 人 不同的问候。

            void EnglishGreeting(string name)
            {
                Console.WriteLine("Good Morning {0}", name);
            }

            void ChineseGreeting(string name)
            {
                Console.WriteLine("早上好 {0}", name);
            }



            //例1 ：-------------定义一个 主 方法 判断，和输出。---------
            void GreetPeople(string name, People people)
            {
                switch (people)
                {
                    case People.Chinese:
                        ChineseGreeting(name);
                        break;
                    case People.English:
                        EnglishGreeting(name);
                        break;
                }
            }

            //例1
            GreetPeople("liming", People.Chinese);

            //例2： 使用委托
            GreetPeople1("xiaoming", EnglishGreeting);


            //例3： Action
            Action b = Outint;
            Action<string, int> b1 = OutString;
            b1("liming", 54);

            //例4： Func 注意点： < 参数类型 , 方法返回类型>

            Func <int,string>func = GetAstring;
            Console.WriteLine(func(9));
        }





        //系统内置的委托：Action  默认是指向 没有参数和返回值的。

        static void OutString(string a,int b)
        {
            Console.WriteLine("Action a:" + a+"int is :"+b);
        }
        static void Outint()
        {
            Console.WriteLine("i am int");
        }
        static string GetAstring(int a)
        {
            return "Iam a func have retun"+"also have a Int valus:"+a;
        }





        // 使用委托的方法------------

        /*单独拎出来看看

        public delegate void GreetingDelegate(string name);


         小方法： --------------------------

           void EnglishGreeting(string name)
            {
                Console.WriteLine("Good Morning {0}", name);
            }

            void ChineseGreeting(string name)
            {
                Console.WriteLine("早上好 {0}", name);
            }



        调用方法 ----------------------------
        private static void GreetPeople1(string name, GreetingDelegate MakeGreeting)

        {
            MakeGreeting(name);
        }
       

        */





    }
}

