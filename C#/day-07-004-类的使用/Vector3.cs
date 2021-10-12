using System;
namespace day07004类的使用
{
    public class Vector3
    {
        private float x = 0, y = 0, z=0;
        public float data;
        private int age;
        public Vector3(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            data = ShowDate();
        }
        public float ShowDate(){
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public void Onrun(){
            Console.WriteLine("GoGO");
        }




        //设置属性-第一次练习
        public int MyPropert{
            set{
                Console.WriteLine("set be used");
                Console.WriteLine("value is" + value);
            }
            get {
                Console.WriteLine("get be used");
                return 100;
            }
        }

        //属性 第二阶段 练习--属性的作用（给 private 不想让外界直接访问的 值， 进行赋值。

        public float X{
            set{
                x = value;   // 设置 类 里的 x值
            }
            get{
                return x;   //从外界 接收值 给value   
            }
        }

        //属性的用处 1----进行数据的校验
        public int Age{
            set {
                if (age>0){
                    age = value;
                }
            }
        }

    }
}
