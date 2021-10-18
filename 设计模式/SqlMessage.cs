#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式-备忘录模式
 * 唯一标识：3694eb71-a32c-451a-b3c8-29713fd25309
 * 文件名：SqlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 9:29:15
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

namespace 设计模式
{
    /// <summary>
    /// Sql方式操作Message（Originator）
    /// </summary>
    public class SqlMessage
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// Message内容
        /// </summary>
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Message发布时间
        /// </summary>
        private DateTime _publishTime;

        public DateTime PublishTime
        {
            get { return _publishTime; }
            set { _publishTime = value; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            if (mm.PublishTime.Second % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 保存Memento
        /// </summary>
        /// <returns></returns>
        public MessageModel SaveMemento()
        {
            return new MessageModel(_message, _publishTime);
        }

        public void RestoreMemento(MessageModel mm)
        {
            this._message = mm.Message;
            this._publishTime = mm.PublishTime;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
