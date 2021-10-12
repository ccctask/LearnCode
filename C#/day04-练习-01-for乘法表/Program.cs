using System;

namespace day04练习01for乘法表
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i=0; i< 10;i++){

                for (int j = i; j < 10;j++){
                    Console.Write(i + "*" + j + "=" + (i * j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
