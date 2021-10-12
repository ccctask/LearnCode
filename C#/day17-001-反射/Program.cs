using System;
using System.Reflection;
namespace day17001反射
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyClass my = new MyClass();

            Type mytype = my.GetType();
            //其它写法
            //mytype.GetType().GetProperties();
           //mytype.GetType().GetFields();

            Console.WriteLine("获得类名：" + mytype.Name);
            Console.WriteLine("获得命名空间：" + mytype.Namespace);
            Console.WriteLine(mytype.Assembly);  // 获得属性。

            FieldInfo[] infos = mytype.GetFields();
            foreach(FieldInfo temp in infos)
            {
                Console.WriteLine("获取-非私有的字段："+temp);
            }


           PropertyInfo[] propertyInfo= mytype.GetProperties();
            foreach (PropertyInfo temp in propertyInfo)
            {
                Console.WriteLine("获取 非私有的 属性" + temp);
            }



            MethodInfo[] methodInfos = mytype.GetMethods();
            foreach (MethodInfo info in methodInfos)
            {
                Console.Write("获取 非私有的 方法：" + info);
            }





        }
    }
}
