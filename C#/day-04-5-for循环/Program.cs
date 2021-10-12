using System;

namespace day045for循环
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            for (int i = 2; i < 101;i++){
                bool iszhishu = true;
                for (int j = 2; j <= i - 1;j++){
                    if(i%j==0){
                        iszhishu = false;// （i（不能被除）：true）（j（能被除数）：false）
                     
                    }

                }
                if(iszhishu){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
