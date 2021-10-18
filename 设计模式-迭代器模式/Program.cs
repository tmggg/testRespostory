using System;

namespace 设计模式_迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new MessageModel("第1条信息", DateTime.Now);
            collection[1] = new MessageModel("第2条信息", DateTime.Now);
            collection[2] = new MessageModel("第3条信息", DateTime.Now);
            collection[3] = new MessageModel("第4条信息", DateTime.Now);
            collection[4] = new MessageModel("第5条信息", DateTime.Now);
            collection[5] = new MessageModel("第6条信息", DateTime.Now);
            collection[6] = new MessageModel("第7条信息", DateTime.Now);
            collection[7] = new MessageModel("第8条信息", DateTime.Now);
            collection[8] = new MessageModel("第9条信息", DateTime.Now);

            Iterator iterator = new Iterator(collection);
            iterator.Step = 2;
            for (MessageModel mm = iterator.First();!iterator.IsDone;mm = iterator.Next())
            {
                Console.WriteLine(mm.Message);
            }
        }
    }
}
