#region <<版本注释>>
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：WTG
 * 公司名称：
 * 命名空间：设计模式_访问者模式
 * 唯一标识：17968bbb-19dd-4ab0-bec5-057729f7c62e
 * 文件名：GetVisitor
 * 当前用户域：WTG
 * 
 * 创建者：TMGG
 * 电子邮箱：tm574378328@gmail.com
 * 创建时间：2021/4/25 11:04:03
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
    public class GetVisitor : AbstractVisitor
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
        public override string Visit(AbstractElement abstractElement)
        {
            Message m = abstractElement as Message;
            return m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString() + "\r\n";
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

    }
}
