using System;

namespace 设计模式_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubject m = new MessageSubject(new MessageModel("插入Message", DateTime.Now));

            SqlMessage sqlMessage = new SqlMessage();
            XmlMessage xmlMessage = new XmlMessage();

            m.Attach(sqlMessage);
            m.Attach(xmlMessage);

            Console.WriteLine(m.Notify());

            System.Threading.Thread.Sleep(2000);
            m.PublishTime = DateTime.Now;

            Console.WriteLine(m.Notify());


        }
    }
}
