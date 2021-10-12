using System;
using System.Threading;
namespace day18001线程
{
    class MainClass
    { static int Text(string a)
        {
            Console.WriteLine(a);
            Thread.Sleep(10);
            return 100;
        }
        public static void Main(string[] args)
        {

            Func<string, int> func = Text;

            //IAsyncResult  取得一个 线程 (,回调方法,返回参数)
            IAsyncResult async = func.BeginInvoke("Text",null,null);



            //回调函数 
            func.BeginInvoke("Text", a=> {
                int res = func.EndInvoke(a);
                Console.WriteLine(res);
            }, null);


            //IsCompleted 线程判断
            while (async.IsCompleted==false)
            {
                Console.WriteLine("线程 未完成");
                Thread.Sleep(10);
            }

           

            // 设置等待时间， 1000毫秒内是否完成了进程。
            bool Isend = async.AsyncWaitHandle.WaitOne(100);
            if (Isend)
            {
                Console.WriteLine("线程在100毫秒内完成");
                //取得线程的返回值
                int funcReturn = func.EndInvoke(async);
                Console.WriteLine(funcReturn);
            }




            Console.WriteLine("Main");
        }
    }
}
