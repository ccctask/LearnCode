using System;
namespace day12001泛类型
{
    public class ClassFan<T,A,T1>
    {
        private T a;
        private T b;
        private A c;
        private T1 d;

        public ClassFan(T a,T b) {
            this.a = a;
            this.b = b;
        }
        //数据的构造 写在默认函数里。

        public string add()
        {
            return a +""+b;
        }
       
    }
}
