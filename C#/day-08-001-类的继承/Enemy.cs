using System;
namespace day08001类的继承
{
    public class Enemy
    {
        private float hp;
        private float speed;

        public float Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public float Speed{
            get { return speed; }
            set { speed = value; }
        }
        // 另一种写法， 暂时 不会用（ 怎么传参 到 私有变量。
        public   float Speed1 { get; set; }



        public void AI(){
            Console.WriteLine("这是共有的AI方法");
        }
        public void Move(){
            Console.WriteLine("这是共有的Move方法");
        }

        //定义一个虚方法。 虚方法需要有返回值。 ---这种返回值  可以把这个方法当成参数调用输出  Console.WriteLine(boss1.Said());
        public virtual string Said(){
            return "Iam virtual path";        }
    }
}