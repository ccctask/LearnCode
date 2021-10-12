using System;

namespace day049for练习整除求和
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0; //计数
            int num1 = 0;  //存取 五个的和
            for (int i = 1; i <= 1000; i++){

                if (i%7==0){
                    num1 += i;  //num = 7+14+.... 一直加下去，等于全部的数字相加
                    count++;    
                    Console.WriteLine(i);
                    if(count==5){    // 正常情况  i 为 1个 两个 三个  四个 五个 的和， 这些结果已经出来了， count=5已经 加了5次了
                        Console.WriteLine(num1);
                        count = 0;
                        num1 = 0;
                    }
                }
                  
            }
        }
    }
}
