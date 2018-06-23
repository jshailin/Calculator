using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
	/// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:47:56 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// OperationMul说明：本代码版权归海陵所有 
    /// 唯一标识：1e8df956-c85d-49a2-a0bf-e330340b2ab8 
    /// </summary> 
    public class OperationMul:Operation
    {
        public override double GetResult() => NumberA * NumberB;
    }
}
