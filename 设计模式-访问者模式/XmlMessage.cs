#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：c1943d40-9739-4a34-9791-26f17b2e3ac0
 * 文件名：XmlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 11:00:12
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
using System.Text;

namespace 设计模式_访问者模式
{
    /// <summary>
    /// Xml方式操作Message（ConcreteElement）
    /// </summary>
    public class XmlMessage:Message
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        public XmlMessage(MessageModel mm):base(mm)
        {

        }
        #endregion <构造方法和析构方法>

        #region <方法>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML方式获取Message", DateTime.Now));
            return l;
        }

        public override bool Insert()
        {
            return true;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
