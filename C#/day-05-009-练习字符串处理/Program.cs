using System;

namespace day05009练习字符串处理
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "123456";

            for (int i = 0; i < str.Length;i++){
                int a = str.Length;
                int b = (a - i) - 1;
                //Console.WriteLine(b);

                Console.WriteLine(str[b]);

            }
            //将 字符串 按照 分隔标志，  变成数组。   split  
            string str1 = "my.name.is.liming";
            string[] strArray = str1.Split('.');
            foreach (string var in strArray){
                Console.WriteLine(var);
            }
        }
    }
}
