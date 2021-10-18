using System;

namespace 设计模式_代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageProxy m = new MessageProxy();
            Console.WriteLine($"{m.Insert(new MessageModel("插入",DateTime.Now))}");
            Console.WriteLine($"{m.Get()[0].Message}{m.Get()[0].PublishTime.ToString()}");
        }
    }
}
