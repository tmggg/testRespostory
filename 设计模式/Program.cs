using System;
using System.Diagnostics;
using System.Threading;

#region 介绍
//在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到保存的状态。
#endregion

#region 示例
//有一个Message实体类，某个对象对它的操作有Insert()方法，只有在插入时间符合要求的情况下才能插入成功，因此要求可以保存和恢复Message对象的状态，插入失败后则恢复Message对象的状态，然后只更新时间，再次插入。
#endregion


/// <summary>
/// 
/// </summary>
namespace 设计模式
{


    class Program
    {
        static void Main(string[] args)
        {
            //a
            //d
            //c
            //d
            SqlMessage m = new SqlMessage();
            int temp1 = 1;
            m.Message = "测试内容";
            m.PublishTime = DateTime.Now;
            int test = 3;

            MessageModelCaretaker mmc = new MessageModelCaretaker();
            mmc.MessageModel = m.SaveMemento();
            //
            bool result = false;
            while (!result)
            {
                //
                result = m.Insert(new MessageModel(m.Message, m.PublishTime));
                Console.WriteLine(m.Message + " " + m.PublishTime.ToString() + " " + result.ToString());
                if (!result)
                {
                    Thread.Sleep(2000);
                    m.RestoreMemento(mmc.MessageModel);
                    m.PublishTime = DateTime.Now;
                }
                //mmmmmm
                //mmmm
                //mmmm
            }




        }

    }
}
