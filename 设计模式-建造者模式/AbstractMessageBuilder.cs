#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_建造者模式
 * 唯一标识：d618e591-41e2-40df-a03c-95ab7cd5a4fe
 * 文件名：AbstractMessageBuilder
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 17:20:45
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

namespace 设计模式_建造者模式
{
    /// <summary>
    /// 抽象Message建造者（Builder）
    /// </summary>
    public abstract class AbstractMessageBuilder
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// 操作（Product）
        /// </summary>
        protected Operation _operation;

        public Operation Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }
        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">产品类型</param>
        public AbstractMessageBuilder(string type)
        {
            this._operation = new Operation(type);
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 建造者插入方法
        /// </summary>
        /// <param name="mm"></param>
        abstract public void BuilderInsert(MessageModel mm);

        /// <summary>
        /// 建造者获取方法
        /// </summary>
        abstract public void BuilderGet();

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
