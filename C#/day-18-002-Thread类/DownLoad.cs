using System;
using System.Threading;
namespace day18002Thread类
{
    public class DownLoad
    {
        private string filename;

        public DownLoad(string Filename)
        {
            this.filename = Filename;
        }

        public void Downfile()
        {
            Console.WriteLine("start Down" + filename);
            Thread.Sleep(2000);
            Console.WriteLine("end");
        }

        //线程池

        
    }
}