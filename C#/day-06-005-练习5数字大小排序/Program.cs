using System;

namespace day06005练习5数字大小排序
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] strArray = input.Split(' '); // 将用户输入的 以空格分割成数组 赋值给 strArray
            int[] numArray = new int[input.Length];  //设置 int 数组的 长度。

            for (int i = 0; i < input.Length;i++){

                int temp = Convert.ToInt32(strArray[i]); // 将数组的值变成int 数字 进行赋值
                numArray[i] = temp;
                  


            }


        }
    }
}
