using System;

namespace day07001try语句
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            while(true){

                try{
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                }catch{
                    Console.WriteLine("bad input");
                }
                finally
                {
                    Console.WriteLine("ness");
                }
                // break 不能放到这里， 否则就不能循环，
            }
        }
    }
}
