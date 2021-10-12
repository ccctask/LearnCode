using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
namespace day11001集合体之一List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> ScoreList = new List<int>(10);  // 常规声明  
            //如果我们提前知道 要存储多少个数据 可以直接设置 以避免重复添加 删除数组 造成的计算机资源浪费，如果超出 会自动变成2倍，默认的容量为4  
            //list 的实质就是创建数组， 调用Arry.copy 方法 将旧的 数组 复制到 新的数组里。

            var ScoreList1 = new List<int>();   //  经常用的声明
             
            var ScoreList2 = new List<int>() { 1, 2, 3 };   //声明 & 赋值

            Console.WriteLine(ScoreList2[0]);  //索引 调用  关于符号： []里面都是索引， {}里面是函数体， （）里面是参数。


            ScoreList2.Add(90); //插入数据 



            Console.WriteLine("List的容量为："+ScoreList2.Capacity);
            Console.WriteLine("当前存储数据的个数为：" + ScoreList2.Count); 
            Console.WriteLine(ScoreList2[3]);


            //使用哈希 值 list     因为类型不确定， 不安全
            Hashtable hashtable = new Hashtable();
            hashtable.Add(100, 100);

            //类型限制的 list
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            //根据index  排序
            SortedList<int, int> keyValuePairs = new SortedList<int, int>();






            foreach(var temp in ScoreList2){
                Console.WriteLine(temp);
            }
            
        }
    }
}
