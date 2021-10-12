using System;
namespace day09003派生类构造函数
{
    public class Son : Father
    {
        public void MySon()
        {
            //空的
        }





        private string lastname;

        public Son(string firstname, string lastname) : base(firstname)        {
            this.lastname = lastname;
            Console.WriteLine("son lastname");
        }
    }

}