using System;
using System.Collections.Generic;
using System.Reflection;

namespace 设计模式_解析器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            string chinese = "{数据库}[信息](获取)";
            Context context = new Context(chinese);
            List<AbstractExpression> I = new List<AbstractExpression>();
            I.Add(new DatabaseExpression());
            I.Add(new ObjectExpression());
            I.Add(new MethodExpression());
            foreach (var item in I)
            {
                item.Interpret(context);
            }
            //加载库文件
            Assembly assembly = Assembly.Load("设计模式-解析器模式");
            MethodInfo method = assembly.GetType("设计模式_解析器模式." + context.Output.Split('.')[0]).GetMethod(context.Output.Split('.')[1].Replace("()", ""));
            object obj = method.Invoke(null, null);
            List<MessageModel> m = (List<MessageModel>)obj;
            //
            Console.WriteLine("中文语法：" + chinese + "\r\n");
            Console.WriteLine("解释后的C#代码：" + context.Output + "\r\n");
            Console.WriteLine("执行结果：" + m[0].Message + " " + m[0].PublishTime.ToString() + "\r\n");
            //
        }
    }
}
