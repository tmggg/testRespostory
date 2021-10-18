#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_抽象工厂
 * 唯一标识：39dbced0-b8d7-4582-81b4-04e0624c2b5b
 * 文件名：Message
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 14:27:46
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

namespace 设计模式_抽象工厂
{
    /// <summary>
    /// Context类
    /// </summary>
    public class Message
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private AbstractMessage _insertMessage;
        private AbstractMessageModel _messageModel;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="factory">AbstractMessageFactory</param>
        public Message(AbstractMessageFactory factory)
        {
            DateTime pt = DateTime.Now;
            _insertMessage = factory.CreateMessage();
            _messageModel = factory.CreateMessageModel();
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        /// <returns></returns>
        public string Insert(string userId,string msg,DateTime pt)
        {
            _messageModel.Message = msg;
            _messageModel.UserId = userId;
            _messageModel.PublishTime = pt;
            return _insertMessage.Insert(_messageModel);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
