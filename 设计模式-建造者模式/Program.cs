using System;

namespace 设计模式_建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            AbstractMessageBuilder amb = new SqlMessageBuilder();
            m.Construct(amb, new MessageModel("测试消息", DateTime.Now));

            Console.WriteLine(amb.Operation.GetResult());

            amb = new XmlMessageBuilder();

            m.Construct(amb, new MessageModel("测试消息", DateTime.Now));

            Console.WriteLine(amb.Operation.GetResult());


        }
    }
}
