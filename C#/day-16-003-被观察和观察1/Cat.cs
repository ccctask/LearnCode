using System;
namespace day16003被观察和观察1

    //同一个命名空间里的 类和方法可以自由的调用
{
    public class Cat
    {
        private   string name;
        private   string colos;

        public Cat(string name,string colos)
        {
            this.name = name;
            this.colos = colos;
        }

        // 
        public void CatComming(Mouse mouse1,Mouse mouse2)
        {
            Console.WriteLine(colos + "色的猫" + name + "Comming");
            mouse1.Run();
            mouse2.Run();
        }

        // 使用多播委托的方法 

        public void CatCom()
        {
            Console.WriteLine(colos + "色的猫" + name + "Comming");
            catCom();
        }
        public event Action catCom;  // 改成事件。  只能在外部 注册， mouse 里。  不能在外部直接调用了。
        // 我们在外部的调用的是 cat 里的 CatCom方法， 而不是 委托 catCom
    }
}
