using System;
namespace day07004类的使用
{
    public class Vector2D
    {

        private float x, y;

        public void Showxy(float x, float y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Vector:(" + x + "," + y + ")");
        }

    }
}

}
