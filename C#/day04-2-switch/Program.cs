using System;

namespace day042switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 2;
            switch(num){
                case 1:
                    Console.WriteLine("num=1");
                    break;
                case 2:
                    Console.WriteLine("num=2");
                    break;
                case 30:
                case 3:
                    Console.WriteLine("num=3");
                    break;
                default:
                    Console.WriteLine("bad input");
                    break;
            }

        }
    }
}
