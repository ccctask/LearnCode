using System;
using System.Text;

namespace day12003字符串和正则表达式
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "hello-hell";

            int LengthS = s.Length;

            if(s=="hellp"){
                Console.WriteLine("相同");

            }else{
                Console.WriteLine("Bu相同");
            }

            //连接

             s = "http://" + s; // 字符串是不能重新赋值的，   重新创建了堆里的数据 并索引到 原来的 s ，实际上是替换，而不是修
                                // string s = "http://" + s     前面加上了类型就变成声明了， 已经存在的变量不允许再声明的。
            string NewS = s.Replace("-", "*");  //做字符串替换
            s.ToUpper();





            //可变的 string 类型 stringbuilder
            StringBuilder sb = new StringBuilder("abcde", 100);  //申请一个能存储100个的 内存空间，  先放一点。
            sb.Insert(1, "https://");
            sb.Remove(3, 2);
            sb.Replace("e", "eeee"); 





            Console.WriteLine(NewS);
        } 

    }
}
