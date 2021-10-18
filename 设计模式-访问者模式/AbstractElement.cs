#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：cee218d5-48a5-4918-8e0b-7fa363132abf
 * 文件名：AbstractElement
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 9:54:33
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
    /// 抽象元素（Element）
    /// </summary>
    public abstract class AbstractElement
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
        /// 执行抽象访问者的Visit()方法（从而执行抽象元素的方法）
        /// </summary>
        /// <param name="abstractVisitor">抽象访问者</param>
        /// <returns></returns>
        public abstract string Accept(AbstractVisitor abstractVisitor);
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
