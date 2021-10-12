using System;
namespace 属性的补充
{
    public class EmptyClass
    {
        private string field;
        public string Field
        {
            get {  //get  是获得输入， 对 将要得到的值 做限制  ！！-> return要设置的值
                if (string.IsNullOrEmpty(field))
                      {
                    field="值为空";
                      }
                    return field;
                }


            set  // set 是对 已经拿到的值 做操作。  获得的值都叫value    把值=value， 赋值
            {
                if (value.Length > 5)
                {
                    value = value.Substring(0, 5);
                }
                field = value;
            }
        }
    }
}