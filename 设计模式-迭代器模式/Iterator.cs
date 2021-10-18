#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_迭代器模式
 * 唯一标识：6b97361c-7501-4ebb-a92b-ace05bac75f8
 * 文件名：Iterator
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 16:41:41
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
    public class Iterator : IIterator
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// 当前对象
        /// </summary>
        public MessageModel CurrentMessageModel => _collection[_current];

        /// <summary>
        /// 是否迭代完成
        /// </summary>
        public bool IsDone => _current >= _collection.Count ? true : false;

        /// <summary>
        /// 步长
        /// </summary>
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="collection"></param>
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 第一个对象
        /// </summary>
        /// <returns></returns>
        public MessageModel First()
        {
            _current = 0;
            return _collection[_current];
        }

        /// <summary>
        /// 下一个对象
        /// </summary>
        /// <returns></returns>
        public MessageModel Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current];
            else
                return null;
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
