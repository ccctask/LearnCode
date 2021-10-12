using System;
namespace day08001类的继承
{
    public class Boss:Enemy
    {
        public void Imboos(){
            Console.WriteLine("Iam boos");
        }
        public override string Said()
        {
            return "override by boss";
        }
    }
}
