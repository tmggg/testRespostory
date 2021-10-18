#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_解析器模式
 * 唯一标识：fd67cb47-e482-4790-8f25-4dee22690e48
 * 文件名：AbstractExpression
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/26 13:29:25
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
    /// 抽象公式（AbstractExpression）
    /// </summary>
    public abstract class AbstractExpression
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
        public void Interpret(Context context)
        {
            if(String.IsNullOrEmpty(context.Input))
            {
                return;
            }
            context.Output += GetCSharp(context.Input);
        }

        private string GetCSharp(string source)
        {
            string csharp = "";
            string word = "";
            //从输入内容中取得要解释的词
            word = GetWord(source);
            //从字典中找到word对应的C#代码
            GetDictionary().TryGetValue(word, out csharp);
            return csharp;
        }

        /// <summary>
        /// 从输入内容中取得要解释的词
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public abstract string GetWord(string source);

        /// <summary>
        /// 获取字典
        /// </summary>
        /// <returns></returns>
        public abstract Dictionary<string, string> GetDictionary();

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
