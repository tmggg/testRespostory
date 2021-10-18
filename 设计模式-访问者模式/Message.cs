#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：65b866db-313a-42a7-b787-23ac2ba659c7
 * 文件名：Message
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 10:11:34
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
    /// 操作Message抽象类（Element）
    /// </summary>
    public abstract class Message : AbstractElement
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// Message实体对象
        /// </summary>
        private MessageModel _messageModel;
        public MessageModel MyProperty
        {
            get { return _messageModel; }
            set { _messageModel = value; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public Message(MessageModel mm)
        {
            this._messageModel = mm;
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 执行抽象访问者的Visit()方法（从而执行抽象元素的方法）
        /// </summary>
        /// <param name="abstractVisitor">抽象访问者</param>
        /// <returns></returns>
        public override string Accept(AbstractVisitor abstractVisitor)
        {
            return abstractVisitor.Visit(this);
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <returns></returns>
        public abstract bool Insert();
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
