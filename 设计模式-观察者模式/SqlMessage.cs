#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_观察者模式
 * 唯一标识：93e22b38-96af-4abe-94d4-7670b4d749c1
 * 文件名：SqlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 14:19:53
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
    /// Sql方式操作Message（ConcreteObserver）
    /// </summary>
    public class SqlMessage : IMessage
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public string Insert(MessageModel mm)
        {
            return "sql方式：" + mm.Message + " " + mm.PublishTime.ToString();
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
