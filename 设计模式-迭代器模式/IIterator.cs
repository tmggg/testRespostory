#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_迭代器模式
 * 唯一标识：4dfb3c86-dd39-4339-ba24-bf3c8a5e0f9a
 * 文件名：IIterator
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 16:34:19
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

namespace 设计模式_迭代器模式
{
    /// <summary>
    /// 迭代器接口（IIterator）
    /// </summary>
    public interface IIterator
    {
        #region <属性>
        /// <summary>
        /// 当前对象
        /// </summary>
        MessageModel CurrentMessageModel { get; }
        /// <summary>
        /// 是否迭代完成
        /// </summary>
        bool IsDone { get; }
        #endregion <属性>

        #region <方法>
        /// <summary>
        /// 第一个对象
        /// </summary>
        /// <returns></returns>
        MessageModel First();

        /// <summary>
        /// 下一个对象
        /// </summary>
        /// <returns></returns>
        MessageModel Next();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
