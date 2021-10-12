using System;

namespace day03布尔运算
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //    “&”   “和”    都为 true 为true
            //    “|”   “或”    有一个为true  则为 true
            //    “^”   “异或”  当值不一样 为true
            //    “！”   “取反”   与一个bool 比较， 对方是true 则 为false
            bool b1 = false;
            bool b2 = false;
            bool re = b1 && b2;
            Console.WriteLine(re);

        }
    }
}
