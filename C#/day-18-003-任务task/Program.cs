using System;
using System.Threading;
using System.Threading.Tasks;
namespace day18003任务task
{
    class MainClass
        /*sock 袜子
         * mouth 嘴巴
         * leg 腿
         * hand 手
         * feet 脚
         * ear 耳朵
         * eye 眼睛
         * cute 可爱的
         *         
         */
    {
    
    
    
    
        static void sock()
        {
            Console.WriteLine("start" + Thread.CurrentThread.ManagedThreadId);//获取线程ID
            Thread.Sleep(1000);
            Console.WriteLine("end");

        }




        static  void cute(Task t)
        {
            Console.WriteLine("Second task");

            // 在这里定义一个子任务， 
            Task shorts = new Task(sock);
            shorts.Start();
        }




        public static void Main(string[] args)
        {
            //第一种
            Task elephant = new Task(cute);  // 里面有一个shorts 的子任务 当它执行完 这个任务才能完成
            elephant.Start();

            //第二种
            TaskFactory mouth = new TaskFactory();
            Task tiger = mouth.StartNew(sock);
            tiger.Start();


            //连续任务

            Task t1 = new Task(sock);
            Task t2 = t1.ContinueWith(cute);  // 作为连续方法  需要 task t 的参数


        }
    }
}
