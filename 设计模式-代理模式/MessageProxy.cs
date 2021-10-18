#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_代理模式
 * 唯一标识：d865bc0f-295d-46e2-8d02-b3caf3c2b9f1
 * 文件名：MessageProxy
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 15:07:59
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

namespace 设计模式_代理模式
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class MessageProxy : IMessage
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        SqlMessage _sqlMessage;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        public MessageProxy()
        {
            _sqlMessage = new SqlMessage();
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _sqlMessage.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            return _sqlMessage.Insert(mm);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
