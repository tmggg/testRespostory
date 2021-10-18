#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_抽象工厂
 * 唯一标识：d79dc1f5-ccde-481e-9af2-9f89531d35a9
 * 文件名：SqlMessageModel
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 14:05:57
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
    /// <summary>
    /// SqlMessage实体类（Product）
    /// </summary>
    public class SqlMessageModel : AbstractMessageModel
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        private string _userId;

        public override string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlMessageModel():base()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userid">UserId</param>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        public SqlMessageModel(string userid,string msg,DateTime pt):base(msg,pt)
        {
            this._userId = userid;
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
