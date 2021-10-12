using System;
namespace day09003派生类构造函数
{
    public class Father
    {
        public Father()
        {
            Console.WriteLine("Father空方法");
        }

        //
        private string  firstname;


        //定义一个字段 派生给子类  (需要在默认方法里
        public  Father(string firstname){
            this.firstname = firstname;
            Console.WriteLine("Father firstname");
        }
    }
}
