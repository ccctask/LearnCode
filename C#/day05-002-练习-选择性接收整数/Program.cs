using System;

namespace day05002练习选择性接收整数
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while(true) {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write(i + "");
                    }
                }
                    else if (num < 0)
                        {
                            return;
                        }
                                   
            }

        }
    }

}