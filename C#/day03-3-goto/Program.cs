using System;

namespace day033goto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 1;
            goto mylabel;
            num++;
            mylabel:Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
