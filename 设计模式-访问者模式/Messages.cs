#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：4e2d919f-049b-4d9e-805c-253b8659e825
 * 文件名：Messages
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 11:06:22
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
    public class Messages
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private List<Message> _list = new List<Message>();
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 添加一个Message对象
        /// </summary>
        /// <param name="message">Message对象</param>
        public void Attach(Message message)
        {
            _list.Add(message);
        }

        /// <summary>
        /// 移除一个Message对象
        /// </summary>
        /// <param name="message">Message对象</param>
        public void Detach(Message message)
        {
            _list.Remove(message);
        }

        public string Accept(AbstractVisitor abstractVisitor)
        {
            string s = "";
            foreach (var item in _list)
            {
                s += item.Accept(abstractVisitor);
            }
            return s;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
