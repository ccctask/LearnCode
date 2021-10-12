using System;

namespace day046break练习
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           //输入正确的回答 就跳出循环，
            while(true){

                string str = Console.ReadLine();
                if(str =="yes"){
                    break;
                }else if(str =="no"){
                    break;
                }
                else{
                    Console.WriteLine("Please Input yes/no");
                }


            }
        }
    }
}
