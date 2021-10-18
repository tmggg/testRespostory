#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：51d6c947-dcb7-42b9-a74a-e94925496bb1
 * 文件名：SqlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 10:57:06
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
    /// Sql方式操作Message（ConcreteElement）
    /// </summary>
    public class SqlMessage : Message
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
        /// <param name="mm">Message实体对象</param>
        public SqlMessage(MessageModel mm):base(mm)
        {

        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL方式获取Message", DateTime.Now));
            return l;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            return true;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
