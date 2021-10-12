using System;

namespace day06003练习题3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int save = 25;

            while (true)
            {
                Console.WriteLine("猜猜这个数字是多少");
                int relave = Convert.ToInt32(Console.ReadLine());
                if (relave < 20)
                {
                    Console.WriteLine("错误： 这个数字比20大");

                }
                else if (relave > 30)
                {
                    Console.WriteLine("错误： 这个数字比30小");

                }
                else if (relave == save)
                {
                    Console.WriteLine("恭喜答对了,这个数字是" + save);
                    break;
                }
            }
        }
    }
}
