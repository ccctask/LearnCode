using System;
namespace day17001反射
{
    public class MyClass
    {
        //字段
        private int Id;
        private int Pass;
        public string Name;

       //属性
        public string Sex { get; set; }
        private int Age { get; set; }


       //方法
        public void Pcount() { }
        private void Bear() { }

        public MyClass()
        {
        }
    }
}
