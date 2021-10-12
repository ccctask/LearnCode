using System;

namespace day06004练习题4字符加密
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
  

            for (int i = 0; i < input.Length;i++){
                char char1 = input[i];
                switch (char1){
                    case 'a':
                        char1 = 'b';
                        break;
                    case 'b':
                        char1 = 'e';
                        break;
                    case 'w':
                        char1 = 'z';
                        break;
                }
                string output=char1.ToString();
                Console.Write(output); 
                //问题1： 输出 input ， 虽然改变了 每个字母，但是 放在 char1里的，输出的是 input是没有变化的
                // input[i]是不能赋值的,所以不能想着 把值 再放回到 iput 变量里。直接输出 char1 或者转成个string 形
            }


        }
    }
}
