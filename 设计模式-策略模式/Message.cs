#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_策略模式
 * 唯一标识：9f5e1720-c5ec-4ed7-ae8d-ea3c60c60f7e
 * 文件名：Message
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 11:18:10
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

namespace 设计模式_策略模式
{
    /// <summary>
    /// Context类
    /// </summary>
    class Message
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        /// <summary>
        /// 声明一个IMessageStrategy类型
        /// </summary>
        private IMessageStrategy _strategy;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strategy">具体算法</param>
        public Message(IMessageStrategy strategy)
        {
            this._strategy = strategy;
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _strategy.Get();
        }


        public bool Insert(MessageModel mm)
        {
            return _strategy.Insert(mm);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
