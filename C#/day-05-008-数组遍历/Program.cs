using System;

namespace day05008数组遍历
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] mystr = new string[] { "day1", "day2", "day3" };


            // for 遍历------------------------------------------------------
            for (int i=0; i < mystr.Length;i++){
                Console.WriteLine(mystr[i]);
            }

            //while 遍历---------------------------------------------------------
            int a = 0;
            do
            {
               
                Console.WriteLine(mystr[a]);
                a++;
            } while (a < mystr.Length);




            //foreach 遍历------------------------------------------------------

            foreach (string temp in mystr){
                Console.WriteLine(temp);
            }



        }
    }
}
