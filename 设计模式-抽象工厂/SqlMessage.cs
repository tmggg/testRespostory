#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_抽象工厂
 * 唯一标识：9c7cdb00-ec08-47b6-8d52-a415e6c37423
 * 文件名：SqlMessage
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 14:16:39
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
    public class SqlMessage : AbstractMessage
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
        /// 插入Message
        /// </summary>
        /// <param name="amm">AbstractMessageModel</param>
        /// <returns></returns>
        public override string Insert(AbstractMessageModel amm)
        {
            return "Sql方式插入Message。帐号：" + amm.UserId + "；内容：" + amm.Message + "；时间：" + amm.PublishTime.ToString();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
