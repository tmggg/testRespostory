#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_迭代器模式
 * 唯一标识：d2150648-62be-436d-8df4-ba8ae2641dfc
 * 文件名：Collection
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 16:37:17
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
    ///集合（ConcreteAggregate）
    /// </summary>
    public class Collection : ICollection
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private List<MessageModel> list = new List<MessageModel>();
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// 集合内的对象总数
        /// </summary>
        public int Count => list.Count;


        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index">index</param>
        /// <returns></returns>
        public MessageModel this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 创建迭代器对象
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
