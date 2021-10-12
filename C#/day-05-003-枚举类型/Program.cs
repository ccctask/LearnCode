using System;

namespace day05003枚举类型
{
    class MainClass
    {
        //定义 ---- 使用枚举的目的 是使得 定义更加清晰。
        enum GameStatus:byte{   //默认int类型的  可以修改类型 
            start=0,         // 默认值 0开始 递增的， 如果第一个是100  后面就是101
            stop=1,        //         1
            pause=2,        //        2
        }
        public static void Main(string[] args)
        {
            //赋值
            GameStatus status = GameStatus.stop;

            //判断
            if(status==GameStatus.stop){
                Console.WriteLine("game stoped");
            }
            Console.WriteLine(status);

        }
    }
}
