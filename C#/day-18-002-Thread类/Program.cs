using System;
using System.Threading;
namespace day18002Thread类
{
    class MainClass
    {
        static void Download(object filename) // thread 只接受 object 类型的参数。
        {
            Console.WriteLine("start"+Thread.CurrentThread.ManagedThreadId);//获取线程ID
            Thread.Sleep(1000);
            Console.WriteLine("end");
        }
        public static void Main(string[] args)
        {
            //1.基础方法 
            Thread Down = new Thread(Download); //创建异步线程
            Down.Start("filename");                       //开始线程

            Console.WriteLine("Main");

            //2. lamda 参数 ，替代书写方法， 方法没有参数 就不写参数。
            Thread LamDown = new Thread(() =>
            {
                Console.WriteLine("start" + Thread.CurrentThread.ManagedThreadId);//获取线程ID
                Thread.Sleep(1000);
                Console.WriteLine("end");
            });


            //3.通过类传递 带参数的方法。

            DownLoad down = new DownLoad("huluwa");
            Thread downthread = new Thread(down.Downfile);
            downthread.IsBackground = true;                 // 设置成后台线程
            downthread.Start();

            //线程池 只能用于 进程短的  后台线程，
            ThreadPool.QueueUserWorkItem(Download);



        }
    }
}
