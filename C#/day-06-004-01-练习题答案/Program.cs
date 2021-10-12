using System;

namespace day0600401练习题答案
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length;i++){
                if(input[0]>'a'&&input[i]<'z'){  //可以直接比较 char 
                    int charnum = input[i];
                    charnum += 3;
                    char output =(char)charnum;
                }
            }
        }
    }
}
