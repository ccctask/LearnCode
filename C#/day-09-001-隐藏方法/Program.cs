using System;

namespace day09001隐藏方法
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //隐藏 方法不同于 虚方法，   虚方法一旦被 复写就不存在了， 但是     隐藏方法 ，谁声明  就调用谁的隐藏方法。
            // 虚方法：  谁构造了  就用谁的。   
            father baby = new son();
            baby.Move();


            son baby1 = new son(); 
            baby1.Move();
        }
    }
}
