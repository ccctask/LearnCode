using System;
namespace day09001隐藏方法
{
    public class son:father
    {
        public new void Move(){
            Console.WriteLine("这里是 son 的move 方法");
        }
    }
}
