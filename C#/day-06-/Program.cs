using System;

namespace day06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("请设置密");
            string pass = Console.ReadLine();
            int sorces = 1;
            for (int i = 0; i < pass.Length;)
            {
               
                int passchar = pass[i];

                Console.WriteLine(passchar);

                if (passchar > 64 && passchar < 91)
                {
                    sorces++;
                    break;
                }
                else if (passchar > 96 && passchar < 123)
                {
                    sorces++;
                    break;
                }
                else if (passchar >= 49 && passchar <= 57)
                {
                    sorces++;
                    break;
                }

                i++;
            }
            Console.WriteLine(sorces + "匹配");

            if (sorces >= 2)
            {
                Console.WriteLine("good pass");

            }
            else
            {
                Console.WriteLine("bad pass");

            }
        }
    }
}
