using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
namespace day13001正则表达式
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "my name is impcat and from hell";

            //----------------------反义符  -------------------------
            string regexs = @"[^m]"; // 匹配非 m 的字符

            string restS = Regex.Replace(s, "^", "Start--");


            string rests1 = Regex.Replace(s,regexs,"---");//使用
            string rests2 = Regex.Replace(s, @"[^ m]", "0000");
            //-----------------------------------------------

            Console.WriteLine(restS);
            Console.WriteLine(rests1);
            Console.WriteLine(rests2);


            // replace 属性的使用
            string a = "gogogogogo";
            string reseta=a.Replace("g", "a");
            Console.WriteLine(reseta);

            //正则表达式 replace 属性
            string s1 = Regex.Replace(s, "$", "end...");


            /* 

                     . 匹配除了 换行符 以外的 任意字符。

                     \w 匹配（大小写）字母， 数字， 下划线， 汉字

                     \W   \w 的补集 

                     \s  匹配任意空白字符 （ /n 换行符  /r 回车符  /t tab  /v 垂直制表符   /f 换页符

                     \S  补集

                     \d  匹配数字

                     \D  补集

                     [abc] 匹配abc 

                     [a-c] 匹配a到c
                     [^a] 匹配除了a           


                                                                     */




            //接收并判断

            string pass = Console.ReadLine(); 
            string passTemp = @"^\d*$";  //正则表达式
                                         //  @^\d*$   ^\d开头   \d* 任意个 \d     \d*$ 

            bool isMath = Regex.IsMatch(pass, passTemp);  // 使字符串和正则表达式 匹配。
            Console.WriteLine(isMath);


            /*
              注意：  子集 满足条件 也会被输出  例 1
              {n}      匹配 n 次
              {n,}     匹配 n 次 或者多余 n 次
              {n,m}    匹配 n 到 m 次
              ？       重复0次 或者 一次
              +        重复 1次 或者多次
              *        多次
                          
             */






            // 例1 

            string pass1 = "12345";
            string pass2 = "d12345";

            string Goodpass1 = @"\d{3,5}"; //匹配 3-5个数  但如果是 6个字符，只要包含了 3-5个数字就输出 true
            string Goodpass2 = @"^\d{3,5}$";

            Console.WriteLine("pass2 is :"+Regex.IsMatch(pass2, Goodpass1));
            Console.WriteLine("pass2 is :"+Regex.IsMatch(pass2, Goodpass2));

            Console.WriteLine("pass1 is :"+Regex.IsMatch(pass1, Goodpass2));




            //分割

            string pencil = "liming,zhanglei;huangzhong";
            string panda = @"[,;]";
            string []  DES = Regex.Split(pencil, panda);  // 分出来的是数组 
            foreach (string temp in DES)
            {
                Console.WriteLine(temp);
            }


            // 分组操作符

            string desk = "dfre.wfe_daw";
            string pencilCars = "abs1abs2defabss";
            string girl = @"(ab\w{2}){2}";

            Console.WriteLine(Regex.Replace(desk, girl, "***"));
            Console.WriteLine(Regex.Replace(pencilCars, girl, "***"));


        }
    }
}
