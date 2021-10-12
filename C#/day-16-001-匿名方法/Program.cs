using System;

namespace day16001匿名方法  // 一般用于 回调， 和委托一起使用
{
    class MainClass
    {
        static int Text1(int a,int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {

            Func<int, int, int> func1 = Text1;  
                
            //匿名委托 没有方法名。
            Func<int,int> func2=delegate (int a){

                return a;
            };




            //Lambda 
            Func<int, int> func3= (arg1) =>
            {
                return arg1;
            };
            Func<int, int> func4 = arg1 =>arg1;   //返回， 一个值 不用（）一个方法体 ，省略{} 
        }
    }
}
