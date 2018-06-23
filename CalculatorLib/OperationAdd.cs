using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:34:53 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// OperationAdd说明：本代码版权归海陵所有 
    /// 唯一标识：c397d86c-6c16-4e99-8362-f125e2239257 
    /// </summary> 
    public class OperationAdd : Operation
    {
        public override double GetResult() => NumberA + NumberB;
        
    }
}
