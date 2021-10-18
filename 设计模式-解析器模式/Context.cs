#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_解析器模式
 * 唯一标识：306a66db-3d44-4503-ab15-1550888836d2
 * 文件名：Context
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/26 13:26:50
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
    /// Context
    /// </summary>
    public class Context
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        /// <summary>
        /// 输入内容
        /// </summary>
        private string _input;
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        /// <summary>
        /// 输出内容
        /// </summary>
        private string _output;

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }


        #endregion <属性>

        #region <构造方法和析构方法>
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="input">输入内容</param>
        public Context(string input)
        {
            this._input = input;
        }
        #endregion <构造方法和析构方法>

        #region <方法>
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
