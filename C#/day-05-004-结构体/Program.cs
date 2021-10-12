using System;

namespace day05004结构体
{
    class MainClass
    { 

        //目的 是不用 多次 重复的定义 一个变量
        // 两个角色位置，  定义 2个x   2个y 2个z   使用结构体， 只需要一个结构体， 每个角色 定义成结构体，直接调用 结构体里的xyz
        struct Position{
            public float x;
            public float y;
            public float z;
        }
         
        public static void Main(string[] args)
        {

            Position man1;
            man1.x = 1;

             
        }
    }
}
