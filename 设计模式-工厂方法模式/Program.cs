using System;

namespace 设计模式_工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMessageFactory amf = new SqlMessageFactory();
            AbstractMessage am = amf.CreateMessage();

            Console.WriteLine($"{am.Insert(new MessageModel("测试消息",DateTime.Now))}");
            Console.WriteLine($"{am.Get()[0].Message}   {am.Get()[0].PublishTime.ToString()}");

            amf = new XmlMessageFactory();
            am = amf.CreateMessage();
            Console.WriteLine($"{am.Insert(new MessageModel("测试消息", DateTime.Now))}");
            Console.WriteLine($"{am.Get()[0].Message}   {am.Get()[0].PublishTime.ToString()}");
        }
    }
}
