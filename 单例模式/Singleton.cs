#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：单例模式
 * 唯一标识：c35323ed-367e-44c1-a442-53f87e38baae
 * 文件名：Singleton
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/23 15:28:28
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

namespace 单例模式
{
    public class Singleton<T> where T:new()
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        #endregion <属性>

        #region <构造方法和析构方法>
        #endregion <构造方法和析构方法>

        #region <方法>
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }
}
