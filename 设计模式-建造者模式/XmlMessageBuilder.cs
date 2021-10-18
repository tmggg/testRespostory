#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_建造者模式
 * 唯一标识：a9dde235-1dc7-4390-83af-6857d67822a8
 * 文件名：XmlMessageBuilder
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 17:31:37
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
    /// XmlMessage建造者（ConcreteBuilder）
    /// </summary>
    public class XmlMessageBuilder : AbstractMessageBuilder
    {

        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        public XmlMessageBuilder() : base("Xml")
        {
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        #endregion <方法>

        #region <事件>
        #endregion <事件>
        /// <summary>
        /// 建造Xml插入方法
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public override void BuilderInsert(MessageModel mm)
        {
            base._operation["insert"] = "XmlMessage|Insert|" + mm.Message + "|" + mm.PublishTime.ToString() + "";
        }

        /// <summary>
        /// 建造Xml获取方法
        /// </summary>
        public override void BuilderGet()
        {
            base._operation["get"] = "XmlMessage|Get";
        }
    }
}
