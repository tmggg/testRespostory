#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_建造者模式
 * 唯一标识：92c4090b-ada9-47b3-a094-08c8431bfd75
 * 文件名：Operation
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 17:11:25
 * 版本：V1.0.0
 * 描述：
 *
 * ----------------------------------------------------------------
 * 修改人：
 * 时间：
 * 修改说明：
 *
 * 版本：V1.0.1
 *----------------------------------------------------------------*/
#endregion <<版本注释>>

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace 设计模式_建造者模式
{
    /// <summary>
    /// 操作（Product）
    /// </summary>
    public class Operation
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private string _type;
        private Dictionary<string, string> _dictionary;
        #endregion <变量>

        #region <属性>
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">产品类型</param>
        public Operation(string type)
        {
            _dictionary = new Dictionary<string, string>();
            this._type = type;
        }
        #endregion <构造方法和析构方法>

        #region <方法>

        /// <summary>
        /// 获得结果
        /// </summary>
        /// <returns></returns>
        public string GetResult()
        {
            Assembly assembly = Assembly.Load("设计模式-建造者模式");
            MethodInfo methodGet = assembly.GetType("设计模式_建造者模式." + _dictionary["get"].Split('|')[0]).GetMethod(_dictionary["get"].Split('|')[1]);
            object objGet = methodGet.Invoke(assembly.CreateInstance("设计模式_建造者模式." + _dictionary["get"].Split('|')[0]), null);
            List<MessageModel> m = (List<MessageModel>)objGet;
            MethodInfo methodInsert = assembly.GetType("设计模式_建造者模式." + _dictionary["insert"].Split('|')[0]).GetMethod(_dictionary["insert"].Split('|')[1]);
            object objInsert = methodInsert.Invoke(assembly.CreateInstance("设计模式_建造者模式." + _dictionary["insert"].Split('|')[0]), new object[] { new MessageModel(_dictionary["insert"].Split('|')[2], Convert.ToDateTime(_dictionary["insert"].Split('|')[3])) });
            bool b = (bool)objInsert;
            return "类型为" + this._type + "的执行结果：\r\n" + b.ToString() + "\r\n" + m[0].Message + " " + m[0].PublishTime.ToString() + "\r\n";
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
