using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace ConsoleTest
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/23 17:00:09 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// ConsoleTest说明：本代码版权归海陵所有 
    /// 唯一标识：295b8337-021d-4667-9a99-128b44f75c74 
    /// </summary> 
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("/");
            oper.NumberA = 2.3;
            oper.NumberB = 0;
            Console.WriteLine(oper.GetResult());

            Console.ReadKey();
        }
    }
}
