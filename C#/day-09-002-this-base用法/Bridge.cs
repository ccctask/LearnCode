using System;
namespace day09002thisbase用法
{
    public abstract class Bridge   //抽象类   当包含抽象方法， 就一定要 是抽象类
    {
        private float speed,x,y,z;

        public void Setbridge(float x,float y,float z,float speed){
            this.speed = speed;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //抽象方法
        public abstract void Fly();


    }
}
