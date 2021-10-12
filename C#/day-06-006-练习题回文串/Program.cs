using System;

namespace day06006练习题回文串
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input:");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; )
            {

                i++;
        
                if(input[i]==input[input.Length-i-1]){
                    Console.WriteLine("this is 回文串");
                    break;  //执行循环体 一定要跳出来，  for 循环， if判断 输出结--输出结果了 就该结束这个循环，因此在if处break
                }else{
                    Console.WriteLine("this not a 回文串");
                    break;

                }
                //踩到的坑，   length 是 1-3 。  而字符  索引是 0-2 ， 所以对应关系 是差一位的， 
              // 而且 用 length 表示 索引， 是 inpt[3] 表示有4位 字符， 这是会报错的。
            }

        }
    }
}
