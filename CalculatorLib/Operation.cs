using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
	/// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:23:28 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// Operation说明：本代码版权归海陵所有 
    /// 唯一标识：24d2478a-56e8-4df4-afa6-7a6fd321edc4 
    /// </summary> 
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult() => 0;

    }
}
