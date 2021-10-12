using System;
namespace day07002面向对象编程
{
    public class play
    {
        //数据成员
        public string name;
        public int level;
        public bool sex;

        //函数成员 
        public void ShowData(){
            Console.WriteLine("Player-name  :" + name);
            Console.WriteLine("Player-level :" + level);
            if(sex){
                Console.WriteLine("player-sex is man");
            }else{
                Console.WriteLine("player-sex is woman");
            }
        }

       
    }
}
