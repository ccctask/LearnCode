using System;

namespace day08001类的继承
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boss boss1 = new Boss();

            boss1.AI();


            // 父类 声明 ，可以用子类 构造，需要强制类型转换。 反之不行。
            Enemy enemy;
            enemy = new Boss();
            Boss boss = (Boss)enemy;




            //虚方法调用
            Console.WriteLine("boss 子类重写的said方法"+boss1.Said());
            Console.WriteLine("父类的said方法"+enemy.Said());





            //调用 dog 重写的 方法。
            dog dog1 = new dog();
            Console.WriteLine("dog子类型 重写的said方法" + dog1.Said());

            //因为 enemy 是用 boss 类构造的 所以--还是用boos 的重写
            Console.WriteLine("父类的said方法" + enemy.Said());


            Console.WriteLine("dog重写后boss 子类的said方法" + boss1.Said());

            //优先调用 自己类里 重写的 方法、 
        }
    }
}
