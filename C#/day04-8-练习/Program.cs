using System;

namespace day048练习
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入 2个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3=0;
            Console.WriteLine("请选择运算符 0：+  1：- 2：* 3：/");
            string str = Console.ReadLine();

            switch(str){
                case "0":
                    num3 = num1 + num2;
                    str = "+";
                    break;
                case "1":
                    num3 = num1 - num2;
                    str = "-";
                    break;
                case "2":
                    num3 = num1 * num2;
                    str = "*";
                    break;
                case"3":
                    num3 = num1 / num2;
                    str = "/";
                    break;
                default:
                    Console.WriteLine("Please input 运算符");
                    break;
            }
                    Console.WriteLine(num1+str+num2+"="+num3);
            Console.ReadKey();

        }
        }
    }

