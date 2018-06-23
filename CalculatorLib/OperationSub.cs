using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:46:48 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// OperationSub说明：本代码版权归海陵所有 
    /// 唯一标识：bf397872-9fe9-4349-9f3e-8393ac62bb2b 
    /// </summary> 
    public class OperationSub : Operation
    {
        public override double GetResult() => NumberA - NumberB;
    }
}
