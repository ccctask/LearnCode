using System;

namespace day16002事件
{
    class MainClass
    {
        public  delegate void Mydelegate();
        public event Mydelegate Delegate1; // 事件

        //Mydelegate Delegate2;

        public static void Main(string[] args)
        {

            MainClass p = new MainClass();
            p.Delegate1 = Text;  // 声明成事件后  只能在构造函数里调用。


            Mydelegate Delegate2; 
            //定义在方法里面 直接引用， 如果放在 类里， 就不能 直接引用了，是上级的东西。只能通过 类.xxx 的方式引用
            Delegate2 = Text;
        }

       public static void Text()
        {
            Console.WriteLine("text1");
        }
    }
}
