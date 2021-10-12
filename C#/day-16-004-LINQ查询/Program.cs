using System;
using System.Collections.Generic;
using System.Linq;

namespace day16004LINQ查询
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var ManList = new List<Man>()
            {
                new Man(){Id=1,Name="李大爷",Age=70,Money=100 },
                new Man(){Id=2,Name="张大爷",Age=50,Money=200},
                new Man(){Id=2,Name="王大爷",Age=50,Money=200},
                new Man(){Id=3,Name="赵大爷",Age=80,Money=900}

            };

            var MoneyList = new List<Money>()
            {
                new Money(){T="1",Id=1,Rmb =50,Dolle=50},
                new Money(){T="2",Id=2,Rmb =150,Dolle=50},
                new Money(){T="3",Id=3,Rmb =250,Dolle=650},

            };
            var res = from m in ManList     //z主语引用字段 using
                      where m.Age > 7 && m.Money == 100  //找到年龄大于
                      select m.Name;    // 输出他的 Name 




            //联合查询
            var driver = from m in ManList
                         from k in MoneyList
                         where m.Name == k.T && m.Money > 300  //  == 才是等于！
                         orderby m.Age descending ,m.Money //从大到小  如果有相同的 按第二个排序 逗号分隔 
                         select m;


            // join  on 查询
            var nuser = from m in ManList
                        join k in MoneyList on m.Id equals k.Id
                        select m.Name;

            //group 分组
            var doctor = from m in ManList
                         group m by m.Age into g
                         select new { count = g.Count(), key=g.Key};

            //any  和all 筛选

            bool hat = ManList.All(m => m.Age == 50);  //都 满足 为 true
            bool pink = ManList.Any(m => m.Age == 70); // 有一个满足 为 true


            foreach (var temp in doctor)
            {
                Console.WriteLine("分组：" + doctor);
            }







            var res1 = ManList.Where(m => m.Age > 7 && m.Money == 100).OrderBy(m=>m.Age).ThenBy(m=>m.Money);//  两次排序


            foreach (var temp in res)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
