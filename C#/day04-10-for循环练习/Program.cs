using System;

namespace day0410for循环练习
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;
            for(int i =0;i<=100;i++){
                if ((i%3==0)&&(i%5!=0)){
                    count++;
                    Console.WriteLine(i);
                   
                }
               
            }
            Console.WriteLine("all is " + count);
        }
    }
}
