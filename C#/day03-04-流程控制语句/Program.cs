using System;

namespace day0304流程控制语句
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 1;

            bool var = true;
            if (var)
                num1++;
            if (num1>=2)
               Console.WriteLine(num1);
        }
    }
}
