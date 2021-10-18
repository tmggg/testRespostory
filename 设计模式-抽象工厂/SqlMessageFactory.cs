#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_抽象工厂
 * 唯一标识：f54cbd12-ce5c-4c3b-8b66-31618a9598f9
 * 文件名：SqlMessageFactory
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 14:21:31
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
    /// SqlMessage工厂（ConcreteFactory）
    /// </summary>
    public class SqlMessageFactory : AbstractMessageFactory
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
        /// 创建SqlMessage对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }

        /// <summary>
        /// 创建SqlMessageModel对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessageModel CreateMessageModel()
        {
            return new SqlMessageModel();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
