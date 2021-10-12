using System;

namespace day09002thisbase用法
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Bridge bridge = new Crow();

            //  Bridge bridge1 = new Bridge(); 无法用抽象类去构造 函数，但是可以声明。

            Crow bridge1 = new Crow();

            bridge.Fly();
            bridge1.Fly();

            // 抽象类的意义：  我们明知道 里面的东西 一定会被  重写， 那就没必要 去构造这个方法，  直接用抽象类， 要求 所有继承自
            // 这个类的 子类， 必须 实现  父类里的方法。
        }
    }
}
