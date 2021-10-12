using System;

namespace day06001练习题1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                string str = Convert.ToString(i);

                string num1 = str[0].ToString();
                char num2 = str[1];

                char num3 = str[2];
                // int num4 = num1*num1*num1 + num2*num2*num2 + num3*num3*num3;
                // Console.WriteLine(num2);

                char n1 = '1';
                char n2 = '5';
                int n3 = n1 * n2;
                Console.WriteLine(num1);
                //怎么转变成可以 用来计算的 表面数字。


                //正确解法：

                for (int i = 100; i < 1000; i++)
                {
                    int ge = i % 10;
                    int shi = (1 / 10) %10;
                    int bai = i / 100;

                }
            }
        }

    }
}
