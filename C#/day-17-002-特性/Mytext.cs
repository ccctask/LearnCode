using System;
namespace day17002特性
{
    //特性不能被继承 sealed  以 Attribute 结尾  并继承自 Attribute
    [AttributeUsage(AttributeTargets.Class)]  //定义特性可以使用的 类型
    sealed class MytextAttribut:System.Attribute
    {
        private int ID { get; set; }
    }
}
