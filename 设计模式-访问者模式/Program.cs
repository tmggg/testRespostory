using System;

namespace 设计模式_访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages m = new Messages();

            m.Attach(new SqlMessage(new MessageModel("SQL测试消息", DateTime.Now)));
            m.Attach(new XmlMessage(new MessageModel("XML测试消息", DateTime.Now)));

            Console.WriteLine(m.Accept(new InsertVisitor()));
            Console.WriteLine(m.Accept(new GetVisitor()));
        }
    }
}
