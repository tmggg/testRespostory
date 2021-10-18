#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_观察者模式
 * 唯一标识：8598e54f-c689-42f0-ade2-67bac1be46c1
 * 文件名：AbstractMessageSubject
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 14:22:32
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

namespace 设计模式_观察者模式
{
    /// <summary>
    /// 抽象Message主题（Subject）
    /// </summary>
    public abstract class AbstractMessageSubject
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private MessageModel _messageModel;
        private List<IMessage> list = new List<IMessage>();
        #endregion <变量>

        #region <属性>
        public DateTime PublishTime
        {
            get { return _messageModel.PublishTime; }
            set 
            {
                _messageModel.PublishTime = value;
                Notify();
            }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public AbstractMessageSubject(MessageModel mm)
        {
            this._messageModel = mm;

        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 添加一个实现IMessage接口的对象
        /// </summary>
        /// <param name="m">实现IMessage接口的对象</param>
        public void Attach(IMessage m)
        {
            list.Add(m);
        }
        /// <summary>
        /// 移除一个实现IMessage接口的对象
        /// </summary>
        /// <param name="m">实现IMessage接口的对象</param>
        public void Detach(IMessage m)
        {
            list.Remove(m);
        }
        /// <summary>
        /// 通知所有的观察者
        /// </summary>
        /// <returns></returns>
        public string Notify()
        {
            string s = string.Empty;
            foreach (var item in list)
            {
                s += item.Insert(_messageModel);
                s += "\r\n";
            }
            return s;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
