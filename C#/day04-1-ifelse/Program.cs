using System;

namespace day041ifelse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
       if (num < 0)
          Console.WriteLine("good");
           else
               Console.WriteLine("bad");

         // else if
            if (num >= 90)
            {
                Console.WriteLine("num>90");
            }
            else if (num >= 80 && num!=85)
            {
                Console.WriteLine("ok >80");
            }
            else if (num >= 60)
            {
                Console.WriteLine("notbad>60");
            }
            else
            {
                Console.WriteLine("end");
            }
        } 
    }

}