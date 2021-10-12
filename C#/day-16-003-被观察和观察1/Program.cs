using System;

namespace day16003被观察和观察1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("汤姆", "灰黑");
            Mouse mouse1 = new Mouse("米老鼠","黑",cat1);
           
            //Mouse mouse2=new Mouse("一只耳", "黑");
            //cat1.catCom += mouse2.Run;


            //cat1.CatComming(mouse1,mouse2);
            cat1.CatCom();
            
        }
    }
}

// 这节想起来的东西：   怎么在构造的时候 提供参数 （在默认方法里  赋值）
// 同一个命名空间里的 类和方法 可以直接调用。
/*

  public void CatComming(Mouse mouse1,Mouse mouse2)  
  我们在参数位置  传递 构造 函数， 便可以 在方法体力 调用这个函数的方法了。


        {
            Console.WriteLine(colos + "色的猫" + name + "Comming");
            mouse1.Run();
            mouse2.Run();

*/
