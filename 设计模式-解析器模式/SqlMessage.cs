#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_解析器模式
 * 唯一标识：50fa054b-5d95-4296-83c1-4bf1dae510d2
 * 文件名：SqlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/26 13:24:40
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

namespace 设计模式_解析器模式
{
    /// <summary>
    /// Sql方式操作Message
    /// </summary>
    public class SQLMessage
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
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public static List<MessageModel> Get()
        {
            List<MessageModel> I = new List<MessageModel>();
            I.Add(new MessageModel("SQL方式获取Message",DateTime.Now));
            return I;
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
