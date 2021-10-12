using System;

namespace day07002面向对象编程
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //又叫 结构化编程

            //使用类 必须引入  该对象的 命名空间 namespace  ，这里我们是在一个命名空间定义的  不用引用。 

            play liming = new play();

            liming.level = 99;
            liming.name = "liming";
            liming.sex = true;

            liming.ShowData();
        }
    }
}
