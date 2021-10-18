using System;

#region 介绍
//提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
#endregion

#region 示例
//有Message和MessageModel，Message有一个Insert()方法，该方法的参数是MessageModel。
#endregion

namespace 设计模式_抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMessageFactory amf = new SqlMessageFactory();
            Message m = new Message(amf);
            Console.WriteLine($"{m.Insert("admin", "Sql方式", DateTime.Now)}");

            amf = new XmlMessageFactory();

            m = new Message(amf);

            Console.WriteLine($"{m.Insert("admin", "Xml方式", DateTime.Now)}");
        }
    }
}
