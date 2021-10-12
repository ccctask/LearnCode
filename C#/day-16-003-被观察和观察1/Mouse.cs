using System;
namespace day16003被观察和观察1
{
    public class Mouse
    {
        private string name;
        private string colos;

        public Mouse(string name,string colos,Cat cat) // 默认方法用来 在构造的时候 ，传递 参数。
        {
            this.name = name;
            this.colos = colos;
            cat.catCom += this.Run;  // 在Cat 里定义了一个 Action 委托， 接收 Run的方法。
        }
        public void Run()
        {
            Console.WriteLine(colos + "色的老鼠" + name + "开始逃跑了");
        }
    }
}
