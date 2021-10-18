#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_解析器模式
 * 唯一标识：66d7f978-2c23-4a1d-9f66-87b775cf41c0
 * 文件名：ObjectExpression
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/26 13:41:05
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
using System.Text.RegularExpressions;

namespace 设计模式_解析器模式
{
    /// <summary>
    /// 终端公式(TerminalExpression)分析与数据库相关的
    /// </summary>
    public class ObjectExpression : AbstractExpression
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
        /// 获取与数据库相关的字典
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("信息", "Message");
            return d;
        }

        /// <summary>
        /// 从输入内容中取得要解释的词
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public override string GetWord(string source)
        {
            MatchCollection mc;
            Regex r = new Regex(@"\[(.*)\]");
            mc = r.Matches(source);
            return mc[0].Groups[1].Value;
        }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

    }
}
