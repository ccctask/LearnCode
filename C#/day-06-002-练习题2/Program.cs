using System;

namespace day06002练习题2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 364;
            int scores = 0;
            int less = num % 3;
            for (int i=1; i < 365;i++){
                if(i%3==0){
                    scores++;
                       
                }

            }
            Console.WriteLine("可以喝" + scores + "瓶可乐");
            Console.WriteLine("剩余" + less + "空瓶");
        }
    }
}
