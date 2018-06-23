using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
	/// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:48:29 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// OperationDiv说明：本代码版权归海陵所有 
    /// 唯一标识：8514fdfa-7adb-43c5-bde6-c0d7aa33967c 
    /// </summary> 
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            if (Math.Abs(NumberB) <1e-10)
                throw new Exception("除数不能为0.");
            return NumberA / NumberB;
        }
    }
}
