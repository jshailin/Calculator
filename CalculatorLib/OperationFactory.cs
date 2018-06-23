using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
	/// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 16:54:39 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// OperationFactory说明：本代码版权归海陵所有 
    /// 唯一标识：b1df5e85-de50-4e35-80af-182415f804f5 
    /// </summary> 
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
}
