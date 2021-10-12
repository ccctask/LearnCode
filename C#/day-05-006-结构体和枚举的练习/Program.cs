using System;

namespace day05006结构体和枚举的练习
{
    class MainClass
    {
        //枚举是
        enum fangxiang
        {
            West,
            North,
            East,
            South,
        }

        //结构体 是 几种类型的集合。  

        struct WhereTogo{
            public float path;
            public fangxiang dir;
        }
        public static void Main(string[] args)
        {
            WhereTogo man1;
            man1.path = 1000;
            man1.dir = fangxiang.West;
        }
    }
}
