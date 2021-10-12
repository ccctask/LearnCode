using System;

namespace day05001判断字母大小写
{
    class MainClass
    {
        public static void Main(string[] args)
        {


           
                string str = Console.ReadLine();

                for (int i = 0; i < 5; i++)
                {
                    char c1 = str[i];  //A =65  Z=90   a=97 z=122
                    int num = c1;


                    if (num >= 65 && num <= 90)
                    {
                        Console.WriteLine("good");
                        continue;
                    }
                    else
                    {
                     
                        Console.WriteLine("请将第"+(i+1)+"个字母输入成大写字母");
                    }
                }




                Console.ReadKey();
            }
        }

}
