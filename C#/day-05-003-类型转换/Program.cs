using System;

namespace day05003类型转换
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  小类型 转换 到大类型  系统自动转换

            byte mybyte = 20;
            int myint = mybyte;

            mybyte = (byte)myint;//强制转换
        }
    }
}
