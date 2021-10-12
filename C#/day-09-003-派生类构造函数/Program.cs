using System;

namespace day09003派生类构造函数
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Son son1 = new Son();
            // son1.MySon(); // 我们在 myson 里面没有定义任何东西， 默认调用 父类里的 默认构造函数 public Father()

            Son son1 = new Son("li","ming");



            Bridge.v1 = 100;  //static 声明的东西 只能通过类名调用。
            Bridge.Staticff();
            
        }


    }
}
