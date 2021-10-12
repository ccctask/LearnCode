using System;
namespace day09003派生类构造函数
{
    public class Crow:Bridge
    {
        private int y;
         
       
        public Crow(int x ,int y):base(x)
        {
            base.z = 100; // 在父类用 protected 声明的字段 可以直接 访问。 

            this.y = y;
            Console.WriteLine("Crow y coming");
            
        }
    }
}
