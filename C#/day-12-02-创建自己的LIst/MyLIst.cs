using System;
namespace day1202创建自己的LIst
{
    public class MyLIst<T>
    {
        private T[] array;
        private int count;

        public MyLIst(int size)
        {

            if (size > 0)
            {
                array = new T[size];
            }

        }
        public MyLIst()
        {
            array = new T[0];
        }

        //获取 数组长度
        public int CapaCity{
            get { return array.Length; }
        }



        public int Count{
            get { return count; }
        }




    }
}
