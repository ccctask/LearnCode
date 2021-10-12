using System;

namespace day047continue中断
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 1;
            while(true){
                num++;
                if(num==5){
                    continue;  // num=5  后面的循环体就不执行了，所以不打印 5
                }
                if(num==10){
                    break;
                }
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
