#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_工厂方法模式
 * 唯一标识：55f37d8b-0d3b-47ce-bc75-e25fecc9725a
 * 文件名：AbstractMessageFactory
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 13:30:49
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

namespace 设计模式_工厂方法模式
{
    /// <summary>
    /// 抽象Message工厂（Creator）
    /// </summary>
    public abstract class AbstractMessageFactory
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
        /// 工厂方法
        /// </summary>
        /// <returns>AbstractMessage</returns>
        public abstract AbstractMessage CreateMessage();
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
